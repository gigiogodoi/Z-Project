using AutoMapper;
using CMCVirtual.BO;
using CMCVirtual.BO.Contracts;
using CMCVirtual.Core.Contracts;
using CMCVirtual.Core.Enumerations;
using CMCVirtual.Core.TO;
using System;
using System.Collections.Generic;

namespace CMCVirtual.Controller
{
    public class CMCController : IController
    {
        public  IHostBO          HostBO    { get; set; }
        public  IStationBO       StationBO { get; set; }
        public  IProfileBO       ProfileBO { get; set; }
        private ControllerStatus CurrentStatus;

        public CMCController()
        {
            SetCurrentStatus(ControllerStatus.Idle);
        }

        public ControllerResultTO<LoginTO> AutoLogin()
        {
            try
            {
                ControllerResultTO<LoginTO> RetLogin = null;
                var lastTO = ProfileBO.GetLastLogin();
                if (lastTO != null)
                {
                    var resultTO = ChangeStation(lastTO.StationNumber, true);
                    RetLogin     = Mapper.Map<ControllerResultTO<LoginTO>>(resultTO);
                    RetLogin.TO  = lastTO;

                    if (RetLogin.Result == Result.Pass && 
                        StationBO.GetCurrent().Name != lastTO.StationName)
                    {
                        throw new ApplicationException("Valores no arquivo de configuração inválidos");
                    }
                }
                return RetLogin;
            }
            catch (Exception ex)
            {
                SetCurrentStatus(ControllerStatus.Idle);
                StationBO.SetCurrent(null);
                return new ControllerResultTO<LoginTO>
                {
                    Result         = Result.Fail,
                    ExecuteMessage = ex.Message,
                    PromptMessage  = "Falha ao carregar estacao!",
                    Exception      = ex
                };
            }
        }

        public ControllerResultTO<LoginTO> ChangeStation(long stationNumber, bool autoLogin=false)
        {
            try
            {
                StationBO.ChangeStation(stationNumber);
                var resultTO = StationBO.GoFirstStep();
                if (resultTO.Result == Result.Pass)
                {
                    if (!autoLogin)
                    {
                        var loginTO = Mapper.Map<LoginTO>(StationBO.GetCurrent());
                        ProfileBO.WriteLogin(loginTO);
                    }
                    SetCurrentStatus(ControllerStatus.WaitUserInput);
                }
                return new ControllerResultTO<LoginTO>
                {
                    Result        = resultTO.Result,
                    PromptMessage = resultTO.Message,
                    TO            = Mapper.Map<LoginTO>(StationBO.GetCurrent())
                };
            }
            catch (Exception ex)
            {
                SetCurrentStatus(ControllerStatus.Idle);
                StationBO.SetCurrent(null);
                return new ControllerResultTO<LoginTO>
                {
                    Result         = Result.Fail,
                    ExecuteMessage = ex.Message,
                    PromptMessage  = "Falha ao carregar estacao!",
                    Exception      = ex
                };
            }
        }

        public ControllerResultTO ExecuteFlow(string data)
        {
            var controllerResult = new ControllerResultTO();
            try
            {
                if (!StationBO.IsLoad())
                {
                    throw new ApplicationException("Estacao nao configurada");
                }
                else if (GetCurrentStatus() == ControllerStatus.WaitUserInput)
                {
                    SetCurrentStatus(ControllerStatus.Busy);

                    var resultTO = StationBO.Execute(data);

                    controllerResult.Result         = resultTO.Result;
                    controllerResult.ExecuteMessage = resultTO.ExecuteMessage;
                    controllerResult.PromptMessage  = resultTO.PromptMessage;
                    SetCurrentStatus(ControllerStatus.WaitUserInput);
                }
            }
            catch (Exception ex)
            {
                controllerResult.Result            = Result.Fail;
                controllerResult.ExecuteMessage    = ex.Message;
                controllerResult.Exception         = ex;
                controllerResult.PromptMessage = StationBO.GetCurrentStep()?.Data.Prompt;
                SetCurrentStatus(ControllerStatus.WaitUserInput);
            }
            return controllerResult;
        }

        public ControllerResultTO<ICollection<HostTO>> GetHostList()
        {
            try
            {
                return new ControllerResultTO<ICollection<HostTO>>
                {
                    Result = Result.Pass,
                    TO     = HostBO.ListAll()
                };
            }
            catch (Exception ex)
            {
                return new ControllerResultTO<ICollection<HostTO>>
                {
                    Result         = Result.Fail,
                    ExecuteMessage = ex.Message,
                    Exception      = ex
                };
            }
        }

        public ControllerResultTO<ICollection<StationTO>> GetStationList(int hostNumber)
        {
            try
            {
                return new ControllerResultTO<ICollection<StationTO>>
                {
                    Result = Result.Pass,
                    TO     = StationBO.ListByHost(hostNumber)
                };
            }
            catch (Exception ex)
            {
                return new ControllerResultTO<ICollection<StationTO>>
                {
                    Result         = Result.Fail,
                    ExecuteMessage = ex.Message,
                    Exception      = ex
                };
            }
        }

        public ControllerResultTO ResetFlow()
        {
            var controllerResult = new ControllerResultTO();
            try
            {
                if (!StationBO.IsLoad())
                {
                    throw new ApplicationException("Estacao nao configurada");
                }
                else if (GetCurrentStatus() == ControllerStatus.WaitUserInput)
                {
                    SetCurrentStatus(ControllerStatus.Busy);

                    SessionBO.GetInstance().ClearAllVariables();

                    var resultTO = StationBO.GoFirstStep();

                    controllerResult.Result        = resultTO.Result;
                    controllerResult.PromptMessage = resultTO.Message;
                }
            }
            catch (Exception ex)
            {
                controllerResult.Result         = Result.Fail;
                controllerResult.ExecuteMessage = ex.Message;
                controllerResult.PromptMessage  = StationBO.GetCurrentStep().Data.Prompt;
                controllerResult.Exception      = ex;
            }
            finally
            {
                SetCurrentStatus(ControllerStatus.WaitUserInput);
            }
            return controllerResult;
        }

        public bool ValidateUserPassword(string login, string password)
        {
            try
            {
                return ProfileBO.ValidateUserPassword(login, password);
            }
            catch
            {
                return false;
            }
        }

        private ControllerStatus GetCurrentStatus()
        {
            return CurrentStatus;
        }

        private void SetCurrentStatus(ControllerStatus status)
        {
            CurrentStatus = status;
        }
    }
}
using AutoMapper;
using CMCVirtual.BO.Contracts;
using CMCVirtual.Core.Enumerations;
using CMCVirtual.Core.TO;
using CMCVirtual.DAO.Contracts;
using System.Collections.Generic;
using System.Linq;
using CMCVirtual.Extensions;
using System;

namespace CMCVirtual.BO
{
    public class StationBO : BaseBO<StationTO, IStationDAO>, IStationBO
    {
        public IStepBO    StepBO    { get; set; }
        public IProfileBO ProfileBO { get; set; }

        private StepTO GetFirstStep()
        {
            return GetCurrent().Steps.OrderBy(i => i.Index).First();
        }

        public void ChangeStation(long stationNumber)
        {
            var station = Get(stationNumber);

            this.SetCurrent(station);
        }

        public ExecuteResultTO Execute(string data)
        {
            var resultTO   = new ExecuteResultTO();
            var hasFork    = (StepBO.GetCurrent().Fork > 0);
            var isLast     = (StepBO.GetCurrent().Last);
            var executeTO  = StepBO.Execute(data);
            var nextStepTO = GoNextStep(executeTO);

            if (executeTO.Result == Result.Fail && hasFork && !isLast)
            {
                resultTO = Execute(data);
            }
            else
            {
                resultTO.Result         = executeTO.Result;
                resultTO.ExecuteMessage = executeTO.Message;
                resultTO.PromptMessage  = nextStepTO.Message;
            }
            return resultTO;
        }

        public ICollection<StationTO> ListByHost(int hostNumber)
        {
            var domain = DefaultDAO.ListByHost(hostNumber);
            return Mapper.Map<ICollection<StationTO>>(domain);
        }

        public StationTO Get(long stationNumber)
        {
            var domain    = DefaultDAO.Get(stationNumber);
            var station   = Mapper.Map<StationTO>(domain);
            station.Steps = StepBO.ListByStation(station.Type, station.Number);
            return station;
        }

        public ResultTO GoFirstStep()
        {
            var firstStep = GetCurrent().Steps.OrderBy(i => i.Index).First();
            StepBO.SetCurrent(firstStep);
            return new ResultTO
            {
                Result  = Result.Pass,
                Message = firstStep.Data.Prompt
            };
        }

        public StepTO GetCurrentStep()
        {
            if (this.IsLoad())
                return StepBO.GetCurrent();
            else
                return null;
        }

        private ResultTO GoNextStep(ResultTO result)
        {
            var currentStep = StepBO.GetCurrent();

            if (result.Result == Result.Pass)
            {
                var secondStep = GetSecondStep(currentStep);
                if (secondStep == null)
                    throw new ApplicationException("Second Step nao encontrado");

                StepBO.SetCurrent(secondStep);
            }
            else if (currentStep.Fork > 0)
            {
                var stepData = currentStep.Data.Value;
                var forkStep = GetForkStep(currentStep);
                if (forkStep == null)
                    throw new ApplicationException("Fork Step nao encontrado");

                StepBO.SetCurrent(forkStep);
            }
            else if (!string.IsNullOrEmpty(currentStep.Special) &&
                     currentStep.Special != "N/A" && 
                     result.Message.Contains("JUMP="))
            {
                var jumpStep  = GetJumpStep(currentStep, result.Message);
                if (jumpStep == null)
                    throw new ApplicationException("Jump Step nao encontrado");

                StepBO.SetCurrent(jumpStep);
            }

            if (result.Result == Result.Pass)
            {
                if (currentStep.Last)
                {
                    SessionBO.GetInstance().ClearUntilLastInput();
                }
                else if (currentStep.Rule == Rule.KeepInMemory || 
                         currentStep.Rule == Rule.UntilLastInput)
                {
                    SessionBO.GetInstance().AddVariable(new SessionTO
                    {
                        Name  = currentStep.Data.Name,
                        Value = currentStep.Data.Value,
                        Rule  = currentStep.Rule
                    });
                }
            }
            return new ResultTO
            {
                Result  = Result.Pass,
                Message = StepBO.GetCurrent().Data.Prompt
            };
        }

        private StepTO GetSecondStep(StepTO current)
        {
            return GetCurrent().Steps.Where(i => i.Number == current.Second).FirstOrDefault();
        }

        private StepTO GetForkStep(StepTO current)
        {
            return GetCurrent().Steps.Where(i => i.Number == current.Fork).FirstOrDefault();
        }

        private StepTO GetJumpStep(StepTO current, string result)
        {
            StepTO stepTO = null;
            var special = current.Special.Replace("{", string.Empty).Replace("}", string.Empty);
            //{S0}=5,{S1}=1
            var splitValue = special.Split(',');
            foreach (var item in splitValue)
            {
                var splitItem = item.Split('=');
                if (result.Contains(splitItem[0]))
                {
                    stepTO = GetCurrent().Steps.Where(i => i.Number == splitItem[1].ToInteger()).FirstOrDefault();
                    break;
                }
            }
            return stepTO;
        }

        public bool IsLoad()
        {
            return (GetCurrent() != null);
        }
    }
}

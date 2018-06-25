using AutoMapper;
using CMCVirtual.BO.Contracts;
using CMCVirtual.Core.Enumerations;
using CMCVirtual.Core.TO;
using CMCVirtual.DAO.Contracts;
using CMCVirtual.Extensions;
using CMCVirtual.IoC;
using System.Collections.Generic;
using System.Linq;


namespace CMCVirtual.BO
{
    public class StepBO : BaseBO<StepTO, IStepDAO>, IStepBO
    {
        public IProcedureDAO ProcedureDAO { get; set; }

        public ICollection<StepTO> ListByStation(int stationType, long stationNumber)
        {
            var domain  = DefaultDAO.ListByStation(stationNumber);
            var retList = Mapper.Map<ICollection<StepTO>>(domain);

            foreach (var step in retList)
            {
                var procedures = ProcedureDAO.ListByStep(stationType, step.Number);
                step.Procedures = Mapper.Map<ICollection<ProcedureTO>>(procedures);
            }
            return retList;
        }

        public StepTO Get(int stationType, int stepNumber)
        {
            var domain        = DefaultDAO.Get(stepNumber);
            var stepTO        = Mapper.Map<StepTO>(domain);
            stepTO.Procedures = Mapper.Map<ICollection<ProcedureTO>>(ProcedureDAO.ListByStep(stationType, stepTO.Number));
            return stepTO;
        }

        public ResultTO Execute(string data)
        {
            ResultTO RetValue = new ResultTO();
            var      step     = this.GetCurrent();            
            step.Data.Value   = data;

            foreach (var procedure in step.Procedures.OrderBy(i => i.Index))
            {
                procedure.Parameters = FetchParameters(procedure.Parameters);
                RetValue             = ProcedureDAO.Execute(procedure);
                if (RetValue.Result == Result.Fail)
                    break;
            }
            return RetValue;
        }

        private ICollection<ProcedureParameterTO> FetchParameters(ICollection<ProcedureParameterTO> parameters)
        {
            foreach (var item in parameters)
            {
                if (item.Direction == ProcedureParameterDirection.In)
                {
                    var sessionTO = SessionBO.GetInstance().GetVariable(item.Name);
                    if (sessionTO != null)
                    {
                        item.Value = sessionTO.Value;
                    }
                    else if (item.Name.Equals("DATA"))
                    {
                        item.Value = GetCurrent().Data.Value;
                    }
                }
            }
            return parameters;
        }
    }
}
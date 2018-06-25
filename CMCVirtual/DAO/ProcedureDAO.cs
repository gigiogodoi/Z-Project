using CMCVirtual.Core.TO;
using CMCVirtual.DAO.Contracts;
using CMCVirtual.Extensions;
using System.Collections.Generic;

namespace CMCVirtual.DAO
{
    internal class ProcedureDAO : BaseDAO, IProcedureDAO
    {
        public ICollection<Domain.Procedure> ListByStep(int stationType, int stepNumber)
        {
            var retList = new List<Domain.Procedure>();
            var queryString = string.Format(
                              "SELECT STOREDPROC                 "
                            + "     , STOREDPROC_INDEX           "
                            + "  FROM {0}.C_WORK_TYPE_STOREDPROC "
                            + " WHERE 0 = 0                      "
                            + "   AND STATION_TYPE = {1}         " 
                            + "   AND WORK_TYPE    = {2}         " 
                            + " ORDER BY STOREDPROC_INDEX        "
                            , SchemaDB, stationType, stepNumber)
                            ;
            
            foreach (var row in DbCommandSelect(queryString).Select())
            {
                var procedure = new Domain.Procedure
                {
                    Name       = row["STOREDPROC"].ToString(),
                    Index      = row["STOREDPROC_INDEX"].ToInteger(),
                    Parameters = new List<Domain.ProcedureParameter>()
                };
                queryString = string.Format(
                              "   SELECT B.ARGUMENT_NAME                                   "
                            + "         , B.POSITION                                       "
                            + "         , B.DATA_TYPE                                      "
                            + "         , B.IN_OUT                                         "
                            + "      FROM ALL_OBJECTS A                                    "
                            + "INNER JOIN ALL_ARGUMENTS B ON A.OBJECT_NAME = B.OBJECT_NAME "
                            + "     WHERE 0 = 0                                            "
                            + "       AND A.OWNER       = '{0}'                         "
                            + "       AND A.OBJECT_TYPE = 'PROCEDURE'                      "
                            + "       AND A.OBJECT_NAME = '{1}'                            "
                            + "  ORDER BY B.POSITION                                       "
                            , SchemaDB, procedure.Name)
                            ;
                foreach (var param in DbCommandSelect(queryString).Select())
                {
                    procedure.Parameters.Add(new Domain.ProcedureParameter
                    {
                        Name      = param["ARGUMENT_NAME"].ToString(),
                        Position  = param["POSITION"     ].ToInteger(),
                        Type      = param["DATA_TYPE"    ].ToString(),
                        Direction = param["IN_OUT"       ].ToString()
                    });
                }
                retList.Add(procedure);
            }
            return retList;
        }

        public ResultTO Execute(ProcedureTO procedure)
        {
            return base.DbCommandProcedure(procedure);
        }
    }
}

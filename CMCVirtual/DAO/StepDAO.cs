using CMCVirtual.DAO.Contracts;
using CMCVirtual.Extensions;
using System.Collections.Generic;
using System.Data;

namespace CMCVirtual.DAO
{
    internal class StepDAO : BaseDAO, IStepDAO
    {
        public ICollection<Domain.Step> ListByStation(long stationNumber)
        {
            var retList     = new List<Domain.Step>();
            var queryString = string.Format(
                              "    SELECT B.WORK_TYPE                                          "
                            + "         , C.WORK_TYPE_NAME                                     "
                            + "         , B.WORK_TYPE_INDEX                                    "
                            + "         , B.SECOND                                             "
                            + "         , B.FORK                                               "
                            + "         , B.RULE                                               "
                            + "         , B.LAST                                               "
                            + "         , B.SPECIAL                                            "
                            + "         , C.PARAM                                              "
                            + "         , C.CODE_BIG5                                          "
                            + "      FROM {0}.C_STATION_TYPE A                                 "
                            + "INNER JOIN {0}.C_WORK_TYPE B ON A.STATION_TYPE = B.STATION_TYPE "
                            + "INNER JOIN {0}.C_WORK_TYPE_NAME C ON B.WORK_TYPE = C.WORK_TYPE  "
                            + "     WHERE 0 = 0                                                "
                            + "       AND A.STATION_NUMBER = {1}                               "
                            + "  ORDER BY B.WORK_TYPE_INDEX                                    "
                            , SchemaDB, stationNumber)
                            ;
            
            foreach (var row in DbCommandSelect(queryString).Select())
            {
                retList.Add(CreateStepFromRow(row));
            }
            return retList;
        }

        public Domain.Step Get(int stepNumber)
        {
            Domain.Step retStep = null;
            var queryString = string.Format(
                              "    SELECT B.WORK_TYPE                                          "
                            + "         , C.WORK_TYPE_NAME                                     "
                            + "         , B.WORK_TYPE_INDEX                                    "
                            + "         , B.SECOND                                             "
                            + "         , B.FORK                                               "
                            + "         , B.RULE                                               "
                            + "         , B.LAST                                               "
                            + "         , B.SPECIAL                                            "
                            + "         , C.PARAM                                              "
                            + "         , C.CODE_BIG5                                          "
                            + "      FROM {0}.C_STATION_TYPE A                                 "
                            + "INNER JOIN {0}.C_WORK_TYPE B ON A.STATION_TYPE = B.STATION_TYPE "
                            + "INNER JOIN {0}.C_WORK_TYPE_NAME C ON B.WORK_TYPE = C.WORK_TYPE  "
                            + "     WHERE 0 = 0                                                "
                            + "       AND B.WORK_TYPE = {1}                                    " 
                            + "  ORDER BY B.WORK_TYPE_INDEX                                    "
                            , SchemaDB, stepNumber)
                            ;
            
            foreach (var row in DbCommandSelect(queryString).Select())
            {
                retStep = CreateStepFromRow(row);
            }
            return retStep;
        }

        private Domain.Step CreateStepFromRow(DataRow row)
        {
            return new Domain.Step
            {
                Number   = row["WORK_TYPE"      ].ToInteger(),
                Name     = row["WORK_TYPE_NAME" ].ToString(),
                Index    = row["WORK_TYPE_INDEX"].ToInteger(),
                Second   = row["SECOND"         ].ToInteger(),
                Fork     = row["FORK"           ].ToInteger(),
                Rule     = row["RULE"           ].ToInteger(),
                Last     = row["LAST"           ].ToBoolean(),
                Special  = row["SPECIAL"        ].ToString(),
                Param    = row["PARAM"          ].ToString(),
                CodeBig5 = row["CODE_BIG5"      ].ToString()
            };
        }
    }
}

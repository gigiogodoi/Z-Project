using CMCVirtual.BO.Contracts;
using CMCVirtual.DAO.Contracts;
using CMCVirtual.IoC;

namespace CMCVirtual.BO
{
    public abstract class BaseBO<TDAO> where TDAO : IDAO
    {
        public TDAO DefaultDAO { get; set; }

        public BaseBO() {}
    }

    public abstract class BaseBO<TTO, TDAO> : BaseBO<TDAO>, IBaseBO<TTO>
        where TTO  : class
        where TDAO : IDAO
    {
        protected TTO CurrentTO;

        public TTO GetCurrent()
        {
            return CurrentTO;
        }

        public void SetCurrent(TTO to)
        {
            CurrentTO = to;
        }
    }
}

namespace CMCVirtual.BO.Contracts
{
    public interface IBaseBO<TTO>
    {
        TTO GetCurrent();

        void SetCurrent(TTO to);
    }
}
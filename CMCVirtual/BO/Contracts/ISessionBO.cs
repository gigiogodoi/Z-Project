using CMCVirtual.Core.TO;

namespace CMCVirtual.BO.Contracts
{
    internal interface ISessionBO
    {
        void AddVariable(SessionTO variable);

        SessionTO GetVariable(string name);

        void ClearUntilLastInput();

        void ClearAllVariables();
    }
}

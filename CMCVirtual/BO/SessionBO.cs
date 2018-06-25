using CMCVirtual.BO.Contracts;
using CMCVirtual.Core.Enumerations;
using CMCVirtual.Core.TO;
using System.Collections.Generic;
using System.Linq;

namespace CMCVirtual.BO
{
    public class SessionBO : ISessionBO
    {
        private static SessionBO Instance = null;
        private List<SessionTO> Session = null;

        public static SessionBO GetInstance()
        {
            if (Instance == null)
                Instance = new SessionBO();

            return Instance;
        }

        private SessionBO()
        {
            this.Session = new List<SessionTO>();
        }

        public void AddVariable(SessionTO variable)
        {
            this.Session.Add(variable);
        }

        public SessionTO GetVariable(string name)
        {
            return Session.FirstOrDefault(i => i.Name == name);
        }

        public void ClearUntilLastInput()
        {
            Session.RemoveAll(i => i.Rule == Rule.UntilLastInput);
        }

        public void ClearAllVariables()
        {
            Session.Clear();
        }
    }
}

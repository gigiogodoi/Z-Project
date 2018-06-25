using CMCVirtual.Core.TO;
using System.Collections.Generic;

namespace CMCVirtual.Core.Contracts
{
    public interface IController
    {
        ControllerResultTO<LoginTO> AutoLogin();
        ControllerResultTO<LoginTO> ChangeStation(long stationNumber, bool autoLogin = false);
        ControllerResultTO ExecuteFlow(string data);
        ControllerResultTO ResetFlow();
        ControllerResultTO<ICollection<HostTO>> GetHostList();
        ControllerResultTO<ICollection<StationTO>> GetStationList(int hostNumber);
        bool ValidateUserPassword(string login, string password);
    }
}
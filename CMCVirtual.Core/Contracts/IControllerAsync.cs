using CMCVirtual.Core.TO;
using System.Collections.Generic;
using System.ComponentModel;

namespace CMCVirtual.Core.Contracts
{
    public delegate void ControllerExecuteComplete(ControllerResultTO resultTO);

    public interface IControllerAsync : IController
    {
        void SetCallback(ControllerExecuteComplete callback);
        void AutoLoginAsync();
        void ChangeStationAsync(long stationNumber, bool autoLogin = false);
        void ExecuteFlowAsync(string data);
        void ResetFlowAsync();
        void GetHostListAsync();
        void GetStationListAsync(int hostNumber);
    }
}
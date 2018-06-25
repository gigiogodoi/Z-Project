using CMCVirtual.Core.Contracts;
using CMCVirtual.Core.TO;
using System.ComponentModel;
using System.Threading;
using System.Web.UI;

namespace CMCVirtual.Controller
{
    public class CMCControllerAsync : CMCController, IControllerAsync
    {
        private ControllerExecuteComplete Callback = null;

        public CMCControllerAsync() : base()
        {

        }

        public void AutoLoginAsync()
        {
            Thread thrd = new Thread(() =>
            {
                InvokeCallback(base.AutoLogin());
            });
            thrd.Start();
        }

        public void ChangeStationAsync(long stationNumber, bool autoLogin=false)
        {
            Thread thrd = new Thread(() => 
            {
                InvokeCallback(base.ChangeStation(stationNumber, autoLogin));
            });
            thrd.Start();
        }

        public void ExecuteFlowAsync(string data)
        {
            Thread thrd = new Thread(() => 
            {
                InvokeCallback(base.ExecuteFlow(data));
            });
            thrd.Start();
        }

        public void ResetFlowAsync()
        {
            Thread thrd = new Thread(() =>
            {
                InvokeCallback(base.ResetFlow());
            });
            thrd.Start();
        }

        public void GetHostListAsync()
        {
            Thread thrd = new Thread(() =>
            {
                InvokeCallback(base.GetHostList());
            });
            thrd.Start();
        }

        public void GetStationListAsync(int hostNumber)
        {
            Thread thrd = new Thread(() =>
            {
                InvokeCallback(base.GetStationList(hostNumber));
            });
            thrd.Start();
        }

        public void SetCallback(ControllerExecuteComplete callback)
        {
            this.Callback = callback;
        }

        private void InvokeCallback(ControllerResultTO resultTO)
        {
            if (Callback != null)
                Callback.Invoke(resultTO);
        }
    }
}
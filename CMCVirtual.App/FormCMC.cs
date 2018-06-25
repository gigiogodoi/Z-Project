using CMCVirtual.Controller;
using CMCVirtual.Core.Contracts;
using CMCVirtual.IoC;
using System.Windows.Forms;
using System.Linq;
using CMCVirtual.Core.Enumerations;
using CMCVirtual.Core.TO;
using System;

namespace CMCVirtual.App
{
    public partial class FormCMC : Form
    {
        private const string CST_STATION = @"%STATION";
        private const string CST_UNDO    = @".UNDO";
        private const string CST_VERSION = @".VERSION";
        private IFormWait FormWait       = new FormWait();
        private Exception LastException  = null;        

        IControllerAsync CMCController = CastleWindsorInjector.Resolve<IControllerAsync>();

        public FormCMC()
        {
            InitializeComponent();
            CMCController.SetCallback(OnControllerExecuteComplete);
        }

        private void FormCMC_Shown(object sender, System.EventArgs e)
        {
            ExecuteAutoLogin();
            TXTInputData.Clear();
            TXTInputData.Focus();
        }

        private void TXTInputData_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(TXTInputData.Text) && e.KeyCode == Keys.Enter)
            {
                BTNScan_Click(BTNScan, null);
            }
        }

        private void BTNScan_Click(object sender, System.EventArgs e)
        {
            switch (CheckBarcode(TXTInputData.Text))
            {
                case ScanType.StationCommand : StationCommandScanned(); break;
                case ScanType.UndoCommand    : UndoCommandScanned();    break;
                case ScanType.VersionCommand : VersionCommandScanned(); break;
                case ScanType.InputData      : InputDataScanned();      break;
            }
            TXTInputData.Clear();
            TXTInputData.Focus();
        }

        private void ExecuteAutoLogin()
        {
            FormWait.ShowWait(this, "Carregando Estação");
            CMCController.AutoLoginAsync();
            //var loginTO = CMCController.AutoLogin();
            //ShowResult(loginTO);
        }

        private ScanType CheckBarcode(string barcode)
        {
            barcode = barcode.Trim().ToUpper();

                 if (barcode.Equals(CST_STATION)) return ScanType.StationCommand;
            else if (barcode.Equals(CST_UNDO))    return ScanType.UndoCommand;
            else if (barcode.Equals(CST_VERSION))    return ScanType.VersionCommand;
            else                                  return ScanType.InputData;
        }

        private void StationCommandScanned()
        {
            
            var formStation = new FormSetStation();
            if (formStation.ShowDialog(this) == DialogResult.OK)
            {
                FormWait.ShowWait(this, "Carregando Estação");
                CMCController.ChangeStationAsync(formStation.GetStation().Number);
            }
            else
            {
                this.Visible = true;
            }
        }

        private void UndoCommandScanned()
        {
            var resultTO = CMCController.ResetFlow();
            ShowResult(resultTO);
        }

        private void VersionCommandScanned()
        {
            var formVersion = new FormVersion();
            formVersion.ShowDialog(this);
        }

        private void InputDataScanned()
        {
            var resultTO = CMCController.ExecuteFlow(TXTInputData.Text);
            ShowResult(resultTO);
        }

        private void ShowResult(ControllerResultTO resultTO, bool showInput = true)
        {
            TXTUpperScreen.Clear();
            TXTLowerScreen.Clear();

            if (resultTO != null)
            {
                if (resultTO.Exception != null)
                {
                    LastException        = resultTO.Exception;
                    BTNException.Visible = true;
                }
                if (resultTO.Result == Result.Fail)
                {
                    TXTUpperScreen.Text = resultTO.ExecuteMessage;
                }
                else
                {
                    TXTUpperScreen.Text = showInput ? TXTInputData.Text : "OK";
                }
                if (resultTO is ControllerResultTO<LoginTO>)
                {
                    var loginTO = (ControllerResultTO<LoginTO>)resultTO;
                    if (loginTO.Result == Result.Pass)
                    {
                        LBLTitle.Text = loginTO.TO.StationName;
                    }
                    else
                    {
                        LBLTitle.Text = string.Empty;
                    }
                }
                TXTLowerScreen.Text = resultTO.PromptMessage;
            }
        }

        private void BTNException_Click(object sender, EventArgs e)
        {
            if (LastException != null)
            {
                var formException    = new FormException(LastException);
                formException.ShowDialog(this);
                BTNException.Visible = false;
                LastException        = null;
            }
        }

        public void OnControllerExecuteComplete(ControllerResultTO resultTO)
        {
            if (InvokeRequired)
            {
                ControllerExecuteComplete method = new ControllerExecuteComplete(OnControllerExecuteComplete);
                this.Invoke(method, new object[] { resultTO });
            }
            else
            {
                FormWait.HideWait();
                ShowResult(resultTO);
            }            
        }
    }
}
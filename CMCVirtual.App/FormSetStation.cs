using CMCVirtual.Core.Contracts;
using CMCVirtual.IoC;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using CMCVirtual.Core.TO;
using CMCVirtual.Core.Enumerations;

namespace CMCVirtual.App
{
    public partial class FormSetStation : Form
    {
        private IControllerAsync CMCController   = CastleWindsorInjector.Resolve<IControllerAsync>();
        private StationTO   SelectedStation = null;
        private Exception   LastException   = null;

        public FormSetStation()
        {
            InitializeComponent();

            SetupFormEvents();

            LoadHostComboList();
        }

        private void FormSetStation_Shown(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void SetupFormEvents()
        {
            this.Shown += (sender, e) =>
            {
                CMBHost.Focus();
            };

            CMBHost.SelectedIndexChanged += (sender, e) =>
            {
                CMBStation.Focus();
            };

            CMBStation.SelectedIndexChanged += (sender, e) =>
            {
                TXTLogin.Focus();
            };

            TXTLogin.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    TXTPassword.Focus();
            };

            TXTPassword.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    BTNConfirm.PerformClick();
            };
        }

        private void LoadHostComboList()
        {
            var resultTO = CMCController.GetHostList();
            BTNException.Visible = false;

            if (resultTO.Result == Result.Pass)
            {
                CMBHost.DataSource    = resultTO.TO.Select(s => new KeyValuePair<string, int>(s.Name, s.Number)).ToList();
                CMBHost.DisplayMember = "Key";
                CMBHost.ValueMember   = "Value";
            }
            else
            {
                LastException        = resultTO.Exception;
                BTNException.Visible = true;
            }
        }

        private void LoadStationComboList(int HostId)
        {
            var resultTO = CMCController.GetStationList(HostId);
            BTNException.Visible = false;

            if (resultTO.Result == Result.Pass)
            {
                CMBStation.DataSource    = resultTO.TO.Select(s => new KeyValuePair<string, long>(s.Name, s.Number)).ToList();
                CMBStation.DisplayMember = "Key";
                CMBStation.ValueMember   = "Value";
            }
            else
            {
                LastException        = resultTO.Exception;
                BTNException.Visible = true;
            }
        }

        private void CMBHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            var keyValuePair = (KeyValuePair<string, int>)CMBHost.SelectedItem;
            LoadStationComboList(keyValuePair.Value);
        }

        private void CMBStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var keyValuePair = (KeyValuePair<string, long>)CMBStation.SelectedItem;
            SelectedStation  = new StationTO
            {
                Name   = keyValuePair.Key,
                Number = keyValuePair.Value
            };
        }

        private bool IsValidForm()
        {
            return CMBHost.SelectedIndex >= 0 &&
                   CMBStation.SelectedIndex >= 0 &&
                   !string.IsNullOrEmpty(TXTLogin.Text) &&
                   !string.IsNullOrEmpty(TXTPassword.Text);

        }

        private void BTNConfirm_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                // Validate Login and Password
                if (!CMCController.ValidateUserPassword(TXTLogin.Text, TXTPassword.Text))
                {
                    MessageBox.Show("Usuario e/ou Senha invalido(s)");
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                this.DialogResult = DialogResult.None;
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

        public StationTO GetStation()
        {
            return SelectedStation;
        }
    }
}

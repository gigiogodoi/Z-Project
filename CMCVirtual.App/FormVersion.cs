using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMCVirtual.App
{
    public partial class FormVersion : Form
    {
        public FormVersion()
        {
            InitializeComponent();

            LoadVersionList();
        }

        private void LoadVersionList()
        {
            var assemblies = AppDomain.CurrentDomain
                                      .GetAssemblies()
                                      .Where(i => !i.IsDynamic)
                                      .OrderBy(i => i.FullName)
                                      .ToList();

            foreach (var item in assemblies)
            {
                if (item.Location.Contains(AppDomain.CurrentDomain.BaseDirectory))
                {
                    LSTVersions.Items.Add(item.FullName);
                }                
            }
        }

        private void FormVersion_Shown(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}

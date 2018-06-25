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
    public interface IFormWait
    {
        void ShowWait(IWin32Window owner, string message);
        void HideWait();
    }

    public partial class FormWait : Form, IFormWait
    {
        private Timer TimerLongWait = null;
        private int   LastDicIndex  = 1;
        private Dictionary<int, string> DicMessages = new Dictionary<int, string>()
        {
            { 1 , "Estamos quase terminando" },
            { 2 , "Só mais um pouquinho"     }
        };

        public FormWait()
        {
            InitializeComponent();
            TimerLongWait          = new Timer();
            TimerLongWait.Interval = 5000;
            TimerLongWait.Tick    += TimerLongWait_Tick;
        }

        public void ShowWait(IWin32Window owner, string message)
        {
            (owner as Form).Visible  = false;
            this.LBLMessage.Text = message;
            this.Show(owner);
        }

        public void HideWait()
        {
            (this.Owner as Form).Visible = true;
            this.Hide();
        }

        private void FormWait_Shown(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void TimerLongWait_Tick(object sender, EventArgs e)
        {
            this.LBLMessage.Text = DicMessages[LastDicIndex==1 ? LastDicIndex++ : LastDicIndex--];
        }

        private void FormWait_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                TimerLongWait.Start();
            else
                TimerLongWait.Stop();
        }
    }
}

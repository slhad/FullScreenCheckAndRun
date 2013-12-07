using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FSCR.Libs;

namespace FSCR
{
    public partial class Main : Form
    {
        Checker checker = null;
        StringBuilder sb = new StringBuilder();

        public Main()
        {
            InitializeComponent();
        }

        private void bIsEnabled_Click(object sender, EventArgs e)
        {
            timerCheck.Enabled = !timerCheck.Enabled;
            bIsEnabled.Text = timerCheck.Enabled ? "On" : "Off";
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            if (checker == null)
            {
                checker = new Checker();
            }

            if (checker.check())
            {
                sb.Append("\nFullscreen");
            }
            else
            {
                sb.Append("\nWindowed");
            }

            tbLog.Text = sb.ToString();
        }
    }
}

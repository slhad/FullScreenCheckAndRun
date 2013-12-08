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
        BFGMiner bfgm = null;
        StringBuilder sb = new StringBuilder();
        bool oldState = true;
        bool firstRun = true;

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

            bool newState = checker.check();

            if (newState != oldState)
            {
                if (sb.ToString() != "")
                {
                    sb.Append(Environment.NewLine);
                }

                sb.Append(DateTime.Now);


                if (newState)
                {
                    sb.Append(" : Fullscreen");
                }
                else
                {
                    sb.Append(" : Windowed");
                }

                oldState = newState;



                if (bfgm == null)
                {
                    bfgm = new BFGMiner("127.0.0.1", 4028);
                }

                if (firstRun)
                {
                    firstRun = false;
                }
                else
                {
                    bfgm.getGPUs();
                }

                tbLog.Text = sb.ToString();
            }
        }
    }
}

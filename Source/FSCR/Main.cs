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
        FullscreenChecker checker = null;
        BFGMiner bfgm = null;
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
                checker = new FullscreenChecker();
            }

            bool newState = checker.check();

            if (newState != oldState)
            {
                if (tbLog.Text.Length > 0)
                {
                    tbLog.AppendText(Environment.NewLine);
                }

                tbLog.AppendText(DateTime.Now + "");


                if (newState)
                {
                    tbLog.AppendText(" : Fullscreen");
                }
                else
                {
                    tbLog.AppendText(" : Windowed");
                }

                oldState = newState;

                if (bfgm == null)
                {
                    Int32 pPort = 4028;
                    try
                    {
                        pPort = Convert.ToInt32(nUDPort.Value);
                    }
                    catch (System.OverflowException eof)
                    {
                        if (eof != null) { }
                    }
                    bfgm = new BFGMiner(tbServer.Text, pPort);
                }

                if (firstRun)
                {
                    firstRun = false;
                }
                else
                {
                    if (cbRun.Checked)
                    {
                        bfgm.setStatusGPUs(!newState);
                    }
                }
            }
        }
    }
}

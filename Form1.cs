using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgressBarControllerDemo
{
    public partial class Form1 : Form
    {
        ProgressBarController pbc1;
        ProgressBarController pbc2;
        ProgressBarController pbc3;

        ProgressBarController[] pbcs;

        public Form1()
        {
            InitializeComponent();
            pbc1 = ProgressBarController.CreateProgressBarController(progressBar1);
            pbc2 = ProgressBarController.CreateProgressBarController(progressBar2);
            pbc3 = ProgressBarController.CreateProgressBarController(progressBar3);
            pbcs = new ProgressBarController[] { pbc1, pbc2, pbc3 };
            optStateError.Tag = ProgressBarState.Error;
            optStateNormal.Tag = ProgressBarState.Normal;
            optStatePaused.Tag = ProgressBarState.Paused;
        }

        private void optState_Changed(object sender, EventArgs e)
        {
            RadioButton s = (RadioButton)sender;
            if (s.Checked)
            {
                foreach (ProgressBarController pbc in pbcs)
                {
                    if (pbc.CanSetState)
                    {
                        pbc.State = (ProgressBarState)s.Tag;
                    }
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetState_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ProgressBarController pbc in pbcs)
            {
                sb.Append(pbc.State.ToString()).AppendLine();
            }
            MessageBox.Show(this, sb.ToString(), "Progress bar states", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreventWindowsLock
{
    // Icon license: https://creativecommons.org/licenses/by-sa/3.0/

    public partial class MainForm : Form
    {
        private Timer timer;

        public MainForm()
        {
            InitializeComponent();

            // Initialize timer
            this.timer = new Timer();
            this.timer.Tick += Timer_Tick;

            // Load settings
            this.numericUpDownInterval.Value = Properties.Settings.Default.interval;
            this.checkBoxPreventLock.Checked = Properties.Settings.Default.preventLock;
            this.checkBoxSimulateInput.Checked = Properties.Settings.Default.simulateInput;

            this.setEnablement();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Double click NumLock keybord button
            PreventLock.ClickKeyboardNumLock(); // 1
            PreventLock.ClickKeyboardNumLock(); // 2
        }

        private void buttonPreventLock_Click(object sender, EventArgs e)
        {
            PreventLock.Preventing = !PreventLock.Preventing;
            if (PreventLock.Preventing)
            {
                this.buttonPreventLock.Text = "Stop Preventing Lock";
                if (this.checkBoxSimulateInput.Checked)
                {
                    this.timer.Interval = (int)this.numericUpDownInterval.Value * 60 * 1000;
                    this.timer.Enabled = true;
                    this.numericUpDownInterval.Enabled = false;
                }
            }
            else
            {
                this.timer.Enabled = false;
                this.buttonPreventLock.Text = "Prevent Lock";
                this.setEnablement();
                this.numericUpDownInterval.Enabled = true;
            }
        }

        private void checkBoxPreventLock_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.preventLock = this.checkBoxPreventLock.Checked;
            this.setEnablement();
        }

        private void checkBoxSimulateInput_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.simulateInput = this.checkBoxSimulateInput.Checked;
            if (PreventLock.Preventing)
            {
                this.timer.Interval = (int)this.numericUpDownInterval.Value * 60 * 1000;
                this.timer.Enabled = true;
            }
            this.setEnablement();
        }

        private void setEnablement()
        {
            bool enable = PreventLock.Preventing || this.checkBoxPreventLock.Checked || this.checkBoxSimulateInput.Checked;
            this.buttonPreventLock.Enabled = enable;

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save settings when form closes
            Properties.Settings.Default.Save();
        }

        private void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.interval = (int) this.numericUpDownInterval.Value;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.notifyIcon.Visible = true;
                this.notifyIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                this.notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}

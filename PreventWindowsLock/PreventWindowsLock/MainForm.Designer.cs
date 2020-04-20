namespace PreventWindowsLock
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPreventLock = new System.Windows.Forms.Button();
            this.checkBoxSimulateInput = new System.Windows.Forms.CheckBox();
            this.checkBoxPreventLock = new System.Windows.Forms.CheckBox();
            this.labelPreventLock = new System.Windows.Forms.Label();
            this.labelSimulateInput = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.labelInterval = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPreventLock
            // 
            this.buttonPreventLock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPreventLock.Enabled = false;
            this.buttonPreventLock.Location = new System.Drawing.Point(0, 227);
            this.buttonPreventLock.Name = "buttonPreventLock";
            this.buttonPreventLock.Size = new System.Drawing.Size(622, 52);
            this.buttonPreventLock.TabIndex = 0;
            this.buttonPreventLock.Text = "Prevent Lock";
            this.buttonPreventLock.UseVisualStyleBackColor = true;
            this.buttonPreventLock.Click += new System.EventHandler(this.buttonPreventLock_Click);
            // 
            // checkBoxSimulateInput
            // 
            this.checkBoxSimulateInput.AutoSize = true;
            this.checkBoxSimulateInput.Location = new System.Drawing.Point(12, 143);
            this.checkBoxSimulateInput.Name = "checkBoxSimulateInput";
            this.checkBoxSimulateInput.Size = new System.Drawing.Size(231, 29);
            this.checkBoxSimulateInput.TabIndex = 1;
            this.checkBoxSimulateInput.Text = "Simulate User Input";
            this.checkBoxSimulateInput.UseVisualStyleBackColor = true;
            this.checkBoxSimulateInput.CheckedChanged += new System.EventHandler(this.checkBoxSimulateInput_CheckedChanged);
            // 
            // checkBoxPreventLock
            // 
            this.checkBoxPreventLock.AutoSize = true;
            this.checkBoxPreventLock.Location = new System.Drawing.Point(12, 47);
            this.checkBoxPreventLock.Name = "checkBoxPreventLock";
            this.checkBoxPreventLock.Size = new System.Drawing.Size(244, 29);
            this.checkBoxPreventLock.TabIndex = 2;
            this.checkBoxPreventLock.Text = "Prevent Lock Screen";
            this.checkBoxPreventLock.UseVisualStyleBackColor = true;
            this.checkBoxPreventLock.CheckedChanged += new System.EventHandler(this.checkBoxPreventLock_CheckedChanged);
            // 
            // labelPreventLock
            // 
            this.labelPreventLock.AutoSize = true;
            this.labelPreventLock.Location = new System.Drawing.Point(12, 13);
            this.labelPreventLock.Name = "labelPreventLock";
            this.labelPreventLock.Size = new System.Drawing.Size(535, 25);
            this.labelPreventLock.TabIndex = 3;
            this.labelPreventLock.Text = "Prevent Windows from showing screensaver or locking";
            // 
            // labelSimulateInput
            // 
            this.labelSimulateInput.AutoSize = true;
            this.labelSimulateInput.Location = new System.Drawing.Point(12, 83);
            this.labelSimulateInput.Name = "labelSimulateInput";
            this.labelSimulateInput.Size = new System.Drawing.Size(595, 50);
            this.labelSimulateInput.TabIndex = 4;
            this.labelSimulateInput.Text = "Prevent everything by simulating user input. \r\nThe simulated user input consists " +
    "of toggling NumLock on/off";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(12, 178);
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownInterval.TabIndex = 5;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(138, 180);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(164, 25);
            this.labelInterval.TabIndex = 6;
            this.labelInterval.Text = "Minutes interval";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Prevent Windows Lock still running in the background";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Prevent Windows Lock";
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 279);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.labelSimulateInput);
            this.Controls.Add(this.labelPreventLock);
            this.Controls.Add(this.checkBoxPreventLock);
            this.Controls.Add(this.checkBoxSimulateInput);
            this.Controls.Add(this.buttonPreventLock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Prevent Windows Lock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreventLock;
        private System.Windows.Forms.CheckBox checkBoxSimulateInput;
        private System.Windows.Forms.CheckBox checkBoxPreventLock;
        private System.Windows.Forms.Label labelPreventLock;
        private System.Windows.Forms.Label labelSimulateInput;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}


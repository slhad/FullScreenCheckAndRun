namespace FSCR
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.bIsEnabled = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.cbRun = new System.Windows.Forms.CheckBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.nUDPort = new System.Windows.Forms.NumericUpDown();
            this.lPort = new System.Windows.Forms.Label();
            this.lServer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCheck
            // 
            this.timerCheck.Interval = 1000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // bIsEnabled
            // 
            this.bIsEnabled.Location = new System.Drawing.Point(12, 12);
            this.bIsEnabled.Name = "bIsEnabled";
            this.bIsEnabled.Size = new System.Drawing.Size(75, 23);
            this.bIsEnabled.TabIndex = 0;
            this.bIsEnabled.Text = "Off";
            this.bIsEnabled.UseVisualStyleBackColor = true;
            this.bIsEnabled.Click += new System.EventHandler(this.bIsEnabled_Click);
            // 
            // tbLog
            // 
            this.tbLog.AcceptsReturn = true;
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.BackColor = System.Drawing.SystemColors.Window;
            this.tbLog.Location = new System.Drawing.Point(12, 41);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(610, 217);
            this.tbLog.TabIndex = 1;
            // 
            // cbRun
            // 
            this.cbRun.AutoSize = true;
            this.cbRun.Checked = true;
            this.cbRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRun.Location = new System.Drawing.Point(93, 16);
            this.cbRun.Name = "cbRun";
            this.cbRun.Size = new System.Drawing.Size(68, 17);
            this.cbRun.TabIndex = 2;
            this.cbRun.Text = "Executor";
            this.cbRun.UseVisualStyleBackColor = true;
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(371, 11);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(145, 20);
            this.tbServer.TabIndex = 3;
            this.tbServer.Text = "127.0.0.1";
            // 
            // nUDPort
            // 
            this.nUDPort.Location = new System.Drawing.Point(554, 11);
            this.nUDPort.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nUDPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDPort.Name = "nUDPort";
            this.nUDPort.Size = new System.Drawing.Size(68, 20);
            this.nUDPort.TabIndex = 4;
            this.nUDPort.Value = new decimal(new int[] {
            4028,
            0,
            0,
            0});
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(522, 13);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 5;
            this.lPort.Text = "Port";
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(327, 14);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(38, 13);
            this.lServer.TabIndex = 6;
            this.lServer.Text = "Server";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 270);
            this.Controls.Add(this.lServer);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.nUDPort);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.cbRun);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.bIsEnabled);
            this.Name = "Main";
            this.Text = "Full Screen Check and Run";
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.Button bIsEnabled;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.CheckBox cbRun;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.NumericUpDown nUDPort;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.Label lServer;
    }
}


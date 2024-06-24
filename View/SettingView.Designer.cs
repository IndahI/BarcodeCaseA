namespace BarcodeCaseA.View
{
    partial class SettingView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxIP = new TextBox();
            textBoxPort = new TextBox();
            btnConnect = new Component.RDButton();
            label4 = new Label();
            btnClose = new Component.RDButton();
            btnOpen = new Component.RDButton();
            btnRefresh = new Component.RDButton();
            portBox = new ComboBox();
            btnExit = new Component.RDButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 63);
            label1.Name = "label1";
            label1.Size = new Size(154, 38);
            label1.TabIndex = 0;
            label1.Text = "SETTING";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label2.Location = new Point(82, 269);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 1;
            label2.Text = "Camera IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label3.Location = new Point(82, 323);
            label3.Name = "label3";
            label3.Size = new Size(127, 22);
            label3.TabIndex = 2;
            label3.Text = "Camera Port";
            // 
            // textBoxIP
            // 
            textBoxIP.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIP.Location = new Point(258, 271);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(263, 26);
            textBoxIP.TabIndex = 3;
            // 
            // textBoxPort
            // 
            textBoxPort.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPort.Location = new Point(258, 323);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(263, 26);
            textBoxPort.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(46, 174, 156);
            btnConnect.BackgroundColor = Color.FromArgb(46, 174, 156);
            btnConnect.BorderColor = Color.PaleVioletRed;
            btnConnect.BorderRadius = 8;
            btnConnect.BorderSize = 0;
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(107, 376);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(138, 39);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.TextColor = Color.White;
            btnConnect.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label4.Location = new Point(78, 141);
            label4.Name = "label4";
            label4.Size = new Size(108, 22);
            label4.TabIndex = 6;
            label4.Text = "Serial Port";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.BackgroundColor = Color.Red;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 8;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(395, 182);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 33);
            btnClose.TabIndex = 45;
            btnClose.Text = "CLOSE PORT";
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.FromArgb(46, 174, 156);
            btnOpen.BackgroundColor = Color.FromArgb(46, 174, 156);
            btnOpen.BorderColor = Color.PaleVioletRed;
            btnOpen.BorderRadius = 8;
            btnOpen.BorderSize = 0;
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(258, 182);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(126, 33);
            btnOpen.TabIndex = 44;
            btnOpen.Text = "OPEN PORT";
            btnOpen.TextColor = Color.White;
            btnOpen.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(34, 40, 43);
            btnRefresh.BackgroundColor = Color.FromArgb(34, 40, 43);
            btnRefresh.BorderColor = Color.PaleVioletRed;
            btnRefresh.BorderRadius = 3;
            btnRefresh.BorderSize = 0;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(424, 139);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 26);
            btnRefresh.TabIndex = 46;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextColor = Color.White;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // portBox
            // 
            portBox.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            portBox.FormattingEnabled = true;
            portBox.Location = new Point(258, 138);
            portBox.Name = "portBox";
            portBox.Size = new Size(149, 27);
            portBox.TabIndex = 47;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.BackgroundColor = Color.Red;
            btnExit.BorderColor = Color.PaleVioletRed;
            btnExit.BorderRadius = 8;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(336, 376);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(138, 39);
            btnExit.TabIndex = 48;
            btnExit.Text = "Close";
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // SettingView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 463);
            Controls.Add(btnExit);
            Controls.Add(portBox);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnOpen);
            Controls.Add(label4);
            Controls.Add(btnConnect);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxIP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingView";
            Load += SettingView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxIP;
        private TextBox textBoxPort;
        private Component.RDButton btnConnect;
        private Label label4;
        private Component.RDButton btnClose;
        private Component.RDButton btnOpen;
        private Component.RDButton btnRefresh;
        private ComboBox portBox;
        private Component.RDButton btnExit;
    }
}
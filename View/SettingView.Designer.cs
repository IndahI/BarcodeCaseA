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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 85);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Setting";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label2.Location = new Point(116, 158);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 1;
            label2.Text = "Camera IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label3.Location = new Point(116, 212);
            label3.Name = "label3";
            label3.Size = new Size(127, 22);
            label3.TabIndex = 2;
            label3.Text = "Camera Port";
            // 
            // textBoxIP
            // 
            textBoxIP.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIP.Location = new Point(292, 160);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(168, 26);
            textBoxIP.TabIndex = 3;
            // 
            // textBoxPort
            // 
            textBoxPort.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPort.Location = new Point(292, 212);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(168, 26);
            textBoxPort.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(46, 174, 156);
            btnConnect.BackgroundColor = Color.FromArgb(46, 174, 156);
            btnConnect.BorderColor = Color.PaleVioletRed;
            btnConnect.BorderRadius = 20;
            btnConnect.BorderSize = 0;
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(215, 281);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(150, 40);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.TextColor = Color.White;
            btnConnect.UseVisualStyleBackColor = false;
            // 
            // SettingView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 364);
            Controls.Add(btnConnect);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxIP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}
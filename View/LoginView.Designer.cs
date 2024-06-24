namespace BarcodeCaseA.View
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            rdPanel1 = new Component.RDPanel();
            panel2 = new Panel();
            label2 = new Label();
            btnExit = new Component.RDButton();
            btnLogin = new Component.RDButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            textBoxNik = new TextBox();
            label1 = new Label();
            hiddenPass = new PictureBox();
            textBoxPassword = new TextBox();
            rdPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hiddenPass).BeginInit();
            SuspendLayout();
            // 
            // rdPanel1
            // 
            rdPanel1.Anchor = AnchorStyles.None;
            rdPanel1.BackColor = Color.White;
            rdPanel1.BorderColor = Color.Silver;
            rdPanel1.BorderSize = 1;
            rdPanel1.Controls.Add(panel2);
            rdPanel1.Controls.Add(label2);
            rdPanel1.Controls.Add(btnExit);
            rdPanel1.Controls.Add(btnLogin);
            rdPanel1.Controls.Add(pictureBox2);
            rdPanel1.Controls.Add(pictureBox1);
            rdPanel1.Controls.Add(panel1);
            rdPanel1.Controls.Add(textBoxNik);
            rdPanel1.Controls.Add(label1);
            rdPanel1.Controls.Add(hiddenPass);
            rdPanel1.Controls.Add(textBoxPassword);
            rdPanel1.CornerRadius = 15;
            rdPanel1.Location = new Point(285, 101);
            rdPanel1.Name = "rdPanel1";
            rdPanel1.Size = new Size(648, 355);
            rdPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(194, 236);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 2);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(140, 35);
            label2.Name = "label2";
            label2.Size = new Size(396, 38);
            label2.TabIndex = 0;
            label2.Text = "Barcode Scanner Case A";
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
            btnExit.Location = new Point(362, 282);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 40);
            btnExit.TabIndex = 9;
            btnExit.Text = "EXIT";
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(46, 174, 156);
            btnLogin.BackgroundColor = Color.FromArgb(46, 174, 156);
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 8;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(207, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(113, 40);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOGIN";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(150, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(194, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 2);
            panel1.TabIndex = 2;
            // 
            // textBoxNik
            // 
            textBoxNik.Anchor = AnchorStyles.None;
            textBoxNik.BackColor = Color.White;
            textBoxNik.BorderStyle = BorderStyle.None;
            textBoxNik.Font = new Font("Helvetica", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNik.Location = new Point(194, 146);
            textBoxNik.Name = "textBoxNik";
            textBoxNik.PlaceholderText = "NIK";
            textBoxNik.Size = new Size(303, 25);
            textBoxNik.TabIndex = 1;
            textBoxNik.KeyDown += textBoxNik_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 73);
            label1.Name = "label1";
            label1.Size = new Size(420, 32);
            label1.TabIndex = 0;
            label1.Text = "Laundry System Business Unit";
            // 
            // hiddenPass
            // 
            hiddenPass.BackColor = Color.Transparent;
            hiddenPass.Image = Properties.Resources.eye;
            hiddenPass.Location = new Point(471, 204);
            hiddenPass.Name = "hiddenPass";
            hiddenPass.Size = new Size(26, 31);
            hiddenPass.SizeMode = PictureBoxSizeMode.Zoom;
            hiddenPass.TabIndex = 10;
            hiddenPass.TabStop = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Helvetica", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(194, 206);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(277, 25);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 241, 243);
            ClientSize = new Size(1256, 535);
            Controls.Add(rdPanel1);
            Name = "LoginView";
            Text = "LoginView";
            WindowState = FormWindowState.Maximized;
            FormClosed += LoginView_FormClosed;
            rdPanel1.ResumeLayout(false);
            rdPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hiddenPass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Component.RDPanel rdPanel1;
        private TextBox textBoxNik;
        private Label label1;
        private TextBox textBoxPassword;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Component.RDButton btnExit;
        private Component.RDButton btnLogin;
        private PictureBox hiddenPass;
    }
}
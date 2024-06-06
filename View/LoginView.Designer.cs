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
            btnExit = new Button();
            btnLogin = new Button();
            panel2 = new Panel();
            textBoxPassword = new TextBox();
            panel1 = new Panel();
            textBoxNik = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            rdPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // rdPanel1
            // 
            rdPanel1.Anchor = AnchorStyles.None;
            rdPanel1.BackColor = SystemColors.Control;
            rdPanel1.BorderColor = Color.Black;
            rdPanel1.BorderSize = 1;
            rdPanel1.Controls.Add(pictureBox2);
            rdPanel1.Controls.Add(pictureBox1);
            rdPanel1.Controls.Add(btnExit);
            rdPanel1.Controls.Add(btnLogin);
            rdPanel1.Controls.Add(panel2);
            rdPanel1.Controls.Add(textBoxPassword);
            rdPanel1.Controls.Add(panel1);
            rdPanel1.Controls.Add(textBoxNik);
            rdPanel1.Controls.Add(label1);
            rdPanel1.CornerRadius = 15;
            rdPanel1.Location = new Point(415, 156);
            rdPanel1.Name = "rdPanel1";
            rdPanel1.Size = new Size(432, 318);
            rdPanel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(249, 253);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(0, 173, 181);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(117, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(84, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 2);
            panel2.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.BackColor = SystemColors.Control;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Franklin Gothic Medium", 15.75F);
            textBoxPassword.Location = new Point(84, 164);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(303, 24);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(84, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 2);
            panel1.TabIndex = 2;
            // 
            // textBoxNik
            // 
            textBoxNik.Anchor = AnchorStyles.None;
            textBoxNik.BackColor = SystemColors.Control;
            textBoxNik.BorderStyle = BorderStyle.None;
            textBoxNik.Font = new Font("Franklin Gothic Medium", 15.75F);
            textBoxNik.Location = new Point(84, 104);
            textBoxNik.Name = "textBoxNik";
            textBoxNik.PlaceholderText = "NIK";
            textBoxNik.Size = new Size(303, 24);
            textBoxNik.TabIndex = 1;
            textBoxNik.KeyDown += textBoxNik_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Demi", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 33);
            label1.Name = "label1";
            label1.Size = new Size(88, 34);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1256, 77);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Demi", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(864, 22);
            label3.Name = "label3";
            label3.Size = new Size(389, 34);
            label3.TabIndex = 1;
            label3.Text = "Laundry Systems Business Unit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 9);
            label2.Name = "label2";
            label2.Size = new Size(548, 61);
            label2.TabIndex = 0;
            label2.Text = "Barcode Scanner Case A";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(41, 164);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1256, 535);
            Controls.Add(panel3);
            Controls.Add(rdPanel1);
            Name = "LoginView";
            Text = "LoginView";
            WindowState = FormWindowState.Maximized;
            FormClosed += LoginView_FormClosed;
            rdPanel1.ResumeLayout(false);
            rdPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Component.RDPanel rdPanel1;
        private TextBox textBoxNik;
        private Label label1;
        private TextBox textBoxPassword;
        private Panel panel1;
        private Button btnLogin;
        private Panel panel2;
        private Button btnExit;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
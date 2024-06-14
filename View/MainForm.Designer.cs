namespace BarcodeCaseA
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSetting = new Button();
            btnLogOut = new Button();
            btnScan = new Button();
            btnRecord = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 140, 124);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1243, 89);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(693, 24);
            label2.Name = "label2";
            label2.Size = new Size(538, 42);
            label2.TabIndex = 1;
            label2.Text = "Laundry System Business Unit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 17);
            label1.Name = "label1";
            label1.Size = new Size(598, 57);
            label1.TabIndex = 0;
            label1.Text = "Barcode Scanner Case A";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 89);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(1243, 361);
            splitContainer1.SplitterDistance = 92;
            splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(27, 140, 124);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnSetting, 0, 3);
            tableLayoutPanel1.Controls.Add(btnLogOut, 0, 7);
            tableLayoutPanel1.Controls.Add(btnScan, 0, 1);
            tableLayoutPanel1.Controls.Add(btnRecord, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(92, 361);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Fill;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Franklin Gothic Medium", 14.25F);
            btnSetting.ForeColor = Color.White;
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.Location = new Point(3, 141);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(86, 38);
            btnSetting.TabIndex = 3;
            btnSetting.Text = "Setting";
            btnSetting.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.Dock = DockStyle.Fill;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Franklin Gothic Medium", 14.25F);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(3, 317);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(86, 41);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnScan
            // 
            btnScan.Dock = DockStyle.Fill;
            btnScan.FlatAppearance.BorderSize = 0;
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScan.ForeColor = Color.White;
            btnScan.Image = (Image)resources.GetObject("btnScan.Image");
            btnScan.Location = new Point(3, 53);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(86, 38);
            btnScan.TabIndex = 1;
            btnScan.Text = "Scan";
            btnScan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnScan.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            btnRecord.Dock = DockStyle.Fill;
            btnRecord.FlatAppearance.BorderSize = 0;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Franklin Gothic Medium", 14.25F);
            btnRecord.ForeColor = Color.White;
            btnRecord.Image = (Image)resources.GetObject("btnRecord.Image");
            btnRecord.Location = new Point(3, 97);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(86, 38);
            btnRecord.TabIndex = 0;
            btnRecord.Text = "Record";
            btnRecord.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRecord.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 450);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            FormClosed += MainForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLogOut;
        private Button btnScan;
        private Button btnRecord;
        private Button btnSetting;
    }
}

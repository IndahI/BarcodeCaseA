namespace BarcodeCaseA.View
{
    partial class TabControlView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            DateHeader = new Label();
            timeHeader = new Label();
            btnRefresh = new Component.RDButton();
            btnClose = new Component.RDButton();
            btnOpen = new Component.RDButton();
            btnClear = new Component.RDButton();
            textBoxInspector = new TextBox();
            label7 = new Label();
            statusText = new TextBox();
            selectIdText = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            jdgText = new Label();
            portBox = new ComboBox();
            setModelBox = new ComboBox();
            scanBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSearch = new Component.RDButton();
            dtFromDate = new DateTimePicker();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(3, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1299, 629);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(238, 241, 243);
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Controls.Add(btnRefresh);
            tabPage1.Controls.Add(btnClose);
            tabPage1.Controls.Add(btnOpen);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(textBoxInspector);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(statusText);
            tabPage1.Controls.Add(selectIdText);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(portBox);
            tabPage1.Controls.Add(setModelBox);
            tabPage1.Controls.Add(scanBox);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1291, 600);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(DateHeader, 0, 0);
            tableLayoutPanel2.Controls.Add(timeHeader, 1, 0);
            tableLayoutPanel2.Location = new Point(745, 6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(524, 37);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // DateHeader
            // 
            DateHeader.Anchor = AnchorStyles.None;
            DateHeader.AutoSize = true;
            DateHeader.Font = new Font("Helvetica", 15.75F, FontStyle.Bold);
            DateHeader.Location = new Point(148, 6);
            DateHeader.Name = "DateHeader";
            DateHeader.Size = new Size(69, 25);
            DateHeader.TabIndex = 21;
            DateHeader.Text = "DATE";
            // 
            // timeHeader
            // 
            timeHeader.Anchor = AnchorStyles.None;
            timeHeader.AutoSize = true;
            timeHeader.Font = new Font("Helvetica", 15.75F, FontStyle.Bold);
            timeHeader.Location = new Point(412, 6);
            timeHeader.Name = "timeHeader";
            timeHeader.Size = new Size(65, 25);
            timeHeader.TabIndex = 20;
            timeHeader.Text = "TIME";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(34, 40, 43);
            btnRefresh.BackgroundColor = Color.FromArgb(34, 40, 43);
            btnRefresh.BorderColor = Color.PaleVioletRed;
            btnRefresh.BorderRadius = 8;
            btnRefresh.BorderSize = 0;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(60, 517);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 34);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextColor = Color.White;
            btnRefresh.UseVisualStyleBackColor = false;
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
            btnClose.Location = new Point(411, 470);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 33);
            btnClose.TabIndex = 24;
            btnClose.Text = "CLOSE";
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
            btnOpen.Location = new Point(290, 470);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(97, 33);
            btnOpen.TabIndex = 23;
            btnOpen.Text = "OPEN";
            btnOpen.TextColor = Color.White;
            btnOpen.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(46, 174, 156);
            btnClear.BackgroundColor = Color.FromArgb(46, 174, 156);
            btnClear.BorderColor = Color.PaleVioletRed;
            btnClear.BorderRadius = 8;
            btnClear.BorderSize = 0;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(518, 56);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 40);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear Data";
            btnClear.TextColor = Color.White;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // textBoxInspector
            // 
            textBoxInspector.BackColor = Color.FromArgb(220, 225, 230);
            textBoxInspector.BorderStyle = BorderStyle.None;
            textBoxInspector.Font = new Font("Helvetica", 14.25F);
            textBoxInspector.Location = new Point(235, 229);
            textBoxInspector.Multiline = true;
            textBoxInspector.Name = "textBoxInspector";
            textBoxInspector.ReadOnly = true;
            textBoxInspector.Size = new Size(231, 23);
            textBoxInspector.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label7.Location = new Point(60, 229);
            label7.Name = "label7";
            label7.Size = new Size(125, 22);
            label7.TabIndex = 18;
            label7.Text = "INSPECTOR";
            // 
            // statusText
            // 
            statusText.BackColor = Color.FromArgb(220, 225, 230);
            statusText.BorderStyle = BorderStyle.None;
            statusText.Font = new Font("Helvetica", 14.25F);
            statusText.Location = new Point(235, 280);
            statusText.Multiline = true;
            statusText.Name = "statusText";
            statusText.ReadOnly = true;
            statusText.Size = new Size(231, 111);
            statusText.TabIndex = 17;
            // 
            // selectIdText
            // 
            selectIdText.BackColor = Color.FromArgb(220, 225, 230);
            selectIdText.BorderStyle = BorderStyle.FixedSingle;
            selectIdText.Font = new Font("Helvetica", 14.25F);
            selectIdText.Location = new Point(235, 174);
            selectIdText.Name = "selectIdText";
            selectIdText.ReadOnly = true;
            selectIdText.Size = new Size(231, 30);
            selectIdText.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label6.Location = new Point(60, 280);
            label6.Name = "label6";
            label6.Size = new Size(86, 22);
            label6.TabIndex = 14;
            label6.Text = "STATUS";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(jdgText);
            panel1.Location = new Point(718, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 450);
            panel1.TabIndex = 11;
            // 
            // jdgText
            // 
            jdgText.Anchor = AnchorStyles.Top;
            jdgText.AutoSize = true;
            jdgText.Font = new Font("Helvetica", 200.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jdgText.ForeColor = Color.White;
            jdgText.Location = new Point(15, 61);
            jdgText.Name = "jdgText";
            jdgText.Size = new Size(533, 318);
            jdgText.TabIndex = 12;
            jdgText.Text = "NG";
            jdgText.Visible = false;
            // 
            // portBox
            // 
            portBox.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            portBox.FormattingEnabled = true;
            portBox.Location = new Point(60, 473);
            portBox.Name = "portBox";
            portBox.Size = new Size(184, 27);
            portBox.TabIndex = 8;
            // 
            // setModelBox
            // 
            setModelBox.Font = new Font("Helvetica", 14.25F);
            setModelBox.FormattingEnabled = true;
            setModelBox.Location = new Point(235, 114);
            setModelBox.Name = "setModelBox";
            setModelBox.Size = new Size(231, 30);
            setModelBox.TabIndex = 7;
            // 
            // scanBox
            // 
            scanBox.BorderStyle = BorderStyle.FixedSingle;
            scanBox.Font = new Font("Helvetica", 14.25F);
            scanBox.Location = new Point(235, 61);
            scanBox.Name = "scanBox";
            scanBox.Size = new Size(231, 30);
            scanBox.TabIndex = 6;
            scanBox.KeyDown += scanBox_KeyDown;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(850, 65);
            label5.Name = "label5";
            label5.Size = new Size(324, 57);
            label5.TabIndex = 4;
            label5.Text = "JUDGEMENT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 450);
            label4.Name = "label4";
            label4.Size = new Size(161, 22);
            label4.TabIndex = 3;
            label4.Text = "PORT ARDUINO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label3.Location = new Point(60, 118);
            label3.Name = "label3";
            label3.Size = new Size(126, 22);
            label3.TabIndex = 2;
            label3.Text = "SET MODEL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label2.Location = new Point(60, 178);
            label2.Name = "label2";
            label2.Size = new Size(151, 22);
            label2.TabIndex = 1;
            label2.Text = "REG. NUMBER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label1.Location = new Point(60, 65);
            label1.Name = "label1";
            label1.Size = new Size(65, 22);
            label1.TabIndex = 0;
            label1.Text = "SCAN";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1291, 600);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { No });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1285, 550);
            dataGridView1.TabIndex = 0;
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            No.HeaderText = "No";
            No.Name = "No";
            No.Resizable = DataGridViewTriState.False;
            No.Width = 50;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(238, 241, 243);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.09452F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.09453F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.3731346F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4378166F));
            tableLayoutPanel1.Controls.Add(btnSearch, 3, 0);
            tableLayoutPanel1.Controls.Add(dtFromDate, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1285, 44);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(46, 174, 156);
            btnSearch.BackgroundColor = Color.FromArgb(46, 174, 156);
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 8;
            btnSearch.BorderSize = 0;
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1127, 3);
            btnSearch.Margin = new Padding(3, 3, 3, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(155, 31);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dtFromDate
            // 
            dtFromDate.CalendarFont = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFromDate.Dock = DockStyle.Fill;
            dtFromDate.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFromDate.Location = new Point(801, 3);
            dtFromDate.Name = "dtFromDate";
            dtFromDate.Size = new Size(320, 26);
            dtFromDate.TabIndex = 0;
            dtFromDate.Value = new DateTime(2024, 6, 6, 0, 0, 0, 0);
            // 
            // TabControlView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "TabControlView";
            Size = new Size(1299, 629);
            Load += TabControl_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private Label jdgText;
        private ComboBox portBox;
        private ComboBox setModelBox;
        private TextBox scanBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn No;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dtFromDate;
        private Label label6;
        private TextBox selectIdText;
        private TextBox statusText;
        private TextBox textBoxInspector;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
        private Label DateHeader;
        private Label timeHeader;
        private Component.RDButton btnRefresh;
        private Component.RDButton btnClose;
        private Component.RDButton btnOpen;
        private Component.RDButton btnClear;
        private Component.RDButton btnSearch;
        private TableLayoutPanel tableLayoutPanel2;
    }
}

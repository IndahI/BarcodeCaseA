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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControlView));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView2 = new DataGridView();
            No2 = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            timeHeader = new Label();
            DateHeader = new Label();
            panel2 = new Panel();
            jdgText = new Label();
            label4 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            scanBox = new TextBox();
            textBoxInspector = new TextBox();
            selectIdText = new TextBox();
            label7 = new Label();
            setModelBox = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            btnClear = new Component.RDButton();
            statusText = new TextBox();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSearch = new Component.RDButton();
            dtFromDate = new DateTimePicker();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
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
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(tableLayoutPanel4);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1291, 600);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { No2 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 218);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(1285, 379);
            dataGridView2.TabIndex = 21;
            // 
            // No2
            // 
            No2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            No2.HeaderText = "No";
            No2.Name = "No2";
            No2.Width = 50;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1285, 215);
            tableLayoutPanel4.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(timeHeader, 0, 1);
            tableLayoutPanel2.Controls.Add(DateHeader, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(838, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.121212F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.121212F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(444, 209);
            tableLayoutPanel2.TabIndex = 43;
            // 
            // timeHeader
            // 
            timeHeader.Anchor = AnchorStyles.None;
            timeHeader.AutoSize = true;
            timeHeader.Font = new Font("Helvetica", 15.75F, FontStyle.Bold);
            timeHeader.Location = new Point(189, 25);
            timeHeader.Name = "timeHeader";
            timeHeader.Size = new Size(65, 25);
            timeHeader.TabIndex = 40;
            timeHeader.Text = "TIME";
            // 
            // DateHeader
            // 
            DateHeader.Anchor = AnchorStyles.None;
            DateHeader.AutoSize = true;
            DateHeader.Font = new Font("Helvetica", 15.75F, FontStyle.Bold);
            DateHeader.Location = new Point(187, 0);
            DateHeader.Name = "DateHeader";
            DateHeader.Size = new Size(69, 25);
            DateHeader.TabIndex = 39;
            DateHeader.Text = "DATE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(jdgText);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 153);
            panel2.TabIndex = 37;
            // 
            // jdgText
            // 
            jdgText.AutoSize = true;
            jdgText.Font = new Font("Helvetica", 99.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jdgText.ForeColor = Color.White;
            jdgText.Location = new Point(95, -6);
            jdgText.Name = "jdgText";
            jdgText.Size = new Size(266, 159);
            jdgText.TabIndex = 13;
            jdgText.Text = "NG";
            jdgText.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 99.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(761, 62);
            label4.Name = "label4";
            label4.Size = new Size(266, 159);
            label4.TabIndex = 12;
            label4.Text = "NG";
            label4.Visible = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 81F));
            tableLayoutPanel7.Size = new Size(829, 209);
            tableLayoutPanel7.TabIndex = 44;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.714286F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9523811F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.3333359F));
            tableLayoutPanel8.Controls.Add(pictureBox5, 0, 4);
            tableLayoutPanel8.Controls.Add(label1, 1, 4);
            tableLayoutPanel8.Controls.Add(pictureBox4, 0, 3);
            tableLayoutPanel8.Controls.Add(pictureBox3, 0, 2);
            tableLayoutPanel8.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel8.Controls.Add(scanBox, 2, 0);
            tableLayoutPanel8.Controls.Add(textBoxInspector, 2, 3);
            tableLayoutPanel8.Controls.Add(selectIdText, 2, 2);
            tableLayoutPanel8.Controls.Add(label7, 1, 0);
            tableLayoutPanel8.Controls.Add(setModelBox, 2, 1);
            tableLayoutPanel8.Controls.Add(label8, 1, 3);
            tableLayoutPanel8.Controls.Add(label5, 1, 1);
            tableLayoutPanel8.Controls.Add(label6, 1, 2);
            tableLayoutPanel8.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel10, 2, 4);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 5;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.Size = new Size(823, 203);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 163);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 160);
            label1.Name = "label1";
            label1.Size = new Size(86, 43);
            label1.TabIndex = 15;
            label1.Text = "STATUS";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 123);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 83);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // scanBox
            // 
            scanBox.BorderStyle = BorderStyle.FixedSingle;
            scanBox.Dock = DockStyle.Fill;
            scanBox.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scanBox.Location = new Point(222, 3);
            scanBox.Name = "scanBox";
            scanBox.Size = new Size(598, 30);
            scanBox.TabIndex = 9;
            scanBox.KeyDown += scanBox_KeyDown;
            // 
            // textBoxInspector
            // 
            textBoxInspector.BorderStyle = BorderStyle.FixedSingle;
            textBoxInspector.Dock = DockStyle.Fill;
            textBoxInspector.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInspector.Location = new Point(222, 123);
            textBoxInspector.Name = "textBoxInspector";
            textBoxInspector.ReadOnly = true;
            textBoxInspector.Size = new Size(598, 30);
            textBoxInspector.TabIndex = 7;
            // 
            // selectIdText
            // 
            selectIdText.BorderStyle = BorderStyle.FixedSingle;
            selectIdText.Dock = DockStyle.Fill;
            selectIdText.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectIdText.Location = new Point(222, 83);
            selectIdText.Name = "selectIdText";
            selectIdText.ReadOnly = true;
            selectIdText.Size = new Size(598, 30);
            selectIdText.TabIndex = 6;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(50, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 40);
            label7.TabIndex = 4;
            label7.Text = "SCAN";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // setModelBox
            // 
            setModelBox.Dock = DockStyle.Fill;
            setModelBox.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setModelBox.FormattingEnabled = true;
            setModelBox.Location = new Point(222, 43);
            setModelBox.Name = "setModelBox";
            setModelBox.Size = new Size(598, 30);
            setModelBox.TabIndex = 2;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(50, 120);
            label8.Name = "label8";
            label8.Size = new Size(125, 40);
            label8.TabIndex = 5;
            label8.Text = "INSPECTOR";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 40);
            label5.Name = "label5";
            label5.Size = new Size(126, 40);
            label5.TabIndex = 0;
            label5.Text = "SET MODEL";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 80);
            label6.Name = "label6";
            label6.Size = new Size(151, 40);
            label6.TabIndex = 3;
            label6.Text = "REG. NUMBER";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.Controls.Add(btnClear, 0, 0);
            tableLayoutPanel10.Controls.Add(statusText, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(219, 160);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(604, 43);
            tableLayoutPanel10.TabIndex = 17;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(46, 174, 156);
            btnClear.BackgroundColor = Color.FromArgb(46, 174, 156);
            btnClear.BorderColor = Color.PaleVioletRed;
            btnClear.BorderRadius = 8;
            btnClear.BorderSize = 0;
            btnClear.Dock = DockStyle.Fill;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(456, 0);
            btnClear.Margin = new Padding(3, 0, 3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 40);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear Data";
            btnClear.TextColor = Color.White;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // statusText
            // 
            statusText.BorderStyle = BorderStyle.FixedSingle;
            statusText.Dock = DockStyle.Fill;
            statusText.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusText.Location = new Point(3, 3);
            statusText.Name = "statusText";
            statusText.ReadOnly = true;
            statusText.Size = new Size(447, 30);
            statusText.TabIndex = 11;
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
            dataGridView1.Location = new Point(3, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1285, 552);
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
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(btnSearch, 2, 0);
            tableLayoutPanel1.Controls.Add(dtFromDate, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1285, 42);
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
            btnSearch.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1094, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(188, 36);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dtFromDate
            // 
            dtFromDate.CalendarFont = new Font("Helvetica", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFromDate.Dock = DockStyle.Fill;
            dtFromDate.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFromDate.Location = new Point(645, 3);
            dtFromDate.Name = "dtFromDate";
            dtFromDate.Size = new Size(443, 30);
            dtFromDate.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.121212F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.121212F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1285, 594);
            tableLayoutPanel3.TabIndex = 42;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.834385F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.35715F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.8084641F));
            tableLayoutPanel5.Controls.Add(label2, 1, 0);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label2.Location = new Point(14, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 100);
            label2.TabIndex = 28;
            label2.Text = "SCAN";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn No;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn No2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label timeHeader;
        private Label DateHeader;
        private Panel panel2;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label5;
        private TextBox scan;
        private TextBox textBoxInspector;
        private TextBox selectIdText;
        private Label label7;
        private ComboBox setModelBox;
        private Label label8;
        private Label label6;
        private TextBox scanBox;
        private Label jdgText;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox5;
        private TableLayoutPanel tableLayoutPanel10;
        private Component.RDButton btnClear;
        private TextBox statusText;
        private TableLayoutPanel tableLayoutPanel1;
        private Component.RDButton btnSearch;
        private DateTimePicker dtFromDate;
    }
}

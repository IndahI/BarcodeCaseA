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
            dataGridView2 = new DataGridView();
            No2 = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            panel1 = new Panel();
            jdgText = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            scanBox = new TextBox();
            label3 = new Label();
            setModelBox = new ComboBox();
            label4 = new Label();
            selectIdText = new TextBox();
            label5 = new Label();
            textBoxInspector = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnClear = new Component.RDButton();
            statusText = new TextBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            timeHeader = new Label();
            DateHeader = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSearch = new Component.RDButton();
            dtFromDate = new DateTimePicker();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
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
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(tableLayoutPanel2);
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
            dataGridView2.Location = new Point(3, 361);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(1285, 236);
            dataGridView2.TabIndex = 21;
            // 
            // No2
            // 
            No2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            No2.HeaderText = "No";
            No2.Name = "No2";
            No2.Width = 50;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Controls.Add(label6, 1, 1);
            tableLayoutPanel2.Controls.Add(panel1, 1, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.55555534F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 72.22222F));
            tableLayoutPanel2.Size = new Size(1285, 358);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Helvetica", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(898, 30);
            label6.Name = "label6";
            label6.Size = new Size(324, 57);
            label6.TabIndex = 37;
            label6.Text = "JUDGEMENT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(jdgText);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(838, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 254);
            panel1.TabIndex = 36;
            // 
            // jdgText
            // 
            jdgText.Anchor = AnchorStyles.Top;
            jdgText.AutoSize = true;
            jdgText.Font = new Font("Helvetica", 99.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jdgText.ForeColor = Color.White;
            jdgText.Location = new Point(103, 54);
            jdgText.Name = "jdgText";
            jdgText.Size = new Size(266, 159);
            jdgText.TabIndex = 12;
            jdgText.Text = "NG";
            jdgText.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 101);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(829, 254);
            tableLayoutPanel4.TabIndex = 38;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(scanBox, 1, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 1);
            tableLayoutPanel5.Controls.Add(setModelBox, 1, 1);
            tableLayoutPanel5.Controls.Add(label4, 2, 0);
            tableLayoutPanel5.Controls.Add(selectIdText, 3, 0);
            tableLayoutPanel5.Controls.Add(label5, 2, 1);
            tableLayoutPanel5.Controls.Add(textBoxInspector, 3, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(823, 184);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(199, 92);
            label2.TabIndex = 28;
            label2.Text = "SCAN";
            // 
            // scanBox
            // 
            scanBox.BorderStyle = BorderStyle.FixedSingle;
            scanBox.Dock = DockStyle.Fill;
            scanBox.Font = new Font("Helvetica", 14.25F);
            scanBox.Location = new Point(208, 3);
            scanBox.Name = "scanBox";
            scanBox.Size = new Size(199, 30);
            scanBox.TabIndex = 33;
            scanBox.KeyDown += scanBox_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label3.Location = new Point(3, 92);
            label3.Name = "label3";
            label3.Size = new Size(199, 92);
            label3.TabIndex = 34;
            label3.Text = "SET MODEL";
            // 
            // setModelBox
            // 
            setModelBox.Dock = DockStyle.Fill;
            setModelBox.Font = new Font("Helvetica", 14.25F);
            setModelBox.FormattingEnabled = true;
            setModelBox.Location = new Point(208, 95);
            setModelBox.Name = "setModelBox";
            setModelBox.Size = new Size(199, 30);
            setModelBox.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label4.Location = new Point(413, 0);
            label4.Name = "label4";
            label4.Size = new Size(199, 92);
            label4.TabIndex = 36;
            label4.Text = "REG. NUMBER";
            // 
            // selectIdText
            // 
            selectIdText.BackColor = Color.FromArgb(220, 225, 230);
            selectIdText.BorderStyle = BorderStyle.FixedSingle;
            selectIdText.Dock = DockStyle.Fill;
            selectIdText.Font = new Font("Helvetica", 14.25F);
            selectIdText.Location = new Point(618, 3);
            selectIdText.Name = "selectIdText";
            selectIdText.ReadOnly = true;
            selectIdText.Size = new Size(202, 30);
            selectIdText.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            label5.Location = new Point(413, 92);
            label5.Name = "label5";
            label5.Size = new Size(199, 92);
            label5.TabIndex = 40;
            label5.Text = "INSPECTOR";
            // 
            // textBoxInspector
            // 
            textBoxInspector.BackColor = Color.FromArgb(220, 225, 230);
            textBoxInspector.BorderStyle = BorderStyle.FixedSingle;
            textBoxInspector.Dock = DockStyle.Fill;
            textBoxInspector.Font = new Font("Helvetica", 14.25F);
            textBoxInspector.Location = new Point(618, 95);
            textBoxInspector.Name = "textBoxInspector";
            textBoxInspector.ReadOnly = true;
            textBoxInspector.Size = new Size(202, 30);
            textBoxInspector.TabIndex = 41;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Controls.Add(btnClear, 0, 0);
            tableLayoutPanel6.Controls.Add(statusText, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 193);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(823, 58);
            tableLayoutPanel6.TabIndex = 1;
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
            btnClear.Font = new Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(620, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(200, 52);
            btnClear.TabIndex = 42;
            btnClear.Text = "Clear Data";
            btnClear.TextColor = Color.White;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // statusText
            // 
            statusText.BackColor = Color.FromArgb(220, 225, 230);
            statusText.BorderStyle = BorderStyle.None;
            statusText.Dock = DockStyle.Fill;
            statusText.Font = new Font("Helvetica", 14.25F);
            statusText.Location = new Point(3, 3);
            statusText.Multiline = true;
            statusText.Name = "statusText";
            statusText.ReadOnly = true;
            statusText.Size = new Size(611, 52);
            statusText.TabIndex = 40;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.Controls.Add(timeHeader, 0, 0);
            tableLayoutPanel7.Controls.Add(DateHeader, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 22);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(829, 73);
            tableLayoutPanel7.TabIndex = 39;
            // 
            // timeHeader
            // 
            timeHeader.Anchor = AnchorStyles.None;
            timeHeader.AutoSize = true;
            timeHeader.Font = new Font("Helvetica", 15.75F, FontStyle.Bold);
            timeHeader.Location = new Point(381, 24);
            timeHeader.Name = "timeHeader";
            timeHeader.Size = new Size(65, 25);
            timeHeader.TabIndex = 23;
            timeHeader.Text = "TIME";
            // 
            // DateHeader
            // 
            DateHeader.Anchor = AnchorStyles.None;
            DateHeader.AutoSize = true;
            DateHeader.Font = new Font("Helvetica", 15.75F, FontStyle.Bold);
            DateHeader.Location = new Point(103, 24);
            DateHeader.Name = "DateHeader";
            DateHeader.Size = new Size(69, 25);
            DateHeader.TabIndex = 22;
            DateHeader.Text = "DATE";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn No;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dtFromDate;
        private System.Windows.Forms.Timer timer1;
        private Component.RDButton btnSearch;
        private DataGridView dataGridView2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private Panel panel1;
        private Label jdgText;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private TextBox scanBox;
        private Label label3;
        private ComboBox setModelBox;
        private Label label4;
        private TextBox selectIdText;
        private Label label5;
        private TextBox textBoxInspector;
        private TableLayoutPanel tableLayoutPanel6;
        private Component.RDButton btnClear;
        private TextBox statusText;
        private TableLayoutPanel tableLayoutPanel7;
        private Label timeHeader;
        private Label DateHeader;
        private DataGridViewTextBoxColumn No2;
    }
}

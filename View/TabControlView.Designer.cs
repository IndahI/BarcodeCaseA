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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            statusText = new TextBox();
            selectIdText = new TextBox();
            label6 = new Label();
            btnClear = new Button();
            btnRefresh = new Button();
            panel1 = new Panel();
            jdgText = new Label();
            btnClose = new Button();
            btnOpen = new Button();
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
            btnSearch = new Button();
            dtFromDate = new DateTimePicker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1299, 629);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(statusText);
            tabPage1.Controls.Add(selectIdText);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(btnRefresh);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(btnClose);
            tabPage1.Controls.Add(btnOpen);
            tabPage1.Controls.Add(portBox);
            tabPage1.Controls.Add(setModelBox);
            tabPage1.Controls.Add(scanBox);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1291, 601);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusText
            // 
            statusText.BorderStyle = BorderStyle.None;
            statusText.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusText.Location = new Point(235, 234);
            statusText.Multiline = true;
            statusText.Name = "statusText";
            statusText.ReadOnly = true;
            statusText.Size = new Size(231, 23);
            statusText.TabIndex = 17;
            // 
            // selectIdText
            // 
            selectIdText.BorderStyle = BorderStyle.FixedSingle;
            selectIdText.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectIdText.Location = new Point(235, 174);
            selectIdText.Name = "selectIdText";
            selectIdText.ReadOnly = true;
            selectIdText.Size = new Size(231, 29);
            selectIdText.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 14.25F);
            label6.Location = new Point(60, 234);
            label6.Name = "label6";
            label6.Size = new Size(72, 24);
            label6.TabIndex = 14;
            label6.Text = "STATUS";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 173, 181);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(518, 60);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 34);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear Data";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 173, 181);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(69, 404);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 34);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(jdgText);
            panel1.Location = new Point(718, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 451);
            panel1.TabIndex = 11;
            // 
            // jdgText
            // 
            jdgText.Anchor = AnchorStyles.Top;
            jdgText.AutoSize = true;
            jdgText.Font = new Font("Franklin Gothic Demi", 200.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jdgText.ForeColor = Color.White;
            jdgText.Location = new Point(55, 73);
            jdgText.Name = "jdgText";
            jdgText.Size = new Size(471, 303);
            jdgText.TabIndex = 12;
            jdgText.Text = "NG";
            jdgText.Visible = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(420, 352);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(92, 34);
            btnClose.TabIndex = 10;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.FromArgb(0, 173, 181);
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(299, 352);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(88, 34);
            btnOpen.TabIndex = 9;
            btnOpen.Text = "OPEN";
            btnOpen.UseVisualStyleBackColor = false;
            // 
            // portBox
            // 
            portBox.FormattingEnabled = true;
            portBox.Location = new Point(69, 360);
            portBox.Name = "portBox";
            portBox.Size = new Size(184, 23);
            portBox.TabIndex = 8;
            // 
            // setModelBox
            // 
            setModelBox.Font = new Font("Franklin Gothic Medium", 14.25F);
            setModelBox.FormattingEnabled = true;
            setModelBox.Location = new Point(235, 114);
            setModelBox.Name = "setModelBox";
            setModelBox.Size = new Size(231, 32);
            setModelBox.TabIndex = 7;
            // 
            // scanBox
            // 
            scanBox.BorderStyle = BorderStyle.FixedSingle;
            scanBox.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scanBox.Location = new Point(235, 62);
            scanBox.Name = "scanBox";
            scanBox.Size = new Size(231, 29);
            scanBox.TabIndex = 6;
            scanBox.KeyDown += scanBox_KeyDown;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Demi", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(871, 60);
            label5.Name = "label5";
            label5.Size = new Size(287, 61);
            label5.TabIndex = 4;
            label5.Text = "JUDGEMENT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 14.25F);
            label4.Location = new Point(63, 336);
            label4.Name = "label4";
            label4.Size = new Size(134, 24);
            label4.TabIndex = 3;
            label4.Text = "PORT ARDUINO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 14.25F);
            label3.Location = new Point(60, 116);
            label3.Name = "label3";
            label3.Size = new Size(103, 24);
            label3.TabIndex = 2;
            label3.Text = "SET MODEL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 14.25F);
            label2.Location = new Point(60, 174);
            label2.Name = "label2";
            label2.Size = new Size(126, 24);
            label2.TabIndex = 1;
            label2.Text = "REG. NUMBER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 62);
            label1.Name = "label1";
            label1.Size = new Size(55, 24);
            label1.TabIndex = 0;
            label1.Text = "SCAN";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1291, 601);
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
            dataGridView1.Location = new Point(3, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1285, 549);
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
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.7647057F));
            tableLayoutPanel1.Controls.Add(btnSearch, 3, 0);
            tableLayoutPanel1.Controls.Add(dtFromDate, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1285, 46);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Location = new Point(1134, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(148, 40);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dtFromDate
            // 
            dtFromDate.Dock = DockStyle.Fill;
            dtFromDate.Location = new Point(757, 3);
            dtFromDate.Name = "dtFromDate";
            dtFromDate.Size = new Size(371, 23);
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
        private Button btnClose;
        private Button btnOpen;
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
        private Button btnRefresh;
        private Button btnClear;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSearch;
        private DateTimePicker dtFromDate;
        private Label label6;
        private TextBox selectIdText;
        private TextBox statusText;
    }
}

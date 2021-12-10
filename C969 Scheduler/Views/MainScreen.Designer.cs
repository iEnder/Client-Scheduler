
namespace C969_Scheduler.Views
{
    partial class Scheduler
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.appGrid = new System.Windows.Forms.DataGridView();
            this.aptCloseBtn = new System.Windows.Forms.Button();
            this.timeBox = new System.Windows.Forms.GroupBox();
            this.allRad = new System.Windows.Forms.RadioButton();
            this.monthRad = new System.Windows.Forms.RadioButton();
            this.weekRad = new System.Windows.Forms.RadioButton();
            this.aptDelBtn = new System.Windows.Forms.Button();
            this.aptModBtn = new System.Windows.Forms.Button();
            this.aptAddBtn = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cusSearchBtn = new System.Windows.Forms.Button();
            this.cusSearch = new System.Windows.Forms.TextBox();
            this.cusCloseBtn = new System.Windows.Forms.Button();
            this.cusDelBtn = new System.Windows.Forms.Button();
            this.cusModBtn = new System.Windows.Forms.Button();
            this.cusAddBtn = new System.Windows.Forms.Button();
            this.cusGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.reportCloseBtn = new System.Windows.Forms.Button();
            this.report3Btn = new System.Windows.Forms.Button();
            this.report2Btn = new System.Windows.Forms.Button();
            this.report1Btn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.userCloseBtn = new System.Windows.Forms.Button();
            this.userDelBtn = new System.Windows.Forms.Button();
            this.userModBtn = new System.Windows.Forms.Button();
            this.userAddBtn = new System.Windows.Forms.Button();
            this.userGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appGrid)).BeginInit();
            this.timeBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cusGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.appGrid);
            this.tabPage2.Controls.Add(this.aptCloseBtn);
            this.tabPage2.Controls.Add(this.timeBox);
            this.tabPage2.Controls.Add(this.aptDelBtn);
            this.tabPage2.Controls.Add(this.aptModBtn);
            this.tabPage2.Controls.Add(this.aptAddBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1104, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Appointments";
            // 
            // appGrid
            // 
            this.appGrid.AllowUserToAddRows = false;
            this.appGrid.AllowUserToDeleteRows = false;
            this.appGrid.AllowUserToResizeColumns = false;
            this.appGrid.AllowUserToResizeRows = false;
            this.appGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appGrid.Location = new System.Drawing.Point(8, 76);
            this.appGrid.Margin = new System.Windows.Forms.Padding(5);
            this.appGrid.MultiSelect = false;
            this.appGrid.Name = "appGrid";
            this.appGrid.ReadOnly = true;
            this.appGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.appGrid.RowHeadersVisible = false;
            this.appGrid.RowHeadersWidth = 51;
            this.appGrid.RowTemplate.Height = 24;
            this.appGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appGrid.Size = new System.Drawing.Size(1085, 437);
            this.appGrid.TabIndex = 9;
            // 
            // aptCloseBtn
            // 
            this.aptCloseBtn.Location = new System.Drawing.Point(895, 523);
            this.aptCloseBtn.Margin = new System.Windows.Forms.Padding(5);
            this.aptCloseBtn.Name = "aptCloseBtn";
            this.aptCloseBtn.Size = new System.Drawing.Size(199, 49);
            this.aptCloseBtn.TabIndex = 8;
            this.aptCloseBtn.Text = "Close";
            this.aptCloseBtn.UseVisualStyleBackColor = true;
            this.aptCloseBtn.Click += new System.EventHandler(this.aptCloseBtn_Click);
            // 
            // timeBox
            // 
            this.timeBox.Controls.Add(this.allRad);
            this.timeBox.Controls.Add(this.monthRad);
            this.timeBox.Controls.Add(this.weekRad);
            this.timeBox.Location = new System.Drawing.Point(8, 7);
            this.timeBox.Margin = new System.Windows.Forms.Padding(5);
            this.timeBox.Name = "timeBox";
            this.timeBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeBox.Size = new System.Drawing.Size(1085, 59);
            this.timeBox.TabIndex = 1;
            this.timeBox.TabStop = false;
            this.timeBox.Text = "Display By:";
            // 
            // allRad
            // 
            this.allRad.AutoSize = true;
            this.allRad.Location = new System.Drawing.Point(315, 21);
            this.allRad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allRad.Name = "allRad";
            this.allRad.Size = new System.Drawing.Size(44, 21);
            this.allRad.TabIndex = 2;
            this.allRad.TabStop = true;
            this.allRad.Text = "All";
            this.allRad.UseVisualStyleBackColor = true;
            this.allRad.CheckedChanged += new System.EventHandler(this.allRad_CheckedChanged);
            // 
            // monthRad
            // 
            this.monthRad.AutoSize = true;
            this.monthRad.Location = new System.Drawing.Point(505, 21);
            this.monthRad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthRad.Name = "monthRad";
            this.monthRad.Size = new System.Drawing.Size(68, 21);
            this.monthRad.TabIndex = 1;
            this.monthRad.TabStop = true;
            this.monthRad.Text = "Month";
            this.monthRad.UseVisualStyleBackColor = true;
            this.monthRad.CheckedChanged += new System.EventHandler(this.monthRad_CheckedChanged);
            // 
            // weekRad
            // 
            this.weekRad.AutoSize = true;
            this.weekRad.Location = new System.Drawing.Point(701, 21);
            this.weekRad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weekRad.Name = "weekRad";
            this.weekRad.Size = new System.Drawing.Size(65, 21);
            this.weekRad.TabIndex = 0;
            this.weekRad.TabStop = true;
            this.weekRad.Text = "Week";
            this.weekRad.UseVisualStyleBackColor = true;
            this.weekRad.CheckedChanged += new System.EventHandler(this.weekRad_CheckedChanged);
            // 
            // aptDelBtn
            // 
            this.aptDelBtn.Location = new System.Drawing.Point(252, 523);
            this.aptDelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.aptDelBtn.Name = "aptDelBtn";
            this.aptDelBtn.Size = new System.Drawing.Size(113, 49);
            this.aptDelBtn.TabIndex = 7;
            this.aptDelBtn.Text = "Delete";
            this.aptDelBtn.UseVisualStyleBackColor = true;
            this.aptDelBtn.Click += new System.EventHandler(this.aptDelBtn_Click);
            // 
            // aptModBtn
            // 
            this.aptModBtn.Location = new System.Drawing.Point(129, 523);
            this.aptModBtn.Margin = new System.Windows.Forms.Padding(5);
            this.aptModBtn.Name = "aptModBtn";
            this.aptModBtn.Size = new System.Drawing.Size(113, 49);
            this.aptModBtn.TabIndex = 6;
            this.aptModBtn.Text = "Modify";
            this.aptModBtn.UseVisualStyleBackColor = true;
            this.aptModBtn.Click += new System.EventHandler(this.aptModBtn_Click);
            // 
            // aptAddBtn
            // 
            this.aptAddBtn.Location = new System.Drawing.Point(7, 523);
            this.aptAddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.aptAddBtn.Name = "aptAddBtn";
            this.aptAddBtn.Size = new System.Drawing.Size(113, 49);
            this.aptAddBtn.TabIndex = 5;
            this.aptAddBtn.Text = "Add";
            this.aptAddBtn.UseVisualStyleBackColor = true;
            this.aptAddBtn.Click += new System.EventHandler(this.aptAddBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.cusSearchBtn);
            this.tabPage1.Controls.Add(this.cusSearch);
            this.tabPage1.Controls.Add(this.cusCloseBtn);
            this.tabPage1.Controls.Add(this.cusDelBtn);
            this.tabPage1.Controls.Add(this.cusModBtn);
            this.tabPage1.Controls.Add(this.cusAddBtn);
            this.tabPage1.Controls.Add(this.cusGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1104, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            // 
            // cusSearchBtn
            // 
            this.cusSearchBtn.Location = new System.Drawing.Point(813, 10);
            this.cusSearchBtn.Name = "cusSearchBtn";
            this.cusSearchBtn.Size = new System.Drawing.Size(75, 27);
            this.cusSearchBtn.TabIndex = 6;
            this.cusSearchBtn.Text = "Search";
            this.cusSearchBtn.UseVisualStyleBackColor = true;
            this.cusSearchBtn.Click += new System.EventHandler(this.cusSearchBtn_Click);
            // 
            // cusSearch
            // 
            this.cusSearch.Location = new System.Drawing.Point(896, 11);
            this.cusSearch.Margin = new System.Windows.Forms.Padding(5);
            this.cusSearch.Name = "cusSearch";
            this.cusSearch.Size = new System.Drawing.Size(196, 22);
            this.cusSearch.TabIndex = 5;
            // 
            // cusCloseBtn
            // 
            this.cusCloseBtn.Location = new System.Drawing.Point(897, 523);
            this.cusCloseBtn.Margin = new System.Windows.Forms.Padding(5);
            this.cusCloseBtn.Name = "cusCloseBtn";
            this.cusCloseBtn.Size = new System.Drawing.Size(199, 49);
            this.cusCloseBtn.TabIndex = 4;
            this.cusCloseBtn.Text = "Close";
            this.cusCloseBtn.UseVisualStyleBackColor = true;
            this.cusCloseBtn.Click += new System.EventHandler(this.cusCloseBtn_Click);
            // 
            // cusDelBtn
            // 
            this.cusDelBtn.Location = new System.Drawing.Point(251, 523);
            this.cusDelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.cusDelBtn.Name = "cusDelBtn";
            this.cusDelBtn.Size = new System.Drawing.Size(113, 49);
            this.cusDelBtn.TabIndex = 3;
            this.cusDelBtn.Text = "Delete";
            this.cusDelBtn.UseVisualStyleBackColor = true;
            this.cusDelBtn.Click += new System.EventHandler(this.cusDelBtn_Click);
            // 
            // cusModBtn
            // 
            this.cusModBtn.Location = new System.Drawing.Point(128, 523);
            this.cusModBtn.Margin = new System.Windows.Forms.Padding(5);
            this.cusModBtn.Name = "cusModBtn";
            this.cusModBtn.Size = new System.Drawing.Size(113, 49);
            this.cusModBtn.TabIndex = 2;
            this.cusModBtn.Text = "Modify";
            this.cusModBtn.UseVisualStyleBackColor = true;
            this.cusModBtn.Click += new System.EventHandler(this.cusModBtn_Click);
            // 
            // cusAddBtn
            // 
            this.cusAddBtn.Location = new System.Drawing.Point(5, 523);
            this.cusAddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.cusAddBtn.Name = "cusAddBtn";
            this.cusAddBtn.Size = new System.Drawing.Size(113, 49);
            this.cusAddBtn.TabIndex = 1;
            this.cusAddBtn.Text = "Add";
            this.cusAddBtn.UseVisualStyleBackColor = true;
            this.cusAddBtn.Click += new System.EventHandler(this.cusAddBtn_Click);
            // 
            // cusGrid
            // 
            this.cusGrid.AllowUserToAddRows = false;
            this.cusGrid.AllowUserToDeleteRows = false;
            this.cusGrid.AllowUserToResizeColumns = false;
            this.cusGrid.AllowUserToResizeRows = false;
            this.cusGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cusGrid.Location = new System.Drawing.Point(8, 49);
            this.cusGrid.Margin = new System.Windows.Forms.Padding(5);
            this.cusGrid.MultiSelect = false;
            this.cusGrid.Name = "cusGrid";
            this.cusGrid.ReadOnly = true;
            this.cusGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cusGrid.RowHeadersVisible = false;
            this.cusGrid.RowHeadersWidth = 51;
            this.cusGrid.RowTemplate.Height = 24;
            this.cusGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cusGrid.Size = new System.Drawing.Size(1085, 464);
            this.cusGrid.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 10);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.reportCloseBtn);
            this.tabPage3.Controls.Add(this.report3Btn);
            this.tabPage3.Controls.Add(this.report2Btn);
            this.tabPage3.Controls.Add(this.report1Btn);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1104, 586);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reports";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(511, 101);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // reportCloseBtn
            // 
            this.reportCloseBtn.Location = new System.Drawing.Point(29, 818);
            this.reportCloseBtn.Margin = new System.Windows.Forms.Padding(35, 32, 35, 32);
            this.reportCloseBtn.Name = "reportCloseBtn";
            this.reportCloseBtn.Size = new System.Drawing.Size(1119, 81);
            this.reportCloseBtn.TabIndex = 5;
            this.reportCloseBtn.Text = "Close";
            this.reportCloseBtn.UseVisualStyleBackColor = true;
            this.reportCloseBtn.Click += new System.EventHandler(this.reportCloseBtn_Click);
            // 
            // report3Btn
            // 
            this.report3Btn.Location = new System.Drawing.Point(569, 32);
            this.report3Btn.Margin = new System.Windows.Forms.Padding(35, 32, 35, 32);
            this.report3Btn.Name = "report3Btn";
            this.report3Btn.Size = new System.Drawing.Size(511, 101);
            this.report3Btn.TabIndex = 2;
            this.report3Btn.Text = "Number of Customers From Each Country";
            this.report3Btn.UseVisualStyleBackColor = true;
            this.report3Btn.Click += new System.EventHandler(this.report3Btn_Click);
            // 
            // report2Btn
            // 
            this.report2Btn.Location = new System.Drawing.Point(29, 161);
            this.report2Btn.Margin = new System.Windows.Forms.Padding(35, 32, 35, 32);
            this.report2Btn.Name = "report2Btn";
            this.report2Btn.Size = new System.Drawing.Size(511, 101);
            this.report2Btn.TabIndex = 1;
            this.report2Btn.Text = "Consultant Schedules";
            this.report2Btn.UseVisualStyleBackColor = true;
            this.report2Btn.Click += new System.EventHandler(this.report2Btn_Click);
            // 
            // report1Btn
            // 
            this.report1Btn.Location = new System.Drawing.Point(29, 32);
            this.report1Btn.Margin = new System.Windows.Forms.Padding(35, 32, 35, 32);
            this.report1Btn.Name = "report1Btn";
            this.report1Btn.Size = new System.Drawing.Size(511, 101);
            this.report1Btn.TabIndex = 0;
            this.report1Btn.Text = "Appointment Types by Month";
            this.report1Btn.UseVisualStyleBackColor = true;
            this.report1Btn.Click += new System.EventHandler(this.report1Btn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.userCloseBtn);
            this.tabPage4.Controls.Add(this.userDelBtn);
            this.tabPage4.Controls.Add(this.userModBtn);
            this.tabPage4.Controls.Add(this.userAddBtn);
            this.tabPage4.Controls.Add(this.userGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1104, 586);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Users";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // userCloseBtn
            // 
            this.userCloseBtn.Location = new System.Drawing.Point(894, 529);
            this.userCloseBtn.Margin = new System.Windows.Forms.Padding(5);
            this.userCloseBtn.Name = "userCloseBtn";
            this.userCloseBtn.Size = new System.Drawing.Size(199, 49);
            this.userCloseBtn.TabIndex = 9;
            this.userCloseBtn.Text = "Close";
            this.userCloseBtn.UseVisualStyleBackColor = true;
            this.userCloseBtn.Click += new System.EventHandler(this.userCloseBtn_Click);
            // 
            // userDelBtn
            // 
            this.userDelBtn.Location = new System.Drawing.Point(254, 529);
            this.userDelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.userDelBtn.Name = "userDelBtn";
            this.userDelBtn.Size = new System.Drawing.Size(113, 49);
            this.userDelBtn.TabIndex = 8;
            this.userDelBtn.Text = "Delete";
            this.userDelBtn.UseVisualStyleBackColor = true;
            this.userDelBtn.Click += new System.EventHandler(this.userDelBtn_Click);
            // 
            // userModBtn
            // 
            this.userModBtn.Location = new System.Drawing.Point(131, 529);
            this.userModBtn.Margin = new System.Windows.Forms.Padding(5);
            this.userModBtn.Name = "userModBtn";
            this.userModBtn.Size = new System.Drawing.Size(113, 49);
            this.userModBtn.TabIndex = 7;
            this.userModBtn.Text = "Modify";
            this.userModBtn.UseVisualStyleBackColor = true;
            this.userModBtn.Click += new System.EventHandler(this.userModBtn_Click);
            // 
            // userAddBtn
            // 
            this.userAddBtn.Location = new System.Drawing.Point(8, 529);
            this.userAddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.userAddBtn.Name = "userAddBtn";
            this.userAddBtn.Size = new System.Drawing.Size(113, 49);
            this.userAddBtn.TabIndex = 6;
            this.userAddBtn.Text = "Add";
            this.userAddBtn.UseVisualStyleBackColor = true;
            this.userAddBtn.Click += new System.EventHandler(this.userAddBtn_Click);
            // 
            // userGrid
            // 
            this.userGrid.AllowUserToAddRows = false;
            this.userGrid.AllowUserToDeleteRows = false;
            this.userGrid.AllowUserToResizeColumns = false;
            this.userGrid.AllowUserToResizeRows = false;
            this.userGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Location = new System.Drawing.Point(11, 8);
            this.userGrid.Margin = new System.Windows.Forms.Padding(5);
            this.userGrid.MultiSelect = false;
            this.userGrid.Name = "userGrid";
            this.userGrid.ReadOnly = true;
            this.userGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userGrid.RowHeadersVisible = false;
            this.userGrid.RowHeadersWidth = 51;
            this.userGrid.RowTemplate.Height = 24;
            this.userGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGrid.Size = new System.Drawing.Size(1085, 511);
            this.userGrid.TabIndex = 5;
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 654);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Scheduler";
            this.Text = "Scheduler";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appGrid)).EndInit();
            this.timeBox.ResumeLayout(false);
            this.timeBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cusGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cusCloseBtn;
        private System.Windows.Forms.Button cusDelBtn;
        private System.Windows.Forms.Button cusModBtn;
        private System.Windows.Forms.Button cusAddBtn;
        private System.Windows.Forms.GroupBox timeBox;
        private System.Windows.Forms.RadioButton weekRad;
        private System.Windows.Forms.RadioButton monthRad;
        private System.Windows.Forms.Button aptCloseBtn;
        private System.Windows.Forms.Button aptDelBtn;
        private System.Windows.Forms.Button aptModBtn;
        private System.Windows.Forms.Button aptAddBtn;
        private System.Windows.Forms.RadioButton allRad;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button reportCloseBtn;
        private System.Windows.Forms.Button report3Btn;
        private System.Windows.Forms.Button report2Btn;
        private System.Windows.Forms.Button report1Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cusSearch;
        private System.Windows.Forms.Button cusSearchBtn;
        private System.Windows.Forms.TabPage tabPage4;
        protected System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.DataGridView cusGrid;
        public System.Windows.Forms.DataGridView appGrid;
        private System.Windows.Forms.Button userCloseBtn;
        private System.Windows.Forms.Button userDelBtn;
        private System.Windows.Forms.Button userModBtn;
        private System.Windows.Forms.Button userAddBtn;
        public System.Windows.Forms.DataGridView userGrid;
    }
}

namespace C969_Scheduler.Views.Reports
{
    partial class CustomersByCountry
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
            this.reportGrid = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.genBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reportGrid
            // 
            this.reportGrid.AllowUserToAddRows = false;
            this.reportGrid.AllowUserToDeleteRows = false;
            this.reportGrid.AllowUserToResizeColumns = false;
            this.reportGrid.AllowUserToResizeRows = false;
            this.reportGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGrid.Location = new System.Drawing.Point(13, 61);
            this.reportGrid.Margin = new System.Windows.Forms.Padding(4);
            this.reportGrid.MultiSelect = false;
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.ReadOnly = true;
            this.reportGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportGrid.RowHeadersVisible = false;
            this.reportGrid.RowHeadersWidth = 51;
            this.reportGrid.RowTemplate.Height = 24;
            this.reportGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportGrid.Size = new System.Drawing.Size(287, 491);
            this.reportGrid.TabIndex = 5;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(238, 558);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(62, 30);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(13, 11);
            this.genBtn.Margin = new System.Windows.Forms.Padding(2);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(287, 44);
            this.genBtn.TabIndex = 7;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // CustomersByCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 596);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.reportGrid);
            this.Name = "CustomersByCountry";
            this.Text = "Customers By Country";
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reportGrid;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button genBtn;
    }
}
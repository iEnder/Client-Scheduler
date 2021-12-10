
namespace C969_Scheduler.Views
{
    partial class AppointmentController
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
            this.formLabel = new System.Windows.Forms.Label();
            this.typeInput = new System.Windows.Forms.ComboBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerInput = new System.Windows.Forms.ComboBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.contactInput = new System.Windows.Forms.TextBox();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.descInput = new System.Windows.Forms.TextBox();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.urlInput = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.startInput = new System.Windows.Forms.DateTimePicker();
            this.endInput = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(12, 9);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(116, 17);
            this.formLabel.TabIndex = 3;
            this.formLabel.Text = "Add Appointment";
            // 
            // typeInput
            // 
            this.typeInput.FormattingEnabled = true;
            this.typeInput.Location = new System.Drawing.Point(117, 304);
            this.typeInput.Margin = new System.Windows.Forms.Padding(4);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(255, 24);
            this.typeInput.TabIndex = 6;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(13, 43);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(72, 17);
            this.customerLabel.TabIndex = 95;
            this.customerLabel.Text = "Customer:";
            // 
            // customerInput
            // 
            this.customerInput.FormattingEnabled = true;
            this.customerInput.Location = new System.Drawing.Point(117, 43);
            this.customerInput.Margin = new System.Windows.Forms.Padding(4);
            this.customerInput.Name = "customerInput";
            this.customerInput.Size = new System.Drawing.Size(255, 24);
            this.customerInput.TabIndex = 1;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(16, 457);
            this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(72, 17);
            this.endLabel.TabIndex = 93;
            this.endLabel.Text = "End Time:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(16, 396);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(77, 17);
            this.startLabel.TabIndex = 92;
            this.startLabel.Text = "Start Time:";
            // 
            // contactInput
            // 
            this.contactInput.Location = new System.Drawing.Point(117, 261);
            this.contactInput.Margin = new System.Windows.Forms.Padding(4);
            this.contactInput.Name = "contactInput";
            this.contactInput.Size = new System.Drawing.Size(255, 22);
            this.contactInput.TabIndex = 5;
            // 
            // locationInput
            // 
            this.locationInput.Location = new System.Drawing.Point(117, 219);
            this.locationInput.Margin = new System.Windows.Forms.Padding(4);
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(255, 22);
            this.locationInput.TabIndex = 4;
            // 
            // descInput
            // 
            this.descInput.Location = new System.Drawing.Point(117, 135);
            this.descInput.Margin = new System.Windows.Forms.Padding(4);
            this.descInput.Multiline = true;
            this.descInput.Name = "descInput";
            this.descInput.Size = new System.Drawing.Size(255, 63);
            this.descInput.TabIndex = 3;
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(117, 89);
            this.titleInput.Margin = new System.Windows.Forms.Padding(4);
            this.titleInput.MaxLength = 255;
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(255, 22);
            this.titleInput.TabIndex = 2;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(13, 304);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 17);
            this.typeLabel.TabIndex = 85;
            this.typeLabel.Text = "Type:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(13, 261);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(60, 17);
            this.contactLabel.TabIndex = 84;
            this.contactLabel.Text = "Contact:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(13, 219);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(66, 17);
            this.locationLabel.TabIndex = 83;
            this.locationLabel.Text = "Location:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 135);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 82;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(13, 89);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 81;
            this.titleLabel.Text = "Title:";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(205, 513);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(171, 50);
            this.exitBtn.TabIndex = 98;
            this.exitBtn.Text = "Cancel";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(15, 513);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(173, 50);
            this.saveBtn.TabIndex = 97;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // urlInput
            // 
            this.urlInput.Location = new System.Drawing.Point(120, 350);
            this.urlInput.Margin = new System.Windows.Forms.Padding(4);
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(255, 22);
            this.urlInput.TabIndex = 7;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(16, 350);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(40, 17);
            this.urlLabel.TabIndex = 99;
            this.urlLabel.Text = "URL:";
            // 
            // startInput
            // 
            this.startInput.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startInput.Location = new System.Drawing.Point(120, 396);
            this.startInput.Margin = new System.Windows.Forms.Padding(4);
            this.startInput.Name = "startInput";
            this.startInput.Size = new System.Drawing.Size(255, 22);
            this.startInput.TabIndex = 8;
            // 
            // endInput
            // 
            this.endInput.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endInput.Location = new System.Drawing.Point(120, 454);
            this.endInput.Margin = new System.Windows.Forms.Padding(4);
            this.endInput.Name = "endInput";
            this.endInput.Size = new System.Drawing.Size(255, 22);
            this.endInput.TabIndex = 100;
            // 
            // AppointmentController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 590);
            this.Controls.Add(this.endInput);
            this.Controls.Add(this.urlInput);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.customerInput);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startInput);
            this.Controls.Add(this.contactInput);
            this.Controls.Add(this.locationInput);
            this.Controls.Add(this.descInput);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.formLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AppointmentController";
            this.Text = "Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.ComboBox typeInput;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customerInput;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.TextBox contactInput;
        private System.Windows.Forms.TextBox locationInput;
        private System.Windows.Forms.TextBox descInput;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox urlInput;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.DateTimePicker startInput;
        private System.Windows.Forms.DateTimePicker endInput;
    }
}
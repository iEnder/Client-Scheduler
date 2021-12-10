
namespace C969_Scheduler.Views
{
    partial class CustomerController
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.formLabel = new System.Windows.Forms.Label();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.zipInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 397);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(145, 50);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(180, 397);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(145, 50);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Cancel";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(13, 13);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(97, 17);
            this.formLabel.TabIndex = 2;
            this.formLabel.Text = "Add Customer";
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Location = new System.Drawing.Point(273, 354);
            this.noRadio.Margin = new System.Windows.Forms.Padding(4);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(47, 21);
            this.noRadio.TabIndex = 45;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Checked = true;
            this.yesRadio.Location = new System.Drawing.Point(135, 354);
            this.yesRadio.Margin = new System.Windows.Forms.Padding(4);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(53, 21);
            this.yesRadio.TabIndex = 44;
            this.yesRadio.TabStop = true;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // countryInput
            // 
            this.countryInput.Location = new System.Drawing.Point(135, 311);
            this.countryInput.Margin = new System.Windows.Forms.Padding(4);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(189, 22);
            this.countryInput.TabIndex = 43;
            // 
            // zipInput
            // 
            this.zipInput.Location = new System.Drawing.Point(135, 271);
            this.zipInput.Margin = new System.Windows.Forms.Padding(4);
            this.zipInput.Name = "zipInput";
            this.zipInput.Size = new System.Drawing.Size(189, 22);
            this.zipInput.TabIndex = 42;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(135, 228);
            this.cityInput.Margin = new System.Windows.Forms.Padding(4);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(189, 22);
            this.cityInput.TabIndex = 41;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(135, 185);
            this.addressInput.Margin = new System.Windows.Forms.Padding(4);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(189, 22);
            this.addressInput.TabIndex = 40;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(135, 140);
            this.phoneInput.Margin = new System.Windows.Forms.Padding(4);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(189, 22);
            this.phoneInput.TabIndex = 39;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(135, 92);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(189, 22);
            this.nameInput.TabIndex = 38;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(13, 271);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(69, 17);
            this.zipLabel.TabIndex = 37;
            this.zipLabel.Text = "Zip Code:";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(13, 354);
            this.activeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(50, 17);
            this.activeLabel.TabIndex = 36;
            this.activeLabel.Text = "Active:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(13, 311);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(61, 17);
            this.countryLabel.TabIndex = 35;
            this.countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(13, 228);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 17);
            this.cityLabel.TabIndex = 34;
            this.cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(14, 185);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 17);
            this.addressLabel.TabIndex = 33;
            this.addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(14, 140);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(53, 17);
            this.phoneLabel.TabIndex = 32;
            this.phoneLabel.Text = "Phone:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 92);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 31;
            this.nameLabel.Text = "Name:";
            // 
            // idInput
            // 
            this.idInput.Enabled = false;
            this.idInput.Location = new System.Drawing.Point(136, 53);
            this.idInput.Margin = new System.Windows.Forms.Padding(4);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(189, 22);
            this.idInput.TabIndex = 47;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(14, 53);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 17);
            this.IdLabel.TabIndex = 46;
            this.IdLabel.Text = "ID:";
            // 
            // CustomerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 459);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.noRadio);
            this.Controls.Add(this.yesRadio);
            this.Controls.Add(this.countryInput);
            this.Controls.Add(this.zipInput);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "CustomerController";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.TextBox countryInput;
        private System.Windows.Forms.TextBox zipInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Label IdLabel;
    }
}

namespace C969_Scheduler.Views
{
    partial class UserController
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
            this.userInput = new System.Windows.Forms.TextBox();
            this.userNae = new System.Windows.Forms.Label();
            this.passInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.activeLabel = new System.Windows.Forms.Label();
            this.noAdmin = new System.Windows.Forms.RadioButton();
            this.yesAdmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(12, 9);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(67, 17);
            this.formLabel.TabIndex = 4;
            this.formLabel.Text = "Add User";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(97, 44);
            this.userInput.Margin = new System.Windows.Forms.Padding(4);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(189, 22);
            this.userInput.TabIndex = 1;
            // 
            // userNae
            // 
            this.userNae.AutoSize = true;
            this.userNae.Location = new System.Drawing.Point(12, 44);
            this.userNae.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNae.Name = "userNae";
            this.userNae.Size = new System.Drawing.Size(77, 17);
            this.userNae.TabIndex = 50;
            this.userNae.Text = "Username:";
            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(97, 77);
            this.passInput.Margin = new System.Windows.Forms.Padding(4);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(189, 22);
            this.passInput.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 77);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(73, 17);
            this.nameLabel.TabIndex = 48;
            this.nameLabel.Text = "Password:";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(160, 180);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(125, 50);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Cancel";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 180);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(125, 50);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Location = new System.Drawing.Point(138, 4);
            this.noRadio.Margin = new System.Windows.Forms.Padding(4);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(47, 21);
            this.noRadio.TabIndex = 4;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Checked = true;
            this.yesRadio.Location = new System.Drawing.Point(4, 4);
            this.yesRadio.Margin = new System.Windows.Forms.Padding(4);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(53, 21);
            this.yesRadio.TabIndex = 3;
            this.yesRadio.TabStop = true;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(15, 118);
            this.activeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(50, 17);
            this.activeLabel.TabIndex = 54;
            this.activeLabel.Text = "Active:";
            // 
            // noAdmin
            // 
            this.noAdmin.AutoSize = true;
            this.noAdmin.Location = new System.Drawing.Point(138, 4);
            this.noAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.noAdmin.Name = "noAdmin";
            this.noAdmin.Size = new System.Drawing.Size(47, 21);
            this.noAdmin.TabIndex = 6;
            this.noAdmin.Text = "No";
            this.noAdmin.UseVisualStyleBackColor = true;
            // 
            // yesAdmin
            // 
            this.yesAdmin.AutoSize = true;
            this.yesAdmin.Checked = true;
            this.yesAdmin.Location = new System.Drawing.Point(4, 4);
            this.yesAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.yesAdmin.Name = "yesAdmin";
            this.yesAdmin.Size = new System.Drawing.Size(53, 21);
            this.yesAdmin.TabIndex = 5;
            this.yesAdmin.TabStop = true;
            this.yesAdmin.Text = "Yes";
            this.yesAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Admin:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.noRadio);
            this.panel1.Controls.Add(this.yesRadio);
            this.panel1.Location = new System.Drawing.Point(97, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 28);
            this.panel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.yesAdmin);
            this.panel2.Controls.Add(this.noAdmin);
            this.panel2.Location = new System.Drawing.Point(96, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 28);
            this.panel2.TabIndex = 61;
            // 
            // UserController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 239);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.userNae);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.formLabel);
            this.Name = "UserController";
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label userNae;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.RadioButton noAdmin;
        private System.Windows.Forms.RadioButton yesAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
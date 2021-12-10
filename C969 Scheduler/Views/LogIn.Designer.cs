
namespace C969_Scheduler
{
    partial class LogIn
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
            this.userInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.userLb = new System.Windows.Forms.Label();
            this.passLb = new System.Windows.Forms.Label();
            this.submitLb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(12, 29);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(318, 24);
            this.userInput.TabIndex = 0;
            // 
            // passInput
            // 
            this.passInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.Location = new System.Drawing.Point(12, 76);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(318, 24);
            this.passInput.TabIndex = 1;
            this.passInput.UseSystemPasswordChar = true;
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.Location = new System.Drawing.Point(12, 9);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(77, 17);
            this.userLb.TabIndex = 2;
            this.userLb.Text = "Username:";
            // 
            // passLb
            // 
            this.passLb.AutoSize = true;
            this.passLb.Location = new System.Drawing.Point(12, 56);
            this.passLb.Name = "passLb";
            this.passLb.Size = new System.Drawing.Size(73, 17);
            this.passLb.TabIndex = 3;
            this.passLb.Text = "Password:";
            // 
            // submitLb
            // 
            this.submitLb.Location = new System.Drawing.Point(12, 117);
            this.submitLb.Name = "submitLb";
            this.submitLb.Size = new System.Drawing.Size(317, 44);
            this.submitLb.TabIndex = 4;
            this.submitLb.Text = "Log In";
            this.submitLb.UseVisualStyleBackColor = true;
            this.submitLb.Click += new System.EventHandler(this.submitLb_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 173);
            this.Controls.Add(this.submitLb);
            this.Controls.Add(this.passLb);
            this.Controls.Add(this.userLb);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.userInput);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Label userLb;
        private System.Windows.Forms.Label passLb;
        private System.Windows.Forms.Button submitLb;
    }
}


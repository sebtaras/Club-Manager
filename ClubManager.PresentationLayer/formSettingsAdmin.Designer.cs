
namespace ClubManager.PresentationLayer
{
    partial class FormSettingsAdmin
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
            this.Cancel = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordInputNew = new System.Windows.Forms.TextBox();
            this.PasswordInputCurrent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Cancel.Location = new System.Drawing.Point(170, 182);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(148, 34);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // LogInButton
            // 
            this.LogInButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LogInButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LogInButton.Location = new System.Drawing.Point(12, 182);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(152, 34);
            this.LogInButton.TabIndex = 18;
            this.LogInButton.Text = "Confirm";
            this.LogInButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "New password";
            // 
            // PasswordInputNew
            // 
            this.PasswordInputNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordInputNew.Location = new System.Drawing.Point(13, 135);
            this.PasswordInputNew.Name = "PasswordInputNew";
            this.PasswordInputNew.Size = new System.Drawing.Size(305, 27);
            this.PasswordInputNew.TabIndex = 16;
            // 
            // PasswordInputCurrent
            // 
            this.PasswordInputCurrent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordInputCurrent.Location = new System.Drawing.Point(12, 83);
            this.PasswordInputCurrent.Name = "PasswordInputCurrent";
            this.PasswordInputCurrent.Size = new System.Drawing.Size(305, 27);
            this.PasswordInputCurrent.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Current password";
            // 
            // EmailInput
            // 
            this.EmailInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.EmailInput.Location = new System.Drawing.Point(12, 32);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(305, 27);
            this.EmailInput.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // formSettingsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 226);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordInputNew);
            this.Controls.Add(this.PasswordInputCurrent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label1);
            this.Name = "formSettingsAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formSettingsAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordInputNew;
        private System.Windows.Forms.TextBox PasswordInputCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label1;
    }
}
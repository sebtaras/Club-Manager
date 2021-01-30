
namespace ClubManager.PresentationLayer
{
    partial class FormLogIn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.GoToRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(276, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // EmailInput
            // 
            this.EmailInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.EmailInput.Location = new System.Drawing.Point(280, 113);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(241, 27);
            this.EmailInput.TabIndex = 1;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordInput.Location = new System.Drawing.Point(281, 195);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(241, 27);
            this.PasswordInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(277, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // LogInButton
            // 
            this.LogInButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LogInButton.Location = new System.Drawing.Point(280, 261);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(241, 34);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInUser);
            // 
            // GoToRegister
            // 
            this.GoToRegister.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.GoToRegister.Location = new System.Drawing.Point(281, 390);
            this.GoToRegister.Name = "GoToRegister";
            this.GoToRegister.Size = new System.Drawing.Size(241, 34);
            this.GoToRegister.TabIndex = 5;
            this.GoToRegister.Text = "Register instead";
            this.GoToRegister.UseVisualStyleBackColor = true;
            this.GoToRegister.Click += new System.EventHandler(this.SwitchToRegister);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(278, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Not registered?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(296, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Club Manager";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GoToRegister);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label1);
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Manager - Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button GoToRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
    }
}
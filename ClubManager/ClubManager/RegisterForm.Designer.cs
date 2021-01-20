
namespace ClubManager
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        class ComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }
        }
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
            this.label4 = new System.Windows.Forms.Label();
            this.JumpToLogin = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.PlayerRadioButton = new System.Windows.Forms.RadioButton();
            this.TrainerRadioButton = new System.Windows.Forms.RadioButton();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(261, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Already registered?";
            // 
            // JumpToLogin
            // 
            this.JumpToLogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JumpToLogin.Location = new System.Drawing.Point(261, 385);
            this.JumpToLogin.Name = "JumpToLogin";
            this.JumpToLogin.Size = new System.Drawing.Size(263, 32);
            this.JumpToLogin.TabIndex = 14;
            this.JumpToLogin.Text = "Log in instead";
            this.JumpToLogin.UseVisualStyleBackColor = true;
            this.JumpToLogin.Click += new System.EventHandler(this.JumpToLogin_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.SystemColors.Control;
            this.RegisterButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterButton.Location = new System.Drawing.Point(261, 316);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(263, 32);
            this.RegisterButton.TabIndex = 13;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(261, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(261, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordInput.Location = new System.Drawing.Point(261, 171);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(263, 24);
            this.PasswordInput.TabIndex = 10;
            // 
            // EmailInput
            // 
            this.EmailInput.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailInput.Location = new System.Drawing.Point(261, 117);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(263, 24);
            this.EmailInput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(291, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Club Manager";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoleLabel.ForeColor = System.Drawing.Color.White;
            this.RoleLabel.Location = new System.Drawing.Point(261, 214);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(42, 19);
            this.RoleLabel.TabIndex = 17;
            this.RoleLabel.Text = "Role";
            // 
            // PlayerRadioButton
            // 
            this.PlayerRadioButton.AutoSize = true;
            this.PlayerRadioButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerRadioButton.ForeColor = System.Drawing.Color.White;
            this.PlayerRadioButton.Location = new System.Drawing.Point(352, 214);
            this.PlayerRadioButton.Name = "PlayerRadioButton";
            this.PlayerRadioButton.Size = new System.Drawing.Size(69, 23);
            this.PlayerRadioButton.TabIndex = 18;
            this.PlayerRadioButton.TabStop = true;
            this.PlayerRadioButton.Text = "Player";
            this.PlayerRadioButton.UseVisualStyleBackColor = true;
            this.PlayerRadioButton.CheckedChanged += new System.EventHandler(this.PlayerRadioButton_CheckedChanged);
            // 
            // TrainerRadioButton
            // 
            this.TrainerRadioButton.AutoSize = true;
            this.TrainerRadioButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrainerRadioButton.ForeColor = System.Drawing.Color.White;
            this.TrainerRadioButton.Location = new System.Drawing.Point(453, 214);
            this.TrainerRadioButton.Name = "TrainerRadioButton";
            this.TrainerRadioButton.Size = new System.Drawing.Size(71, 23);
            this.TrainerRadioButton.TabIndex = 19;
            this.TrainerRadioButton.TabStop = true;
            this.TrainerRadioButton.Text = "Trainer";
            this.TrainerRadioButton.UseVisualStyleBackColor = true;
            this.TrainerRadioButton.CheckedChanged += new System.EventHandler(this.TrainerRadioButton_CheckedChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgeLabel.ForeColor = System.Drawing.Color.White;
            this.AgeLabel.Location = new System.Drawing.Point(261, 246);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(42, 19);
            this.AgeLabel.TabIndex = 20;
            this.AgeLabel.Text = "Age";
            this.AgeLabel.Visible = false;
            // 
            // AgeInput
            // 
            this.AgeInput.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeInput.Location = new System.Drawing.Point(261, 268);
            this.AgeInput.Name = "AgeInput";
            this.AgeInput.Size = new System.Drawing.Size(263, 24);
            this.AgeInput.TabIndex = 21;
            this.AgeInput.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.AgeInput);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.TrainerRadioButton);
            this.Controls.Add(this.PlayerRadioButton);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JumpToLogin);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button JumpToLogin;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.RadioButton PlayerRadioButton;
        private System.Windows.Forms.RadioButton TrainerRadioButton;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeInput;
    }
}
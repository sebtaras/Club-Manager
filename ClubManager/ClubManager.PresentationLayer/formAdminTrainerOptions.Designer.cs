
namespace ClubManager.PresentationLayer
{
    partial class formAdminTrainerOptions
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
            this.Teams = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.Label();
            this.TeamInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Teams
            // 
            this.Teams.AutoSize = true;
            this.Teams.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Teams.Location = new System.Drawing.Point(8, 28);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(59, 19);
            this.Teams.TabIndex = 19;
            this.Teams.Text = "Teams";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CancelButton.Location = new System.Drawing.Point(188, 170);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(173, 34);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(12, 170);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(170, 34);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Delete player";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // RemoveButton
            // 
            this.RemoveButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.RemoveButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.RemoveButton.Location = new System.Drawing.Point(188, 130);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(173, 34);
            this.RemoveButton.TabIndex = 16;
            this.RemoveButton.Text = "Remove from team";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.AddButton.Location = new System.Drawing.Point(12, 130);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(170, 34);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add to team ";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FullName.Location = new System.Drawing.Point(8, 9);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(84, 19);
            this.FullName.TabIndex = 12;
            this.FullName.Text = "FullName";
            // 
            // TeamInput
            // 
            this.TeamInput.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TeamInput.Location = new System.Drawing.Point(12, 100);
            this.TeamInput.Name = "TeamInput";
            this.TeamInput.Size = new System.Drawing.Size(349, 24);
            this.TeamInput.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter team name";
            // 
            // formAdminTrainerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamInput);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FullName);
            this.Name = "formAdminTrainerOptions";
            this.Text = "formAdminTrainerOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Teams;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.TextBox TeamInput;
        private System.Windows.Forms.Label label1;
    }
}

namespace ClubManager.PresentationLayer
{
    partial class formTrainerDeleteTraining
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
            this.TrainingTime = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrainingTime
            // 
            this.TrainingTime.AutoSize = true;
            this.TrainingTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.TrainingTime.Location = new System.Drawing.Point(3, 28);
            this.TrainingTime.Name = "TrainingTime";
            this.TrainingTime.Size = new System.Drawing.Size(112, 19);
            this.TrainingTime.TabIndex = 19;
            this.TrainingTime.Text = "Training Time";
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.TeamName.Location = new System.Drawing.Point(3, 9);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(102, 19);
            this.TeamName.TabIndex = 16;
            this.TeamName.Text = "TeamName";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.Location = new System.Drawing.Point(141, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(7, 62);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(129, 34);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete training";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // formTrainerDeleteTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 102);
            this.Controls.Add(this.TrainingTime);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteButton);
            this.Name = "formTrainerDeleteTraining";
            this.Text = "formTrainerDeleteTraining";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TrainingTime;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteButton;
    }
}
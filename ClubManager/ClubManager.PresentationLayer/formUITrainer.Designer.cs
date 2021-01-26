
namespace ClubManager.PresentationLayer
{
    partial class formUITrainer
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
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MonthYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Paid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TrainingList = new System.Windows.Forms.ListView();
            this.Trainer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.CreateNewTrainingButton = new System.Windows.Forms.Button();
            this.VerificationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(539, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Players";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MonthYear,
            this.Paid});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(543, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(229, 370);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MonthYear
            // 
            this.MonthYear.Text = "Full Name";
            this.MonthYear.Width = 145;
            // 
            // Paid
            // 
            this.Paid.Text = "Age";
            this.Paid.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trainings";
            // 
            // TrainingList
            // 
            this.TrainingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Trainer,
            this.StartDate,
            this.EndDate});
            this.TrainingList.HideSelection = false;
            this.TrainingList.Location = new System.Drawing.Point(12, 32);
            this.TrainingList.Name = "TrainingList";
            this.TrainingList.Size = new System.Drawing.Size(525, 370);
            this.TrainingList.TabIndex = 7;
            this.TrainingList.UseCompatibleStateImageBehavior = false;
            this.TrainingList.View = System.Windows.Forms.View.Details;
            // 
            // Trainer
            // 
            this.Trainer.Text = "Trainer";
            this.Trainer.Width = 80;
            // 
            // StartDate
            // 
            this.StartDate.Text = "Start Time";
            this.StartDate.Width = 220;
            // 
            // EndDate
            // 
            this.EndDate.Text = "End Time";
            this.EndDate.Width = 220;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(543, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LogOut);
            // 
            // CreateNewTrainingButton
            // 
            this.CreateNewTrainingButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CreateNewTrainingButton.FlatAppearance.BorderSize = 0;
            this.CreateNewTrainingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewTrainingButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewTrainingButton.ForeColor = System.Drawing.Color.White;
            this.CreateNewTrainingButton.Location = new System.Drawing.Point(12, 408);
            this.CreateNewTrainingButton.Name = "CreateNewTrainingButton";
            this.CreateNewTrainingButton.Size = new System.Drawing.Size(525, 42);
            this.CreateNewTrainingButton.TabIndex = 11;
            this.CreateNewTrainingButton.Text = "Create new training";
            this.CreateNewTrainingButton.UseVisualStyleBackColor = false;
            this.CreateNewTrainingButton.Visible = false;
            // 
            // VerificationLabel
            // 
            this.VerificationLabel.AutoSize = true;
            this.VerificationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.VerificationLabel.Location = new System.Drawing.Point(288, 420);
            this.VerificationLabel.Name = "VerificationLabel";
            this.VerificationLabel.Size = new System.Drawing.Size(249, 19);
            this.VerificationLabel.TabIndex = 12;
            this.VerificationLabel.Text = "Account is pending verification";
            // 
            // formUITrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.VerificationLabel);
            this.Controls.Add(this.CreateNewTrainingButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrainingList);
            this.Controls.Add(this.button1);
            this.Name = "formUITrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUITrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MonthYear;
        private System.Windows.Forms.ColumnHeader Paid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView TrainingList;
        private System.Windows.Forms.ColumnHeader Trainer;
        private System.Windows.Forms.ColumnHeader StartDate;
        private System.Windows.Forms.ColumnHeader EndDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CreateNewTrainingButton;
        private System.Windows.Forms.Label VerificationLabel;
    }
}
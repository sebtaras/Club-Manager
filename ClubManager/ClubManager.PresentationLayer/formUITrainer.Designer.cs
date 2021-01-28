
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
            this.PlayerList = new System.Windows.Forms.ListView();
            this.playerFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TrainingList = new System.Windows.Forms.ListView();
            this.trainingId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.VerificationLabel = new System.Windows.Forms.Label();
            this.CreateTransactionsButon = new System.Windows.Forms.Button();
            this.CreateTrainingButton = new System.Windows.Forms.Button();
            this.TeamName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(478, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Players";
            // 
            // PlayerList
            // 
            this.PlayerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerId,
            this.playerFullName,
            this.Age,
            this.teamFullName});
            this.PlayerList.HideSelection = false;
            this.PlayerList.Location = new System.Drawing.Point(480, 32);
            this.PlayerList.Name = "PlayerList";
            this.PlayerList.Size = new System.Drawing.Size(292, 370);
            this.PlayerList.TabIndex = 9;
            this.PlayerList.UseCompatibleStateImageBehavior = false;
            this.PlayerList.View = System.Windows.Forms.View.Details;
            // 
            // playerFullName
            // 
            this.playerFullName.Text = "Name";
            this.playerFullName.Width = 120;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 40;
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
            this.trainingId,
            this.TeamName,
            this.StartDate,
            this.EndDate});
            this.TrainingList.HideSelection = false;
            this.TrainingList.Location = new System.Drawing.Point(12, 32);
            this.TrainingList.Name = "TrainingList";
            this.TrainingList.Size = new System.Drawing.Size(462, 370);
            this.TrainingList.TabIndex = 7;
            this.TrainingList.UseCompatibleStateImageBehavior = false;
            this.TrainingList.View = System.Windows.Forms.View.Details;
            // 
            // trainingId
            // 
            this.trainingId.Text = "ID";
            this.trainingId.Width = 30;
            // 
            // StartDate
            // 
            this.StartDate.Text = "Start Time";
            this.StartDate.Width = 170;
            // 
            // EndDate
            // 
            this.EndDate.Text = "End Time";
            this.EndDate.Width = 170;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(480, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LogOut);
            // 
            // VerificationLabel
            // 
            this.VerificationLabel.AutoSize = true;
            this.VerificationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.VerificationLabel.Location = new System.Drawing.Point(225, 416);
            this.VerificationLabel.Name = "VerificationLabel";
            this.VerificationLabel.Size = new System.Drawing.Size(249, 19);
            this.VerificationLabel.TabIndex = 12;
            this.VerificationLabel.Text = "Account is pending verification";
            // 
            // CreateTransactionsButon
            // 
            this.CreateTransactionsButon.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CreateTransactionsButon.Location = new System.Drawing.Point(12, 407);
            this.CreateTransactionsButon.Name = "CreateTransactionsButon";
            this.CreateTransactionsButon.Size = new System.Drawing.Size(168, 42);
            this.CreateTransactionsButon.TabIndex = 16;
            this.CreateTransactionsButon.Text = "Settings";
            this.CreateTransactionsButon.UseVisualStyleBackColor = true;
            this.CreateTransactionsButon.Click += new System.EventHandler(this.ShowUserSettings);
            // 
            // CreateTrainingButton
            // 
            this.CreateTrainingButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CreateTrainingButton.Location = new System.Drawing.Point(306, 407);
            this.CreateTrainingButton.Name = "CreateTrainingButton";
            this.CreateTrainingButton.Size = new System.Drawing.Size(168, 41);
            this.CreateTrainingButton.TabIndex = 18;
            this.CreateTrainingButton.Text = "Create training";
            this.CreateTrainingButton.UseVisualStyleBackColor = true;
            this.CreateTrainingButton.Click += new System.EventHandler(this.CreateTraining);
            // 
            // TeamName
            // 
            this.TeamName.Text = "Team";
            this.TeamName.Width = 80;
            // 
            // playerId
            // 
            this.playerId.Text = "ID";
            this.playerId.Width = 30;
            // 
            // teamFullName
            // 
            this.teamFullName.Text = "Team";
            this.teamFullName.Width = 80;
            // 
            // formUITrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 456);
            this.Controls.Add(this.CreateTrainingButton);
            this.Controls.Add(this.CreateTransactionsButon);
            this.Controls.Add(this.VerificationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerList);
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
        private System.Windows.Forms.ListView PlayerList;
        private System.Windows.Forms.ColumnHeader playerFullName;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView TrainingList;
        private System.Windows.Forms.ColumnHeader trainingId;
        private System.Windows.Forms.ColumnHeader StartDate;
        private System.Windows.Forms.ColumnHeader EndDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label VerificationLabel;
        private System.Windows.Forms.Button CreateTransactionsButon;
        private System.Windows.Forms.Button CreateTrainingButton;
        private System.Windows.Forms.ColumnHeader TeamName;
        private System.Windows.Forms.ColumnHeader playerId;
        private System.Windows.Forms.ColumnHeader teamFullName;
    }
}
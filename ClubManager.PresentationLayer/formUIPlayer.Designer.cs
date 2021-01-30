
namespace ClubManager.PresentationLayer
{
    partial class FormUIPlayer
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
            this.button1 = new System.Windows.Forms.Button();
            this.TrainingList = new System.Windows.Forms.ListView();
            this.trainingID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trainer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TransactionList = new System.Windows.Forms.ListView();
            this.transactionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Month = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Paid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.VerificationLabel = new System.Windows.Forms.Label();
            this.CreateTransactionsButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(597, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LogOut);
            // 
            // TrainingList
            // 
            this.TrainingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trainingID,
            this.Trainer,
            this.StartDate,
            this.EndDate});
            this.TrainingList.HideSelection = false;
            this.TrainingList.Location = new System.Drawing.Point(12, 31);
            this.TrainingList.Name = "TrainingList";
            this.TrainingList.Size = new System.Drawing.Size(579, 370);
            this.TrainingList.TabIndex = 2;
            this.TrainingList.UseCompatibleStateImageBehavior = false;
            this.TrainingList.View = System.Windows.Forms.View.Details;
            // 
            // trainingID
            // 
            this.trainingID.Text = "ID";
            this.trainingID.Width = 30;
            // 
            // Trainer
            // 
            this.Trainer.Text = "Trainer";
            this.Trainer.Width = 130;
            // 
            // StartDate
            // 
            this.StartDate.Text = "Start Time";
            this.StartDate.Width = 200;
            // 
            // EndDate
            // 
            this.EndDate.Text = "End Time";
            this.EndDate.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trainings";
            // 
            // TransactionList
            // 
            this.TransactionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.transactionID,
            this.Year,
            this.Month,
            this.Amount,
            this.Paid});
            this.TransactionList.HideSelection = false;
            this.TransactionList.Location = new System.Drawing.Point(597, 31);
            this.TransactionList.Name = "TransactionList";
            this.TransactionList.Size = new System.Drawing.Size(248, 370);
            this.TransactionList.TabIndex = 4;
            this.TransactionList.UseCompatibleStateImageBehavior = false;
            this.TransactionList.View = System.Windows.Forms.View.Details;
            // 
            // transactionID
            // 
            this.transactionID.Text = "ID";
            this.transactionID.Width = 30;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 50;
            // 
            // Month
            // 
            this.Month.Text = "Month";
            this.Month.Width = 50;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 65;
            // 
            // Paid
            // 
            this.Paid.Text = "Paid ";
            this.Paid.Width = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(593, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Membership fees";
            // 
            // VerificationLabel
            // 
            this.VerificationLabel.AutoSize = true;
            this.VerificationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.VerificationLabel.Location = new System.Drawing.Point(342, 419);
            this.VerificationLabel.Name = "VerificationLabel";
            this.VerificationLabel.Size = new System.Drawing.Size(249, 19);
            this.VerificationLabel.TabIndex = 6;
            this.VerificationLabel.Text = "Account is pending verification";
            // 
            // CreateTransactionsButon
            // 
            this.CreateTransactionsButon.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CreateTransactionsButon.Location = new System.Drawing.Point(12, 409);
            this.CreateTransactionsButon.Name = "CreateTransactionsButon";
            this.CreateTransactionsButon.Size = new System.Drawing.Size(168, 42);
            this.CreateTransactionsButon.TabIndex = 15;
            this.CreateTransactionsButon.Text = "Settings";
            this.CreateTransactionsButon.UseVisualStyleBackColor = true;
            this.CreateTransactionsButon.Click += new System.EventHandler(this.ShowUserSettings);
            // 
            // FormUIPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 461);
            this.Controls.Add(this.CreateTransactionsButon);
            this.Controls.Add(this.VerificationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransactionList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrainingList);
            this.Controls.Add(this.button1);
            this.Name = "FormUIPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClubManager - Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView TrainingList;
        private System.Windows.Forms.ColumnHeader Trainer;
        private System.Windows.Forms.ColumnHeader StartDate;
        private System.Windows.Forms.ColumnHeader EndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView TransactionList;
        private System.Windows.Forms.ColumnHeader Month;
        private System.Windows.Forms.ColumnHeader Paid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.Label VerificationLabel;
        private System.Windows.Forms.ColumnHeader trainingID;
        private System.Windows.Forms.ColumnHeader transactionID;
        private System.Windows.Forms.Button CreateTransactionsButon;
    }
}
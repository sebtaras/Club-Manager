
namespace ClubManager.PresentationLayer
{
    partial class FormAdminPlayerOptions
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
            this.FullName = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CurrentTeam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TransactionList = new System.Windows.Forms.ListView();
            this.transactionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Month = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Paid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FullName.Location = new System.Drawing.Point(8, 9);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(84, 19);
            this.FullName.TabIndex = 1;
            this.FullName.Text = "FullName";
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.AddButton.Location = new System.Drawing.Point(12, 101);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(378, 34);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add player to team ";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Age.Location = new System.Drawing.Point(8, 28);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(42, 19);
            this.Age.TabIndex = 6;
            this.Age.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "*Will automatically add to team in player\'s age range";
            // 
            // RemoveButton
            // 
            this.RemoveButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.RemoveButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.RemoveButton.Location = new System.Drawing.Point(12, 141);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(378, 34);
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.Text = "Remove player from current team";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(12, 399);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(236, 34);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete player";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CancelButton.Location = new System.Drawing.Point(254, 399);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(136, 34);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // CurrentTeam
            // 
            this.CurrentTeam.AutoSize = true;
            this.CurrentTeam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.CurrentTeam.Location = new System.Drawing.Point(8, 47);
            this.CurrentTeam.Name = "CurrentTeam";
            this.CurrentTeam.Size = new System.Drawing.Size(53, 19);
            this.CurrentTeam.TabIndex = 11;
            this.CurrentTeam.Text = "Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Transaction history";
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
            this.TransactionList.Location = new System.Drawing.Point(12, 200);
            this.TransactionList.Name = "TransactionList";
            this.TransactionList.Size = new System.Drawing.Size(377, 193);
            this.TransactionList.TabIndex = 13;
            this.TransactionList.UseCompatibleStateImageBehavior = false;
            this.TransactionList.View = System.Windows.Forms.View.Details;
            this.TransactionList.DoubleClick += new System.EventHandler(this.AdminTransactionOptions);
            // 
            // transactionID
            // 
            this.transactionID.Text = "ID";
            this.transactionID.Width = 30;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 80;
            // 
            // Month
            // 
            this.Month.Text = "Month";
            this.Month.Width = 80;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 80;
            // 
            // Paid
            // 
            this.Paid.Text = "Paid ";
            this.Paid.Width = 80;
            // 
            // formAdminPlayerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 445);
            this.Controls.Add(this.TransactionList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentTeam);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FullName);
            this.Name = "formAdminPlayerOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formAdminPlayerOptions";
            this.DoubleClick += new System.EventHandler(this.AdminTransactionOptions);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label CurrentTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView TransactionList;
        private System.Windows.Forms.ColumnHeader transactionID;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Month;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Paid;
    }
}
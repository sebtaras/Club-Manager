
namespace ClubManager.PresentationLayer
{
    partial class FormAdminTransactionOptions
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
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LabelMonth = new System.Windows.Forms.Label();
            this.LabelPaid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.AddButton.Location = new System.Drawing.Point(7, 92);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(235, 34);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Change paid status";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(7, 132);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(235, 34);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete transaction";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.Location = new System.Drawing.Point(7, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LabelName.Location = new System.Drawing.Point(3, 3);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(106, 19);
            this.LabelName.TabIndex = 9;
            this.LabelName.Text = "PlayerName";
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LabelYear.Location = new System.Drawing.Point(3, 22);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(45, 19);
            this.LabelYear.TabIndex = 10;
            this.LabelYear.Text = "Year";
            // 
            // LabelMonth
            // 
            this.LabelMonth.AutoSize = true;
            this.LabelMonth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LabelMonth.Location = new System.Drawing.Point(3, 41);
            this.LabelMonth.Name = "LabelMonth";
            this.LabelMonth.Size = new System.Drawing.Size(57, 19);
            this.LabelMonth.TabIndex = 11;
            this.LabelMonth.Text = "Month";
            // 
            // LabelPaid
            // 
            this.LabelPaid.AutoSize = true;
            this.LabelPaid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LabelPaid.Location = new System.Drawing.Point(3, 60);
            this.LabelPaid.Name = "LabelPaid";
            this.LabelPaid.Size = new System.Drawing.Size(44, 19);
            this.LabelPaid.TabIndex = 12;
            this.LabelPaid.Text = "Paid";
            // 
            // FormAdminTransactionOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 214);
            this.Controls.Add(this.LabelPaid);
            this.Controls.Add(this.LabelMonth);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Name = "FormAdminTransactionOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LabelMonth;
        private System.Windows.Forms.Label LabelPaid;
    }
}
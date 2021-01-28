
namespace ClubManager.PresentationLayer
{
    partial class formAdminCreateTransactions
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
            this.AddButton = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YearCombo = new System.Windows.Forms.ComboBox();
            this.MonthCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.AddButton.Location = new System.Drawing.Point(7, 58);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(158, 34);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Create Transactions";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FullName.Location = new System.Drawing.Point(3, 5);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(45, 19);
            this.FullName.TabIndex = 7;
            this.FullName.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(167, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Month";
            // 
            // YearCombo
            // 
            this.YearCombo.DataSource = this.comboItemBindingSource;
            this.YearCombo.DisplayMember = "value";
            this.YearCombo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.YearCombo.FormattingEnabled = true;
            this.YearCombo.Location = new System.Drawing.Point(7, 27);
            this.YearCombo.Name = "YearCombo";
            this.YearCombo.Size = new System.Drawing.Size(158, 25);
            this.YearCombo.TabIndex = 1;
            this.YearCombo.ValueMember = "value";
            // 
            // MonthCombo
            // 
            this.MonthCombo.DataSource = this.comboItemBindingSource;
            this.MonthCombo.DisplayMember = "value";
            this.MonthCombo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.MonthCombo.FormattingEnabled = true;
            this.MonthCombo.Location = new System.Drawing.Point(171, 27);
            this.MonthCombo.Name = "MonthCombo";
            this.MonthCombo.Size = new System.Drawing.Size(158, 25);
            this.MonthCombo.TabIndex = 2;
            this.MonthCombo.ValueMember = "value";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.Location = new System.Drawing.Point(171, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboItemBindingSource
            // 
            this.comboItemBindingSource.DataSource = typeof(ClubManager.BaseLib.ComboItem);
            // 
            // formAdminCreateTransactionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 102);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MonthCombo);
            this.Controls.Add(this.YearCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.AddButton);
            this.Name = "formAdminCreateTransactionsView";
            this.Text = "formCreateTransactionsView";
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox YearCombo;
        private System.Windows.Forms.ComboBox MonthCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource comboItemBindingSource;
    }
}

namespace ClubManager.PresentationLayer
{
    partial class formUIAdmin
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
            this.TeamList = new System.Windows.Forms.ListView();
            this.TeamName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgeRange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trainer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterRequests = new System.Windows.Forms.ListView();
            this.Person = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(366, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Teams";
            // 
            // TeamList
            // 
            this.TeamList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TeamName,
            this.AgeRange,
            this.Trainer});
            this.TeamList.HideSelection = false;
            this.TeamList.Location = new System.Drawing.Point(370, 32);
            this.TeamList.Name = "TeamList";
            this.TeamList.Size = new System.Drawing.Size(303, 370);
            this.TeamList.TabIndex = 9;
            this.TeamList.UseCompatibleStateImageBehavior = false;
            this.TeamList.View = System.Windows.Forms.View.Details;
            // 
            // TeamName
            // 
            this.TeamName.Text = "Team Name";
            this.TeamName.Width = 100;
            // 
            // AgeRange
            // 
            this.AgeRange.Text = "Age range";
            this.AgeRange.Width = 85;
            // 
            // Trainer
            // 
            this.Trainer.Text = "Trainer";
            this.Trainer.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Register requests";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(610, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LogOut);
            // 
            // RegisterRequests
            // 
            this.RegisterRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Person,
            this.Email,
            this.Role,
            this.Age});
            this.RegisterRequests.HideSelection = false;
            this.RegisterRequests.Location = new System.Drawing.Point(12, 32);
            this.RegisterRequests.Name = "RegisterRequests";
            this.RegisterRequests.Size = new System.Drawing.Size(352, 370);
            this.RegisterRequests.TabIndex = 11;
            this.RegisterRequests.UseCompatibleStateImageBehavior = false;
            this.RegisterRequests.View = System.Windows.Forms.View.Details;
            this.RegisterRequests.DoubleClick += new System.EventHandler(this.VerifyUser);
            // 
            // Person
            // 
            this.Person.Name = "BOLAN";
            this.Person.Text = "Name";
            this.Person.Width = 105;
            // 
            // Role
            // 
            this.Role.Text = "Role";
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 40;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 140;
            // 
            // formUIAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.RegisterRequests);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TeamList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "formUIAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUIAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView TeamList;
        private System.Windows.Forms.ColumnHeader TeamName;
        private System.Windows.Forms.ColumnHeader AgeRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView RegisterRequests;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Trainer;
        private System.Windows.Forms.ColumnHeader Info;
        private System.Windows.Forms.ColumnHeader Person;
        private System.Windows.Forms.ColumnHeader Email;
    }
}
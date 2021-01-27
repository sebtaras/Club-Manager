
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
            this.Trainers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterRequests = new System.Windows.Forms.ListView();
            this.BOLAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PlayerList = new System.Windows.Forms.ListView();
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Team = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.playerEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrainerList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1049, 10);
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
            this.Trainers});
            this.TeamList.HideSelection = false;
            this.TeamList.Location = new System.Drawing.Point(1049, 32);
            this.TeamList.Name = "TeamList";
            this.TeamList.Size = new System.Drawing.Size(338, 450);
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
            this.AgeRange.Width = 70;
            // 
            // Trainers
            // 
            this.Trainers.Text = "Trainers";
            this.Trainers.Width = 150;
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
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1223, 488);
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
            this.BOLAN,
            this.Email,
            this.Role,
            this.Age});
            this.RegisterRequests.HideSelection = false;
            this.RegisterRequests.Location = new System.Drawing.Point(12, 32);
            this.RegisterRequests.Name = "RegisterRequests";
            this.RegisterRequests.Size = new System.Drawing.Size(352, 450);
            this.RegisterRequests.TabIndex = 11;
            this.RegisterRequests.UseCompatibleStateImageBehavior = false;
            this.RegisterRequests.View = System.Windows.Forms.View.Details;
            this.RegisterRequests.DoubleClick += new System.EventHandler(this.VerifyUser);
            // 
            // BOLAN
            // 
            this.BOLAN.Name = "BOLAN";
            this.BOLAN.Text = "Name";
            this.BOLAN.Width = 105;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 140;
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
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.RegisterButton.Location = new System.Drawing.Point(1053, 488);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(164, 42);
            this.RegisterButton.TabIndex = 14;
            this.RegisterButton.Text = "Create Transactions";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // PlayerList
            // 
            this.PlayerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Player,
            this.playerEmail,
            this.Team,
            this.PlayerAge});
            this.PlayerList.HideSelection = false;
            this.PlayerList.Location = new System.Drawing.Point(369, 32);
            this.PlayerList.Name = "PlayerList";
            this.PlayerList.Size = new System.Drawing.Size(350, 450);
            this.PlayerList.TabIndex = 15;
            this.PlayerList.UseCompatibleStateImageBehavior = false;
            this.PlayerList.View = System.Windows.Forms.View.Details;
            this.PlayerList.DoubleClick += new System.EventHandler(this.AdminPlayerOptionsForm);
            // 
            // Player
            // 
            this.Player.Text = "Name";
            this.Player.Width = 120;
            // 
            // Team
            // 
            this.Team.Text = "Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(365, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Players";
            // 
            // playerEmail
            // 
            this.playerEmail.Text = "Email";
            this.playerEmail.Width = 100;
            // 
            // TrainerList
            // 
            this.TrainerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.TrainerList.HideSelection = false;
            this.TrainerList.Location = new System.Drawing.Point(725, 32);
            this.TrainerList.Name = "TrainerList";
            this.TrainerList.Size = new System.Drawing.Size(318, 450);
            this.TrainerList.TabIndex = 17;
            this.TrainerList.UseCompatibleStateImageBehavior = false;
            this.TrainerList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(721, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Trainers";
            // 
            // PlayerAge
            // 
            this.PlayerAge.Text = "Age";
            // 
            // formUIAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 537);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TrainerList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayerList);
            this.Controls.Add(this.RegisterButton);
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
        private System.Windows.Forms.ColumnHeader Trainers;
        private System.Windows.Forms.ColumnHeader Info;
        private System.Windows.Forms.ColumnHeader Person;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader BOLAN;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.ListView PlayerList;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.ColumnHeader playerEmail;
        private System.Windows.Forms.ColumnHeader Team;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader PlayerAge;
        private System.Windows.Forms.ListView TrainerList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
    }
}
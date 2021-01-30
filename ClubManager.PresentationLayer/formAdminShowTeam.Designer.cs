
namespace ClubManager.PresentationLayer
{
    partial class FormAdminShowTeam
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
            this.PlayerList = new System.Windows.Forms.ListView();
            this.playerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoneButton = new System.Windows.Forms.Button();
            this.TeamName = new System.Windows.Forms.Label();
            this.TrainerList = new System.Windows.Forms.ListView();
            this.trainerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayerList
            // 
            this.PlayerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerId,
            this.Player,
            this.playerEmail,
            this.PlayerAge});
            this.PlayerList.HideSelection = false;
            this.PlayerList.Location = new System.Drawing.Point(7, 168);
            this.PlayerList.Name = "PlayerList";
            this.PlayerList.Size = new System.Drawing.Size(340, 242);
            this.PlayerList.TabIndex = 16;
            this.PlayerList.UseCompatibleStateImageBehavior = false;
            this.PlayerList.View = System.Windows.Forms.View.Details;
            // 
            // playerId
            // 
            this.playerId.Text = "ID";
            this.playerId.Width = 35;
            // 
            // Player
            // 
            this.Player.Text = "Name";
            this.Player.Width = 120;
            // 
            // playerEmail
            // 
            this.playerEmail.Text = "Email";
            this.playerEmail.Width = 140;
            // 
            // PlayerAge
            // 
            this.PlayerAge.Text = "Age";
            this.PlayerAge.Width = 40;
            // 
            // DoneButton
            // 
            this.DoneButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DoneButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.DoneButton.Location = new System.Drawing.Point(7, 416);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(340, 34);
            this.DoneButton.TabIndex = 17;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.TeamName.Location = new System.Drawing.Point(3, 9);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(102, 19);
            this.TeamName.TabIndex = 18;
            this.TeamName.Text = "TeamName";
            // 
            // TrainerList
            // 
            this.TrainerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trainerId,
            this.columnHeader1,
            this.columnHeader2});
            this.TrainerList.HideSelection = false;
            this.TrainerList.Location = new System.Drawing.Point(7, 69);
            this.TrainerList.Name = "TrainerList";
            this.TrainerList.Size = new System.Drawing.Size(340, 74);
            this.TrainerList.TabIndex = 19;
            this.TrainerList.UseCompatibleStateImageBehavior = false;
            this.TrainerList.View = System.Windows.Forms.View.Details;
            // 
            // trainerId
            // 
            this.trainerId.Text = "ID";
            this.trainerId.Width = 35;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Trainers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Players";
            // 
            // formAdminShowTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrainerList);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.PlayerList);
            this.Name = "formAdminShowTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formAdminshowTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PlayerList;
        private System.Windows.Forms.ColumnHeader playerId;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.ColumnHeader playerEmail;
        private System.Windows.Forms.ColumnHeader PlayerAge;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.ListView TrainerList;
        private System.Windows.Forms.ColumnHeader trainerId;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
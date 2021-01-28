
namespace ClubManager.PresentationLayer
{
    partial class formAdminTrainerOptions
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
            this.Teams = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TeamNameAdd = new System.Windows.Forms.ComboBox();
            this.comboItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TeamNameRemove = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Teams
            // 
            this.Teams.AutoSize = true;
            this.Teams.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Teams.Location = new System.Drawing.Point(5, 24);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(59, 19);
            this.Teams.TabIndex = 19;
            this.Teams.Text = "Teams";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CancelButton.Location = new System.Drawing.Point(185, 272);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(173, 34);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(9, 272);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(170, 34);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete trainer";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // RemoveButton
            // 
            this.RemoveButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.RemoveButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.RemoveButton.Location = new System.Drawing.Point(9, 232);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(349, 34);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove trainer from team";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.AddButton.Location = new System.Drawing.Point(9, 119);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(349, 34);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add trainer to team ";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FullName.Location = new System.Drawing.Point(5, 5);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(84, 19);
            this.FullName.TabIndex = 12;
            this.FullName.Text = "FullName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(5, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Choose team to add to";
            // 
            // TeamNameAdd
            // 
            this.TeamNameAdd.DataSource = this.comboItemBindingSource;
            this.TeamNameAdd.DisplayMember = "value";
            this.TeamNameAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TeamNameAdd.FormattingEnabled = true;
            this.TeamNameAdd.Location = new System.Drawing.Point(9, 89);
            this.TeamNameAdd.Name = "TeamNameAdd";
            this.TeamNameAdd.Size = new System.Drawing.Size(349, 25);
            this.TeamNameAdd.TabIndex = 22;
            this.TeamNameAdd.ValueMember = "value";
            // 
            // comboItemBindingSource
            // 
            this.comboItemBindingSource.DataSource = typeof(ClubManager.BaseLib.ComboItem);
            // 
            // TeamNameRemove
            // 
            this.TeamNameRemove.DataSource = this.comboItemBindingSource;
            this.TeamNameRemove.DisplayMember = "value";
            this.TeamNameRemove.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TeamNameRemove.FormattingEnabled = true;
            this.TeamNameRemove.Location = new System.Drawing.Point(9, 200);
            this.TeamNameRemove.Name = "TeamNameRemove";
            this.TeamNameRemove.Size = new System.Drawing.Size(349, 25);
            this.TeamNameRemove.TabIndex = 23;
            this.TeamNameRemove.ValueMember = "value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(5, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Or choose a team to remove from";
            // 
            // formAdminTrainerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TeamNameRemove);
            this.Controls.Add(this.TeamNameAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FullName);
            this.Name = "formAdminTrainerOptions";
            this.Text = "formAdminTrainerOptions";
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Teams;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TeamNameAdd;
        private System.Windows.Forms.BindingSource comboItemBindingSource;
        private System.Windows.Forms.ComboBox TeamNameRemove;
        private System.Windows.Forms.Label label2;
    }
}
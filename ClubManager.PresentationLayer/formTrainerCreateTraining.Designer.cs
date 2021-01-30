
namespace ClubManager.PresentationLayer
{
    partial class FormTrainerCreateTraining
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
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LogInButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DurationInput = new System.Windows.Forms.TextBox();
            this.labelval = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TeamCombo = new System.Windows.Forms.ComboBox();
            this.comboItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.StartTimePicker.Location = new System.Drawing.Point(7, 30);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(226, 25);
            this.StartTimePicker.TabIndex = 1;
            // 
            // LogInButton
            // 
            this.LogInButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LogInButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LogInButton.Location = new System.Drawing.Point(7, 167);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(112, 34);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Confirm";
            this.LogInButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.Location = new System.Drawing.Point(125, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DurationInput
            // 
            this.DurationInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DurationInput.Location = new System.Drawing.Point(7, 80);
            this.DurationInput.Name = "DurationInput";
            this.DurationInput.Size = new System.Drawing.Size(226, 27);
            this.DurationInput.TabIndex = 2;
            // 
            // labelval
            // 
            this.labelval.AutoSize = true;
            this.labelval.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelval.Location = new System.Drawing.Point(3, 8);
            this.labelval.Name = "labelval";
            this.labelval.Size = new System.Drawing.Size(82, 19);
            this.labelval.TabIndex = 14;
            this.labelval.Text = "Start Time";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelDuration.Location = new System.Drawing.Point(3, 58);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(74, 19);
            this.labelDuration.TabIndex = 15;
            this.labelDuration.Tag = "";
            this.labelDuration.Text = "Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(75, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 16;
            this.label1.Tag = "";
            this.label1.Text = "(in minutes, max 120)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 17;
            this.label2.Tag = "";
            this.label2.Text = "Team";
            // 
            // TeamCombo
            // 
            this.TeamCombo.DataSource = this.comboItemBindingSource;
            this.TeamCombo.DisplayMember = "value";
            this.TeamCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TeamCombo.FormattingEnabled = true;
            this.TeamCombo.Location = new System.Drawing.Point(7, 132);
            this.TeamCombo.Name = "TeamCombo";
            this.TeamCombo.Size = new System.Drawing.Size(226, 29);
            this.TeamCombo.TabIndex = 3;
            this.TeamCombo.ValueMember = "value";
            // 
            // comboItemBindingSource
            // 
            this.comboItemBindingSource.DataSource = typeof(ClubManager.BaseLib.ComboItem);
            // 
            // FormTrainerCreateTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 209);
            this.Controls.Add(this.TeamCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelval);
            this.Controls.Add(this.DurationInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.StartTimePicker);
            this.Name = "FormTrainerCreateTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Training";
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DurationInput;
        private System.Windows.Forms.Label labelval;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TeamCombo;
        private System.Windows.Forms.BindingSource comboItemBindingSource;
    }
}
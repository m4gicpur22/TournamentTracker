namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.TeamNameTextBox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.SelectTeamMemeberTextBox = new System.Windows.Forms.ComboBox();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.AddNewMemberTextBox = new System.Windows.Forms.GroupBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.CellPhoneValue = new System.Windows.Forms.TextBox();
            this.CellPhoneLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedTeamMembers = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameTextBox
            // 
            this.TeamNameTextBox.Location = new System.Drawing.Point(45, 174);
            this.TeamNameTextBox.Name = "TeamNameTextBox";
            this.TeamNameTextBox.Size = new System.Drawing.Size(400, 35);
            this.TeamNameTextBox.TabIndex = 11;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamNameLabel.Location = new System.Drawing.Point(45, 123);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.TeamNameLabel.TabIndex = 9;
            this.TeamNameLabel.Text = "Team Name";
            this.TeamNameLabel.Click += new System.EventHandler(this.teamOneName_Click);
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateTeamLabel.Location = new System.Drawing.Point(45, 45);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(213, 50);
            this.CreateTeamLabel.TabIndex = 12;
            this.CreateTeamLabel.Text = "Create Team";
            this.CreateTeamLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(45, 247);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.SelectTeamMemberLabel.TabIndex = 13;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            this.SelectTeamMemberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SelectTeamMemeberTextBox
            // 
            this.SelectTeamMemeberTextBox.FormattingEnabled = true;
            this.SelectTeamMemeberTextBox.Location = new System.Drawing.Point(45, 309);
            this.SelectTeamMemeberTextBox.Name = "SelectTeamMemeberTextBox";
            this.SelectTeamMemeberTextBox.Size = new System.Drawing.Size(400, 38);
            this.SelectTeamMemeberTextBox.TabIndex = 14;
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddMemberButton.Location = new System.Drawing.Point(68, 392);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(240, 51);
            this.AddMemberButton.TabIndex = 26;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            // 
            // AddNewMemberTextBox
            // 
            this.AddNewMemberTextBox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberTextBox.Controls.Add(this.CellPhoneValue);
            this.AddNewMemberTextBox.Controls.Add(this.CellPhoneLabel);
            this.AddNewMemberTextBox.Controls.Add(this.EmailValue);
            this.AddNewMemberTextBox.Controls.Add(this.EmailLabel);
            this.AddNewMemberTextBox.Controls.Add(this.LastNameValue);
            this.AddNewMemberTextBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberTextBox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberTextBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewMemberTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddNewMemberTextBox.Location = new System.Drawing.Point(45, 482);
            this.AddNewMemberTextBox.Name = "AddNewMemberTextBox";
            this.AddNewMemberTextBox.Size = new System.Drawing.Size(390, 393);
            this.AddNewMemberTextBox.TabIndex = 27;
            this.AddNewMemberTextBox.TabStop = false;
            this.AddNewMemberTextBox.Text = "Add New Member";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateMemberButton.Location = new System.Drawing.Point(75, 324);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(240, 51);
            this.CreateMemberButton.TabIndex = 28;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            // 
            // CellPhoneValue
            // 
            this.CellPhoneValue.Location = new System.Drawing.Point(174, 260);
            this.CellPhoneValue.Name = "CellPhoneValue";
            this.CellPhoneValue.Size = new System.Drawing.Size(179, 43);
            this.CellPhoneValue.TabIndex = 16;
            // 
            // CellPhoneLabel
            // 
            this.CellPhoneLabel.AutoSize = true;
            this.CellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellPhoneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CellPhoneLabel.Location = new System.Drawing.Point(24, 257);
            this.CellPhoneLabel.Name = "CellPhoneLabel";
            this.CellPhoneLabel.Size = new System.Drawing.Size(144, 37);
            this.CellPhoneLabel.TabIndex = 15;
            this.CellPhoneLabel.Text = "Cell Phone";
            // 
            // EmailValue
            // 
            this.EmailValue.Location = new System.Drawing.Point(174, 185);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(179, 43);
            this.EmailValue.TabIndex = 14;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(24, 182);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(82, 37);
            this.EmailLabel.TabIndex = 13;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(174, 120);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(179, 43);
            this.LastNameValue.TabIndex = 12;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LastNameLabel.Location = new System.Drawing.Point(24, 117);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(142, 37);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(174, 55);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(179, 43);
            this.FirstNameValue.TabIndex = 10;
            this.FirstNameValue.TextChanged += new System.EventHandler(this.teamOneScoreText_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FirstNameLabel.Location = new System.Drawing.Point(24, 52);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(144, 37);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 30;
            this.TeamMembersListBox.Location = new System.Drawing.Point(505, 189);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(295, 512);
            this.TeamMembersListBox.TabIndex = 28;
            // 
            // deleteSelectedTeamMembers
            // 
            this.deleteSelectedTeamMembers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedTeamMembers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedTeamMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedTeamMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedTeamMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedTeamMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedTeamMembers.Location = new System.Drawing.Point(867, 392);
            this.deleteSelectedTeamMembers.Name = "deleteSelectedTeamMembers";
            this.deleteSelectedTeamMembers.Size = new System.Drawing.Size(121, 96);
            this.deleteSelectedTeamMembers.TabIndex = 29;
            this.deleteSelectedTeamMembers.Text = "Delete Selected";
            this.deleteSelectedTeamMembers.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamButton.Location = new System.Drawing.Point(520, 755);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(240, 51);
            this.CreateTeamButton.TabIndex = 30;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 900);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.deleteSelectedTeamMembers);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AddNewMemberTextBox);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.SelectTeamMemeberTextBox);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.CreateTeamLabel);
            this.Controls.Add(this.TeamNameTextBox);
            this.Controls.Add(this.TeamNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.AddNewMemberTextBox.ResumeLayout(false);
            this.AddNewMemberTextBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameTextBox;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label CreateTeamLabel;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.ComboBox SelectTeamMemeberTextBox;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.GroupBox AddNewMemberTextBox;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.TextBox CellPhoneValue;
        private System.Windows.Forms.Label CellPhoneLabel;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedTeamMembers;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}
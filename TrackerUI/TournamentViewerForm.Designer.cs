namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tournamentHeadLabel = new Label();
            tournamentNameLabel = new Label();
            roundLabel = new Label();
            roundDropdown = new ComboBox();
            matchupCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneNameLabel = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreText = new TextBox();
            teamTwoScoreText = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoNameLabel = new Label();
            versusLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // tournamentHeadLabel
            // 
            tournamentHeadLabel.AutoSize = true;
            tournamentHeadLabel.Font = new Font("Segoe UI Semilight", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentHeadLabel.Location = new Point(51, 50);
            tournamentHeadLabel.Name = "tournamentHeadLabel";
            tournamentHeadLabel.Size = new Size(230, 50);
            tournamentHeadLabel.TabIndex = 0;
            tournamentHeadLabel.Text = "Tournament: ";
            tournamentHeadLabel.Click += label1_Click_1;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Semilight", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.Location = new Point(287, 50);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(152, 50);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(51, 130);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropdown
            // 
            roundDropdown.FormattingEnabled = true;
            roundDropdown.Location = new Point(147, 127);
            roundDropdown.Name = "roundDropdown";
            roundDropdown.Size = new Size(267, 45);
            roundDropdown.TabIndex = 3;
            // 
            // matchupCheckBox
            // 
            matchupCheckBox.AutoSize = true;
            matchupCheckBox.FlatStyle = FlatStyle.Flat;
            matchupCheckBox.Location = new Point(147, 193);
            matchupCheckBox.Name = "matchupCheckBox";
            matchupCheckBox.Size = new Size(209, 41);
            matchupCheckBox.TabIndex = 4;
            matchupCheckBox.Text = "Unplayed Only";
            matchupCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 37;
            matchupListBox.Location = new Point(51, 260);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(363, 300);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneNameLabel
            // 
            teamOneNameLabel.AutoSize = true;
            teamOneNameLabel.Location = new Point(490, 260);
            teamOneNameLabel.Name = "teamOneNameLabel";
            teamOneNameLabel.Size = new Size(165, 37);
            teamOneNameLabel.TabIndex = 6;
            teamOneNameLabel.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Location = new Point(490, 310);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(82, 37);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreText
            // 
            teamOneScoreText.Location = new Point(586, 310);
            teamOneScoreText.Name = "teamOneScoreText";
            teamOneScoreText.Size = new Size(112, 43);
            teamOneScoreText.TabIndex = 8;
            teamOneScoreText.TextChanged += textBox1_TextChanged;
            // 
            // teamTwoScoreText
            // 
            teamTwoScoreText.Location = new Point(586, 501);
            teamTwoScoreText.Name = "teamTwoScoreText";
            teamTwoScoreText.Size = new Size(112, 43);
            teamTwoScoreText.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Location = new Point(490, 501);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(82, 37);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoNameLabel
            // 
            teamTwoNameLabel.AutoSize = true;
            teamTwoNameLabel.Location = new Point(490, 451);
            teamTwoNameLabel.Name = "teamTwoNameLabel";
            teamTwoNameLabel.Size = new Size(165, 37);
            teamTwoNameLabel.TabIndex = 9;
            teamTwoNameLabel.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Location = new Point(539, 388);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(84, 37);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "- VS -";
            versusLabel.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button1.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(755, 397);
            button1.Name = "button1";
            button1.Size = new Size(159, 51);
            button1.TabIndex = 13;
            button1.Text = "Score";
            button1.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 627);
            Controls.Add(button1);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreText);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoNameLabel);
            Controls.Add(teamOneScoreText);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneNameLabel);
            Controls.Add(matchupListBox);
            Controls.Add(matchupCheckBox);
            Controls.Add(roundDropdown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(tournamentHeadLabel);
            Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(6, 7, 6, 7);
            Name = "TournamentViewerForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentHeadLabel;
        private Label tournamentNameLabel;
        private Label roundLabel;
        private ComboBox roundDropdown;
        private CheckBox matchupCheckBox;
        private ListBox matchupListBox;
        private Label teamOneNameLabel;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreText;
        private TextBox teamTwoScoreText;
        private Label teamTwoScoreLabel;
        private Label teamTwoNameLabel;
        private Label versusLabel;
        private Button button1;
    }
}
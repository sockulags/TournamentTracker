namespace TrackerUI
{
    partial class CreateTournamentForm
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
            createTournamentHeadLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeLabel = new Label();
            entryFeeValue = new TextBox();
            selectTeamLabel = new Label();
            selectTeamDropDown = new ComboBox();
            createNewLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            teamPlayersLabel = new Label();
            tournamentPlayerListBox = new ListBox();
            deleteSelectedPlayerButton = new Button();
            deleteSelectedPrizeButton = new Button();
            prizezListBox = new ListBox();
            prizesLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // createTournamentHeadLabel
            // 
            createTournamentHeadLabel.AutoSize = true;
            createTournamentHeadLabel.Font = new Font("Segoe UI Semilight", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentHeadLabel.Location = new Point(21, 32);
            createTournamentHeadLabel.Name = "createTournamentHeadLabel";
            createTournamentHeadLabel.Size = new Size(337, 50);
            createTournamentHeadLabel.TabIndex = 1;
            createTournamentHeadLabel.Text = "Create Tournament ";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(38, 152);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(311, 43);
            tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            tournamentNameLabel.Location = new Point(38, 112);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(236, 37);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            tournamentNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Location = new Point(38, 219);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(125, 37);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(169, 216);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(105, 43);
            entryFeeValue.TabIndex = 12;
            entryFeeValue.Text = "0";
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Location = new Point(38, 288);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(156, 37);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(38, 328);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(311, 45);
            selectTeamDropDown.TabIndex = 14;
            // 
            // createNewLabel
            // 
            createNewLabel.AutoSize = true;
            createNewLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createNewLabel.Location = new Point(258, 301);
            createNewLabel.Name = "createNewLabel";
            createNewLabel.Size = new Size(91, 21);
            createNewLabel.TabIndex = 15;
            createNewLabel.TabStop = true;
            createNewLabel.Text = "Create New";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.Location = new Point(106, 394);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(168, 51);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.Location = new Point(106, 468);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(168, 51);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += button1_Click;
            // 
            // teamPlayersLabel
            // 
            teamPlayersLabel.AutoSize = true;
            teamPlayersLabel.ImageAlign = ContentAlignment.MiddleLeft;
            teamPlayersLabel.Location = new Point(420, 112);
            teamPlayersLabel.Name = "teamPlayersLabel";
            teamPlayersLabel.Size = new Size(198, 37);
            teamPlayersLabel.TabIndex = 18;
            teamPlayersLabel.Text = "Teams / Players";
            teamPlayersLabel.TextAlign = ContentAlignment.MiddleLeft;
            teamPlayersLabel.Click += label1_Click;
            // 
            // tournamentPlayerListBox
            // 
            tournamentPlayerListBox.FormattingEnabled = true;
            tournamentPlayerListBox.ItemHeight = 37;
            tournamentPlayerListBox.Location = new Point(420, 152);
            tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            tournamentPlayerListBox.Size = new Size(375, 189);
            tournamentPlayerListBox.TabIndex = 19;
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPlayerButton.Location = new Point(822, 202);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(121, 75);
            deleteSelectedPlayerButton.TabIndex = 20;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPrizeButton.Location = new Point(822, 445);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(121, 74);
            deleteSelectedPrizeButton.TabIndex = 23;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizezListBox
            // 
            prizezListBox.FormattingEnabled = true;
            prizezListBox.ItemHeight = 37;
            prizezListBox.Location = new Point(420, 394);
            prizezListBox.Name = "prizezListBox";
            prizezListBox.Size = new Size(375, 189);
            prizezListBox.TabIndex = 22;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.ImageAlign = ContentAlignment.MiddleLeft;
            prizesLabel.Location = new Point(420, 354);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(198, 37);
            prizesLabel.TabIndex = 21;
            prizesLabel.Text = "Teams / Players";
            prizesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button1.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(311, 612);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(307, 77);
            button1.TabIndex = 24;
            button1.Text = "Create Tournament";
            button1.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(987, 727);
            Controls.Add(button1);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizezListBox);
            Controls.Add(prizesLabel);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(tournamentPlayerListBox);
            Controls.Add(teamPlayersLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewLabel);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(createTournamentHeadLabel);
            Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(6, 7, 6, 7);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentHeadLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private Label entryFeeLabel;
        private TextBox entryFeeValue;
        private Label selectTeamLabel;
        private ComboBox selectTeamDropDown;
        private LinkLabel createNewLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Label teamPlayersLabel;
        private ListBox tournamentPlayerListBox;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizeButton;
        private ListBox prizezListBox;
        private Label prizesLabel;
        private Button button1;
    }
}
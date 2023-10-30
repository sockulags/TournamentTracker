namespace TrackerUI
{
    partial class CreatePrizeForm
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
            prizeHeadLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            pricePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // prizeHeadLabel
            // 
            prizeHeadLabel.AutoSize = true;
            prizeHeadLabel.Font = new Font("Segoe UI Semilight", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            prizeHeadLabel.ForeColor = SystemColors.HotTrack;
            prizeHeadLabel.Location = new Point(26, 35);
            prizeHeadLabel.Name = "prizeHeadLabel";
            prizeHeadLabel.Size = new Size(214, 50);
            prizeHeadLabel.TabIndex = 12;
            prizeHeadLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(261, 113);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(206, 43);
            placeNumberValue.TabIndex = 14;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Location = new Point(48, 119);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(183, 37);
            placeNumberLabel.TabIndex = 13;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(261, 167);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(206, 43);
            placeNameValue.TabIndex = 16;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Location = new Point(48, 173);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(157, 37);
            placeNameLabel.TabIndex = 15;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(261, 225);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(206, 43);
            prizeAmountValue.TabIndex = 18;
            prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Location = new Point(48, 231);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(176, 37);
            prizeAmountLabel.TabIndex = 17;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(266, 349);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(206, 43);
            prizePercentageValue.TabIndex = 20;
            prizePercentageValue.Text = "0";
            // 
            // pricePercentageLabel
            // 
            pricePercentageLabel.AutoSize = true;
            pricePercentageLabel.Location = new Point(48, 355);
            pricePercentageLabel.Name = "pricePercentageLabel";
            pricePercentageLabel.Size = new Size(212, 37);
            pricePercentageLabel.TabIndex = 19;
            pricePercentageLabel.Text = "Price Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Location = new Point(194, 297);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(78, 37);
            orLabel.TabIndex = 21;
            orLabel.Text = "- or -";
            orLabel.UseWaitCursor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.Location = new Point(91, 438);
            createPrizeButton.Margin = new Padding(2);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(307, 77);
            createPrizeButton.TabIndex = 26;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(546, 588);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(pricePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(prizeHeadLabel);
            Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(6, 7, 6, 7);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label prizeHeadLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label pricePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}
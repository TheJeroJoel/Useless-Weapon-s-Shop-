namespace Useless_Weapon_s_Shop
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.ShopNameLabel = new System.Windows.Forms.Label();
            this.PenTextBox = new System.Windows.Forms.TextBox();
            this.StickTextBox = new System.Windows.Forms.TextBox();
            this.PenguinTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfPensLabel = new System.Windows.Forms.Label();
            this.NumberOfSticksLabel = new System.Windows.Forms.Label();
            this.NumberOfPenguinsLabel = new System.Windows.Forms.Label();
            this.CalculateButton1 = new System.Windows.Forms.Button();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel2 = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TaxLabel2 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalLabel2 = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.Button();
            this.TenderedLabel = new System.Windows.Forms.Label();
            this.TenderedTextBox = new System.Windows.Forms.TextBox();
            this.CalculateChangeButton = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.ChangeLabel2 = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.Receipt = new System.Windows.Forms.Label();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShopNameLabel
            // 
            this.ShopNameLabel.AutoSize = true;
            this.ShopNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopNameLabel.Location = new System.Drawing.Point(179, 9);
            this.ShopNameLabel.Name = "ShopNameLabel";
            this.ShopNameLabel.Size = new System.Drawing.Size(294, 34);
            this.ShopNameLabel.TabIndex = 0;
            this.ShopNameLabel.Text = "Useless Weapon\'s Shop";
            // 
            // PenTextBox
            // 
            this.PenTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PenTextBox.Location = new System.Drawing.Point(149, 57);
            this.PenTextBox.Name = "PenTextBox";
            this.PenTextBox.Size = new System.Drawing.Size(54, 20);
            this.PenTextBox.TabIndex = 1;
            // 
            // StickTextBox
            // 
            this.StickTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.StickTextBox.Location = new System.Drawing.Point(149, 93);
            this.StickTextBox.Name = "StickTextBox";
            this.StickTextBox.Size = new System.Drawing.Size(54, 20);
            this.StickTextBox.TabIndex = 2;
            // 
            // PenguinTextBox
            // 
            this.PenguinTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PenguinTextBox.Location = new System.Drawing.Point(149, 127);
            this.PenguinTextBox.Name = "PenguinTextBox";
            this.PenguinTextBox.Size = new System.Drawing.Size(54, 20);
            this.PenguinTextBox.TabIndex = 3;
            // 
            // NumberOfPensLabel
            // 
            this.NumberOfPensLabel.AutoSize = true;
            this.NumberOfPensLabel.Location = new System.Drawing.Point(58, 60);
            this.NumberOfPensLabel.Name = "NumberOfPensLabel";
            this.NumberOfPensLabel.Size = new System.Drawing.Size(85, 13);
            this.NumberOfPensLabel.TabIndex = 5;
            this.NumberOfPensLabel.Text = "Number Of Pens";
            // 
            // NumberOfSticksLabel
            // 
            this.NumberOfSticksLabel.AutoSize = true;
            this.NumberOfSticksLabel.Location = new System.Drawing.Point(57, 93);
            this.NumberOfSticksLabel.Name = "NumberOfSticksLabel";
            this.NumberOfSticksLabel.Size = new System.Drawing.Size(86, 13);
            this.NumberOfSticksLabel.TabIndex = 6;
            this.NumberOfSticksLabel.Text = "Number of sticks";
            // 
            // NumberOfPenguinsLabel
            // 
            this.NumberOfPenguinsLabel.AutoSize = true;
            this.NumberOfPenguinsLabel.Location = new System.Drawing.Point(38, 127);
            this.NumberOfPenguinsLabel.Name = "NumberOfPenguinsLabel";
            this.NumberOfPenguinsLabel.Size = new System.Drawing.Size(105, 13);
            this.NumberOfPenguinsLabel.TabIndex = 7;
            this.NumberOfPenguinsLabel.Text = "Number Of Penguins";
            // 
            // CalculateButton1
            // 
            this.CalculateButton1.Location = new System.Drawing.Point(40, 162);
            this.CalculateButton1.Name = "CalculateButton1";
            this.CalculateButton1.Size = new System.Drawing.Size(163, 20);
            this.CalculateButton1.TabIndex = 8;
            this.CalculateButton1.Text = "Calculate Totals";
            this.CalculateButton1.UseVisualStyleBackColor = true;
            this.CalculateButton1.Click += new System.EventHandler(this.CalculateButton1_Click);
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(47, 197);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(53, 13);
            this.SubTotalLabel.TabIndex = 9;
            this.SubTotalLabel.Text = "Sub Total";
            // 
            // SubTotalLabel2
            // 
            this.SubTotalLabel2.Location = new System.Drawing.Point(117, 197);
            this.SubTotalLabel2.Name = "SubTotalLabel2";
            this.SubTotalLabel2.Size = new System.Drawing.Size(86, 13);
            this.SubTotalLabel2.TabIndex = 10;
            this.SubTotalLabel2.Text = "_";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(47, 227);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(25, 13);
            this.TaxLabel.TabIndex = 11;
            this.TaxLabel.Text = "Tax";
            // 
            // TaxLabel2
            // 
            this.TaxLabel2.Location = new System.Drawing.Point(117, 227);
            this.TaxLabel2.Name = "TaxLabel2";
            this.TaxLabel2.Size = new System.Drawing.Size(86, 13);
            this.TaxLabel2.TabIndex = 12;
            this.TaxLabel2.Text = "_";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(47, 259);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 13;
            this.TotalLabel.Text = "Total";
            // 
            // TotalLabel2
            // 
            this.TotalLabel2.Location = new System.Drawing.Point(117, 259);
            this.TotalLabel2.Name = "TotalLabel2";
            this.TotalLabel2.Size = new System.Drawing.Size(86, 13);
            this.TotalLabel2.TabIndex = 14;
            this.TotalLabel2.Text = "_";
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(40, 286);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(163, 10);
            this.Line.TabIndex = 15;
            this.Line.Text = "Sus (nobody will notice this HA HA HA)";
            this.Line.UseVisualStyleBackColor = true;
            // 
            // TenderedLabel
            // 
            this.TenderedLabel.AutoSize = true;
            this.TenderedLabel.Location = new System.Drawing.Point(37, 311);
            this.TenderedLabel.Name = "TenderedLabel";
            this.TenderedLabel.Size = new System.Drawing.Size(53, 13);
            this.TenderedLabel.TabIndex = 16;
            this.TenderedLabel.Text = "Tendered";
            // 
            // TenderedTextBox
            // 
            this.TenderedTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TenderedTextBox.Location = new System.Drawing.Point(120, 308);
            this.TenderedTextBox.Name = "TenderedTextBox";
            this.TenderedTextBox.Size = new System.Drawing.Size(54, 20);
            this.TenderedTextBox.TabIndex = 17;
            // 
            // CalculateChangeButton
            // 
            this.CalculateChangeButton.Location = new System.Drawing.Point(40, 334);
            this.CalculateChangeButton.Name = "CalculateChangeButton";
            this.CalculateChangeButton.Size = new System.Drawing.Size(163, 26);
            this.CalculateChangeButton.TabIndex = 18;
            this.CalculateChangeButton.Text = "Calculate Change";
            this.CalculateChangeButton.UseVisualStyleBackColor = true;
            this.CalculateChangeButton.Click += new System.EventHandler(this.CalculateChangeButton_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Location = new System.Drawing.Point(38, 376);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(44, 13);
            this.ChangeLabel.TabIndex = 19;
            this.ChangeLabel.Text = "Change";
            // 
            // ChangeLabel2
            // 
            this.ChangeLabel2.Location = new System.Drawing.Point(98, 376);
            this.ChangeLabel2.Name = "ChangeLabel2";
            this.ChangeLabel2.Size = new System.Drawing.Size(127, 13);
            this.ChangeLabel2.TabIndex = 20;
            this.ChangeLabel2.Text = "_";
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(40, 403);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(185, 22);
            this.PrintButton.TabIndex = 21;
            this.PrintButton.Text = "Print Receipt";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Receipt
            // 
            this.Receipt.BackColor = System.Drawing.Color.Crimson;
            this.Receipt.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receipt.Location = new System.Drawing.Point(337, 43);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(262, 343);
            this.Receipt.TabIndex = 22;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Location = new System.Drawing.Point(352, 394);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(231, 31);
            this.NewOrderButton.TabIndex = 23;
            this.NewOrderButton.Text = "New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(649, 437);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.Receipt);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ChangeLabel2);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.CalculateChangeButton);
            this.Controls.Add(this.TenderedTextBox);
            this.Controls.Add(this.TenderedLabel);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.TotalLabel2);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TaxLabel2);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.SubTotalLabel2);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.CalculateButton1);
            this.Controls.Add(this.NumberOfPenguinsLabel);
            this.Controls.Add(this.NumberOfSticksLabel);
            this.Controls.Add(this.NumberOfPensLabel);
            this.Controls.Add(this.PenguinTextBox);
            this.Controls.Add(this.StickTextBox);
            this.Controls.Add(this.PenTextBox);
            this.Controls.Add(this.ShopNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShopForm";
            this.Text = "Useless Weapon Shop";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShopNameLabel;
        private System.Windows.Forms.TextBox PenTextBox;
        private System.Windows.Forms.TextBox StickTextBox;
        private System.Windows.Forms.TextBox PenguinTextBox;
        private System.Windows.Forms.Label NumberOfPensLabel;
        private System.Windows.Forms.Label NumberOfSticksLabel;
        private System.Windows.Forms.Label NumberOfPenguinsLabel;
        private System.Windows.Forms.Button CalculateButton1;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label SubTotalLabel2;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label TaxLabel2;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalLabel2;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Label TenderedLabel;
        private System.Windows.Forms.TextBox TenderedTextBox;
        private System.Windows.Forms.Button CalculateChangeButton;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Label ChangeLabel2;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label Receipt;
        private System.Windows.Forms.Button NewOrderButton;
    }
}


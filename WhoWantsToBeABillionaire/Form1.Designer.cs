namespace WhoWantsToBeABillionaire
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lstLevel = new System.Windows.Forms.ListBox();
            this.bntFiftyFifty = new System.Windows.Forms.Button();
            this.btnAudienceHelp = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lstTopPlayers = new System.Windows.Forms.ListBox();
            this.rate = new System.Windows.Forms.Label();
            this.btnSecondChance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WhoWantsToBeABillionaire.Properties.Resources.wwtbab_pict;
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerA.Location = new System.Drawing.Point(12, 326);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(202, 42);
            this.btnAnswerA.TabIndex = 1;
            this.btnAnswerA.Tag = "1";
            this.btnAnswerA.Text = "button1";
            this.btnAnswerA.UseVisualStyleBackColor = false;
            this.btnAnswerA.Click += new System.EventHandler(this.ClickButton_Click);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerB.Location = new System.Drawing.Point(12, 388);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(202, 38);
            this.btnAnswerB.TabIndex = 2;
            this.btnAnswerB.Tag = "2";
            this.btnAnswerB.Text = "button2";
            this.btnAnswerB.UseVisualStyleBackColor = true;
            this.btnAnswerB.Click += new System.EventHandler(this.ClickButton_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerC.Location = new System.Drawing.Point(232, 326);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(184, 42);
            this.btnAnswerC.TabIndex = 3;
            this.btnAnswerC.Tag = "3";
            this.btnAnswerC.Text = "button3";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            this.btnAnswerC.Click += new System.EventHandler(this.ClickButton_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerD.Location = new System.Drawing.Point(232, 388);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(184, 38);
            this.btnAnswerD.TabIndex = 4;
            this.btnAnswerD.Tag = "4";
            this.btnAnswerD.Text = "button4";
            this.btnAnswerD.UseVisualStyleBackColor = true;
            this.btnAnswerD.Click += new System.EventHandler(this.ClickButton_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(14, 269);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(431, 49);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "label1";
            // 
            // lstLevel
            // 
            this.lstLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.ItemHeight = 16;
            this.lstLevel.Items.AddRange(new object[] {
            "3 000 000",
            "1 500 000",
            "800 000",
            "400 000",
            "200 000",
            "100 000",
            "50 000",
            "25 000",
            "15 000",
            "10 000",
            "5 000",
            "3 000",
            "2 000",
            "1 000",
            "500"});
            this.lstLevel.Location = new System.Drawing.Point(474, 12);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstLevel.Size = new System.Drawing.Size(75, 260);
            this.lstLevel.TabIndex = 6;
            // 
            // bntFiftyFifty
            // 
            this.bntFiftyFifty.Location = new System.Drawing.Point(451, 295);
            this.bntFiftyFifty.Name = "bntFiftyFifty";
            this.bntFiftyFifty.Size = new System.Drawing.Size(112, 23);
            this.bntFiftyFifty.TabIndex = 7;
            this.bntFiftyFifty.Text = "50/50";
            this.bntFiftyFifty.UseVisualStyleBackColor = true;
            this.bntFiftyFifty.Click += new System.EventHandler(this.bntFiftyFifty_Click);
            // 
            // btnAudienceHelp
            // 
            this.btnAudienceHelp.Location = new System.Drawing.Point(451, 337);
            this.btnAudienceHelp.Name = "btnAudienceHelp";
            this.btnAudienceHelp.Size = new System.Drawing.Size(112, 23);
            this.btnAudienceHelp.TabIndex = 8;
            this.btnAudienceHelp.Text = "Помощь зала";
            this.btnAudienceHelp.UseVisualStyleBackColor = true;
            this.btnAudienceHelp.Click += new System.EventHandler(this.btnAudienceHelp_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(49, 10);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(367, 227);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // lstTopPlayers
            // 
            this.lstTopPlayers.FormattingEnabled = true;
            this.lstTopPlayers.Location = new System.Drawing.Point(570, 34);
            this.lstTopPlayers.Name = "lstTopPlayers";
            this.lstTopPlayers.Size = new System.Drawing.Size(138, 238);
            this.lstTopPlayers.TabIndex = 10;
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Location = new System.Drawing.Point(579, 11);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(48, 13);
            this.rate.TabIndex = 11;
            this.rate.Text = "Рейнтиг";
            // 
            // btnSecondChance
            // 
            this.btnSecondChance.Location = new System.Drawing.Point(451, 375);
            this.btnSecondChance.Name = "btnSecondChance";
            this.btnSecondChance.Size = new System.Drawing.Size(112, 26);
            this.btnSecondChance.TabIndex = 12;
            this.btnSecondChance.Text = "Право на ошибку";
            this.btnSecondChance.UseVisualStyleBackColor = true;
            this.btnSecondChance.Click += new System.EventHandler(this.btnSecondChance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 443);
            this.Controls.Add(this.btnSecondChance);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.lstTopPlayers);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnAudienceHelp);
            this.Controls.Add(this.bntFiftyFifty);
            this.Controls.Add(this.lstLevel);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ListBox lstLevel;
        private System.Windows.Forms.Button bntFiftyFifty;
        private System.Windows.Forms.Button btnAudienceHelp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox lstTopPlayers;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Button btnSecondChance;
    }
}


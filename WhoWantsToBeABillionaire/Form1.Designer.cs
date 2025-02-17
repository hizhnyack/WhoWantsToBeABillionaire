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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WhoWantsToBeABillionaire.Properties.Resources.wwtbab_pict;
            this.pictureBox1.Location = new System.Drawing.Point(98, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Location = new System.Drawing.Point(98, 338);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(75, 23);
            this.btnAnswerA.TabIndex = 1;
            this.btnAnswerA.Tag = "1";
            this.btnAnswerA.Text = "button1";
            this.btnAnswerA.UseVisualStyleBackColor = false;
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Location = new System.Drawing.Point(98, 386);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(75, 23);
            this.btnAnswerB.TabIndex = 2;
            this.btnAnswerB.Tag = "2";
            this.btnAnswerB.Text = "button2";
            this.btnAnswerB.UseVisualStyleBackColor = true;
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Location = new System.Drawing.Point(341, 338);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(75, 23);
            this.btnAnswerC.TabIndex = 3;
            this.btnAnswerC.Tag = "3";
            this.btnAnswerC.Text = "button3";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.Location = new System.Drawing.Point(341, 386);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(75, 23);
            this.btnAnswerD.TabIndex = 4;
            this.btnAnswerD.Tag = "4";
            this.btnAnswerD.Text = "button4";
            this.btnAnswerD.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(138, 266);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(278, 41);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 438);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.Label lblQuestion;
    }
}


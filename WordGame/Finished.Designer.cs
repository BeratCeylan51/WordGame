namespace WordGame
{
    partial class Finished
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblNumberOfLetters = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.gbxInformation = new System.Windows.Forms.GroupBox();
            this.gbxResult = new System.Windows.Forms.GroupBox();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblLetter = new System.Windows.Forms.Label();
            this.gbxInformation.SuspendLayout();
            this.gbxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(26, 32);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(68, 31);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Süre";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimeValue.Location = new System.Drawing.Point(254, 32);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(24, 25);
            this.lblTimeValue.TabIndex = 1;
            this.lblTimeValue.Text = "0";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuess.Location = new System.Drawing.Point(26, 73);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(164, 25);
            this.lblGuess.TabIndex = 2;
            this.lblGuess.Text = "Yanlış Harf Sayısı";
            // 
            // lblNumberOfLetters
            // 
            this.lblNumberOfLetters.AutoSize = true;
            this.lblNumberOfLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumberOfLetters.Location = new System.Drawing.Point(256, 73);
            this.lblNumberOfLetters.Name = "lblNumberOfLetters";
            this.lblNumberOfLetters.Size = new System.Drawing.Size(30, 31);
            this.lblNumberOfLetters.TabIndex = 3;
            this.lblNumberOfLetters.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(154, 76);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(73, 31);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Puan";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScoreValue.Location = new System.Drawing.Point(233, 76);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(30, 31);
            this.lblScoreValue.TabIndex = 5;
            this.lblScoreValue.Text = "0";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblState.Location = new System.Drawing.Point(132, 122);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(140, 29);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "Kaybettiniz";
            // 
            // gbxInformation
            // 
            this.gbxInformation.BackColor = System.Drawing.Color.LightGray;
            this.gbxInformation.Controls.Add(this.lblLetter);
            this.gbxInformation.Controls.Add(this.lblSecond);
            this.gbxInformation.Controls.Add(this.lblTime);
            this.gbxInformation.Controls.Add(this.lblTimeValue);
            this.gbxInformation.Controls.Add(this.lblGuess);
            this.gbxInformation.Controls.Add(this.lblNumberOfLetters);
            this.gbxInformation.Location = new System.Drawing.Point(165, 24);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(384, 121);
            this.gbxInformation.TabIndex = 7;
            this.gbxInformation.TabStop = false;
            this.gbxInformation.Text = "Bigllendirme";
            // 
            // gbxResult
            // 
            this.gbxResult.BackColor = System.Drawing.Color.LightGray;
            this.gbxResult.Controls.Add(this.lblScore);
            this.gbxResult.Controls.Add(this.lblScoreValue);
            this.gbxResult.Controls.Add(this.lblState);
            this.gbxResult.Location = new System.Drawing.Point(125, 151);
            this.gbxResult.Name = "gbxResult";
            this.gbxResult.Size = new System.Drawing.Size(445, 205);
            this.gbxResult.TabIndex = 8;
            this.gbxResult.TabStop = false;
            this.gbxResult.Text = "Sonuç";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecond.Location = new System.Drawing.Point(284, 32);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(79, 25);
            this.lblSecond.TabIndex = 4;
            this.lblSecond.Text = "Saniye";
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter.Location = new System.Drawing.Point(284, 73);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(52, 25);
            this.lblLetter.TabIndex = 4;
            this.lblLetter.Text = "Harf";
            // 
            // Finished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(696, 416);
            this.Controls.Add(this.gbxResult);
            this.Controls.Add(this.gbxInformation);
            this.Name = "Finished";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finished";
            this.Load += new System.EventHandler(this.Finished_Load);
            this.gbxInformation.ResumeLayout(false);
            this.gbxInformation.PerformLayout();
            this.gbxResult.ResumeLayout(false);
            this.gbxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblNumberOfLetters;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox gbxInformation;
        private System.Windows.Forms.GroupBox gbxResult;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Label lblSecond;
    }
}
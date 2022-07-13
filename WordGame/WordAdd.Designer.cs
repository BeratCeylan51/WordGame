namespace WordGame
{
    partial class WordAdd
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
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.rdBtnEasy = new System.Windows.Forms.RadioButton();
            this.rdBtnMiddle = new System.Windows.Forms.RadioButton();
            this.rdBtnHard = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(48, 75);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(181, 20);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Zorluk Seviyesi Seçiniz";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(48, 173);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(121, 20);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Kelimeyi Giriniz";
            // 
            // tbxWord
            // 
            this.tbxWord.Location = new System.Drawing.Point(51, 211);
            this.tbxWord.Multiline = true;
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(212, 119);
            this.tbxWord.TabIndex = 2;
            // 
            // rdBtnEasy
            // 
            this.rdBtnEasy.AutoSize = true;
            this.rdBtnEasy.Location = new System.Drawing.Point(59, 117);
            this.rdBtnEasy.Name = "rdBtnEasy";
            this.rdBtnEasy.Size = new System.Drawing.Size(62, 20);
            this.rdBtnEasy.TabIndex = 3;
            this.rdBtnEasy.TabStop = true;
            this.rdBtnEasy.Text = "Kolay";
            this.rdBtnEasy.UseVisualStyleBackColor = true;
            // 
            // rdBtnMiddle
            // 
            this.rdBtnMiddle.AutoSize = true;
            this.rdBtnMiddle.Location = new System.Drawing.Point(143, 117);
            this.rdBtnMiddle.Name = "rdBtnMiddle";
            this.rdBtnMiddle.Size = new System.Drawing.Size(53, 20);
            this.rdBtnMiddle.TabIndex = 4;
            this.rdBtnMiddle.TabStop = true;
            this.rdBtnMiddle.Text = "Orta";
            this.rdBtnMiddle.UseVisualStyleBackColor = true;
            // 
            // rdBtnHard
            // 
            this.rdBtnHard.AutoSize = true;
            this.rdBtnHard.Location = new System.Drawing.Point(215, 117);
            this.rdBtnHard.Name = "rdBtnHard";
            this.rdBtnHard.Size = new System.Drawing.Size(48, 20);
            this.rdBtnHard.TabIndex = 5;
            this.rdBtnHard.TabStop = true;
            this.rdBtnHard.Text = "Zor";
            this.rdBtnHard.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(188, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(51, 357);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Çıkış";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WordAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdBtnHard);
            this.Controls.Add(this.rdBtnMiddle);
            this.Controls.Add(this.rdBtnEasy);
            this.Controls.Add(this.tbxWord);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblLevel);
            this.Name = "WordAdd";
            this.Text = "WordAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox tbxWord;
        private System.Windows.Forms.RadioButton rdBtnEasy;
        private System.Windows.Forms.RadioButton rdBtnMiddle;
        private System.Windows.Forms.RadioButton rdBtnHard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}
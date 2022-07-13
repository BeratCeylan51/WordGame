namespace WordGame
{
    partial class Game
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
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbx5 = new System.Windows.Forms.TextBox();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.gbxItem = new System.Windows.Forms.GroupBox();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrCount = new System.Windows.Forms.Timer(this.components);
            this.gbxItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx1
            // 
            this.tbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx1.Location = new System.Drawing.Point(51, 138);
            this.tbx1.Multiline = true;
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(42, 38);
            this.tbx1.TabIndex = 0;
            this.tbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbx5
            // 
            this.tbx5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx5.Location = new System.Drawing.Point(309, 138);
            this.tbx5.Multiline = true;
            this.tbx5.Name = "tbx5";
            this.tbx5.Size = new System.Drawing.Size(42, 38);
            this.tbx5.TabIndex = 2;
            this.tbx5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx4
            // 
            this.tbx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx4.Location = new System.Drawing.Point(244, 138);
            this.tbx4.Multiline = true;
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(42, 38);
            this.tbx4.TabIndex = 3;
            this.tbx4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx3
            // 
            this.tbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx3.Location = new System.Drawing.Point(179, 138);
            this.tbx3.Multiline = true;
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(42, 38);
            this.tbx3.TabIndex = 4;
            this.tbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx2
            // 
            this.tbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx2.Location = new System.Drawing.Point(114, 138);
            this.tbx2.Multiline = true;
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(42, 38);
            this.tbx2.TabIndex = 5;
            this.tbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxWord
            // 
            this.tbxWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxWord.Location = new System.Drawing.Point(179, 215);
            this.tbxWord.Multiline = true;
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(42, 42);
            this.tbxWord.TabIndex = 7;
            this.tbxWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuess.Location = new System.Drawing.Point(244, 215);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(101, 42);
            this.btnGuess.TabIndex = 8;
            this.btnGuess.Text = "Tahmin";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWord.Location = new System.Drawing.Point(47, 93);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(210, 20);
            this.lblWord.TabIndex = 9;
            this.lblWord.Text = "Tahmin Edilecek Kelime";
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahmin.Location = new System.Drawing.Point(47, 225);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(100, 20);
            this.lblTahmin.TabIndex = 10;
            this.lblTahmin.Text = "Tahmininiz";
            // 
            // gbxItem
            // 
            this.gbxItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxItem.Controls.Add(this.lblTimeValue);
            this.gbxItem.Controls.Add(this.lblTime);
            this.gbxItem.Controls.Add(this.tbx1);
            this.gbxItem.Controls.Add(this.tbx2);
            this.gbxItem.Controls.Add(this.btnGuess);
            this.gbxItem.Controls.Add(this.tbx4);
            this.gbxItem.Controls.Add(this.tbx3);
            this.gbxItem.Controls.Add(this.lblTahmin);
            this.gbxItem.Controls.Add(this.tbxWord);
            this.gbxItem.Controls.Add(this.lblWord);
            this.gbxItem.Controls.Add(this.tbx5);
            this.gbxItem.Location = new System.Drawing.Point(291, 113);
            this.gbxItem.Name = "gbxItem";
            this.gbxItem.Size = new System.Drawing.Size(394, 322);
            this.gbxItem.TabIndex = 11;
            this.gbxItem.TabStop = false;
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimeValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblTimeValue.Location = new System.Drawing.Point(321, 53);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(24, 25);
            this.lblTimeValue.TabIndex = 11;
            this.lblTimeValue.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(239, 52);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 25);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Süre";
            // 
            // tmrCount
            // 
            this.tmrCount.Interval = 1000;
            this.tmrCount.Tick += new System.EventHandler(this.tmrCount_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(991, 581);
            this.Controls.Add(this.gbxItem);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Shown += new System.EventHandler(this.Game_Load);
            this.gbxItem.ResumeLayout(false);
            this.gbxItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbx5;
        private System.Windows.Forms.TextBox tbx4;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbxWord;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.GroupBox gbxItem;
        private System.Windows.Forms.Timer tmrCount;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblTime;
    }
}
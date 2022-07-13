namespace WordGame
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilçeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyuncuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyuncuSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxLevelSelect = new System.Windows.Forms.GroupBox();
            this.rdBtnHard = new System.Windows.Forms.RadioButton();
            this.rdBtnMiddle = new System.Windows.Forms.RadioButton();
            this.rdBtnEasy = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.anaSayfaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.kelimeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelimeSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.gbxLevelSelect.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(853, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eklemeToolStripMenuItem,
            this.silmeToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // eklemeToolStripMenuItem
            // 
            this.eklemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilEkleToolStripMenuItem,
            this.ilçeEkleToolStripMenuItem,
            this.oyuncuEkleToolStripMenuItem,
            this.kelimeEkleToolStripMenuItem});
            this.eklemeToolStripMenuItem.Name = "eklemeToolStripMenuItem";
            this.eklemeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eklemeToolStripMenuItem.Text = "Ekleme";
            // 
            // ilEkleToolStripMenuItem
            // 
            this.ilEkleToolStripMenuItem.Name = "ilEkleToolStripMenuItem";
            this.ilEkleToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.ilEkleToolStripMenuItem.Text = "İl Ekle";
            this.ilEkleToolStripMenuItem.Click += new System.EventHandler(this.ilEkleToolStripMenuItem_Click);
            // 
            // ilçeEkleToolStripMenuItem
            // 
            this.ilçeEkleToolStripMenuItem.Name = "ilçeEkleToolStripMenuItem";
            this.ilçeEkleToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.ilçeEkleToolStripMenuItem.Text = "İlçe Ekle";
            this.ilçeEkleToolStripMenuItem.Click += new System.EventHandler(this.ilçeEkleToolStripMenuItem_Click);
            // 
            // oyuncuEkleToolStripMenuItem
            // 
            this.oyuncuEkleToolStripMenuItem.Name = "oyuncuEkleToolStripMenuItem";
            this.oyuncuEkleToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.oyuncuEkleToolStripMenuItem.Text = "Oyuncu Ekle";
            this.oyuncuEkleToolStripMenuItem.Click += new System.EventHandler(this.oyuncuEkleToolStripMenuItem_Click);
            // 
            // silmeToolStripMenuItem
            // 
            this.silmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilSilmeToolStripMenuItem,
            this.oyuncuSilmeToolStripMenuItem,
            this.kelimeSilmeToolStripMenuItem});
            this.silmeToolStripMenuItem.Name = "silmeToolStripMenuItem";
            this.silmeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.silmeToolStripMenuItem.Text = "Silme";
            // 
            // ilSilmeToolStripMenuItem
            // 
            this.ilSilmeToolStripMenuItem.Name = "ilSilmeToolStripMenuItem";
            this.ilSilmeToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.ilSilmeToolStripMenuItem.Text = "İl ve İlçe Silme";
            this.ilSilmeToolStripMenuItem.Click += new System.EventHandler(this.ilSilmeToolStripMenuItem_Click);
            // 
            // oyuncuSilmeToolStripMenuItem
            // 
            this.oyuncuSilmeToolStripMenuItem.Name = "oyuncuSilmeToolStripMenuItem";
            this.oyuncuSilmeToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.oyuncuSilmeToolStripMenuItem.Text = "Oyuncu Silme";
            this.oyuncuSilmeToolStripMenuItem.Click += new System.EventHandler(this.oyuncuSilmeToolStripMenuItem_Click);
            // 
            // gbxLevelSelect
            // 
            this.gbxLevelSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxLevelSelect.Controls.Add(this.rdBtnHard);
            this.gbxLevelSelect.Controls.Add(this.rdBtnMiddle);
            this.gbxLevelSelect.Controls.Add(this.rdBtnEasy);
            this.gbxLevelSelect.Controls.Add(this.btnStart);
            this.gbxLevelSelect.Controls.Add(this.lblLevel);
            this.gbxLevelSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbxLevelSelect.Location = new System.Drawing.Point(653, 28);
            this.gbxLevelSelect.Name = "gbxLevelSelect";
            this.gbxLevelSelect.Size = new System.Drawing.Size(200, 508);
            this.gbxLevelSelect.TabIndex = 2;
            this.gbxLevelSelect.TabStop = false;
            this.gbxLevelSelect.Text = "Seviye Seçme";
            // 
            // rdBtnHard
            // 
            this.rdBtnHard.AutoSize = true;
            this.rdBtnHard.BackColor = System.Drawing.Color.Transparent;
            this.rdBtnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnHard.ForeColor = System.Drawing.Color.Gold;
            this.rdBtnHard.Location = new System.Drawing.Point(27, 148);
            this.rdBtnHard.Name = "rdBtnHard";
            this.rdBtnHard.Size = new System.Drawing.Size(57, 24);
            this.rdBtnHard.TabIndex = 5;
            this.rdBtnHard.TabStop = true;
            this.rdBtnHard.Text = "Zor";
            this.rdBtnHard.UseVisualStyleBackColor = false;
            // 
            // rdBtnMiddle
            // 
            this.rdBtnMiddle.AutoSize = true;
            this.rdBtnMiddle.BackColor = System.Drawing.Color.Transparent;
            this.rdBtnMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnMiddle.ForeColor = System.Drawing.Color.Gold;
            this.rdBtnMiddle.Location = new System.Drawing.Point(27, 113);
            this.rdBtnMiddle.Name = "rdBtnMiddle";
            this.rdBtnMiddle.Size = new System.Drawing.Size(67, 24);
            this.rdBtnMiddle.TabIndex = 4;
            this.rdBtnMiddle.TabStop = true;
            this.rdBtnMiddle.Text = "Orta";
            this.rdBtnMiddle.UseVisualStyleBackColor = false;
            // 
            // rdBtnEasy
            // 
            this.rdBtnEasy.AutoSize = true;
            this.rdBtnEasy.BackColor = System.Drawing.Color.Transparent;
            this.rdBtnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnEasy.ForeColor = System.Drawing.Color.Gold;
            this.rdBtnEasy.Location = new System.Drawing.Point(27, 78);
            this.rdBtnEasy.Name = "rdBtnEasy";
            this.rdBtnEasy.Size = new System.Drawing.Size(76, 24);
            this.rdBtnEasy.TabIndex = 3;
            this.rdBtnEasy.TabStop = true;
            this.rdBtnEasy.Text = "Kolay";
            this.rdBtnEasy.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.Gold;
            this.btnStart.Location = new System.Drawing.Point(26, 184);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 31);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLevel.ForeColor = System.Drawing.Color.Gold;
            this.lblLevel.Location = new System.Drawing.Point(21, 44);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(160, 25);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Zorluk Seviyesi";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(145, 28);
            // 
            // anaSayfaToolStripMenuItem1
            // 
            this.anaSayfaToolStripMenuItem1.Name = "anaSayfaToolStripMenuItem1";
            this.anaSayfaToolStripMenuItem1.Size = new System.Drawing.Size(144, 24);
            this.anaSayfaToolStripMenuItem1.Text = "Ana Sayfa";
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvPlayers.Enabled = false;
            this.dgvPlayers.GridColor = System.Drawing.Color.DimGray;
            this.dgvPlayers.Location = new System.Drawing.Point(0, 28);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersWidth = 51;
            this.dgvPlayers.RowTemplate.Height = 24;
            this.dgvPlayers.Size = new System.Drawing.Size(552, 508);
            this.dgvPlayers.TabIndex = 4;
            // 
            // kelimeEkleToolStripMenuItem
            // 
            this.kelimeEkleToolStripMenuItem.Name = "kelimeEkleToolStripMenuItem";
            this.kelimeEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kelimeEkleToolStripMenuItem.Text = "Kelime Ekle";
            this.kelimeEkleToolStripMenuItem.Click += new System.EventHandler(this.kelimeEkleToolStripMenuItem_Click);
            // 
            // kelimeSilmeToolStripMenuItem
            // 
            this.kelimeSilmeToolStripMenuItem.Name = "kelimeSilmeToolStripMenuItem";
            this.kelimeSilmeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kelimeSilmeToolStripMenuItem.Text = "Kelime Silme";
            this.kelimeSilmeToolStripMenuItem.Click += new System.EventHandler(this.kelimeSilmeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(853, 536);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.gbxLevelSelect);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.gbxLevelSelect.ResumeLayout(false);
            this.gbxLevelSelect.PerformLayout();
            this.contextMenuStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilçeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyuncuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyuncuSilmeToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        public System.Windows.Forms.RadioButton rdBtnHard;
        public System.Windows.Forms.RadioButton rdBtnMiddle;
        public System.Windows.Forms.RadioButton rdBtnEasy;
        public System.Windows.Forms.GroupBox gbxLevelSelect;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.ToolStripMenuItem kelimeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelimeSilmeToolStripMenuItem;
    }
}


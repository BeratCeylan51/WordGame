namespace WordGame
{
    partial class PlayerAdd
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
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbxCities = new System.Windows.Forms.ComboBox();
            this.cbxDistricts = new System.Windows.Forms.ComboBox();
            this.rdBtnMan = new System.Windows.Forms.RadioButton();
            this.rdBtnWoman = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(131, 56);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(132, 22);
            this.tbxFirstName.TabIndex = 0;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(131, 106);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(132, 22);
            this.tbxLastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(49, 59);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(31, 16);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "İsim";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(49, 109);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 16);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Soyisim";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(49, 155);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 16);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "Şehir";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(49, 198);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(28, 16);
            this.lblDistrict.TabIndex = 5;
            this.lblDistrict.Text = "İlçe";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(49, 243);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 16);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Cinsiyet";
            // 
            // cbxCities
            // 
            this.cbxCities.FormattingEnabled = true;
            this.cbxCities.Location = new System.Drawing.Point(131, 155);
            this.cbxCities.Name = "cbxCities";
            this.cbxCities.Size = new System.Drawing.Size(132, 24);
            this.cbxCities.TabIndex = 7;
            this.cbxCities.SelectedIndexChanged += new System.EventHandler(this.cbxCities_SelectedIndexChanged);
            // 
            // cbxDistricts
            // 
            this.cbxDistricts.FormattingEnabled = true;
            this.cbxDistricts.Location = new System.Drawing.Point(131, 195);
            this.cbxDistricts.Name = "cbxDistricts";
            this.cbxDistricts.Size = new System.Drawing.Size(132, 24);
            this.cbxDistricts.TabIndex = 8;
            // 
            // rdBtnMan
            // 
            this.rdBtnMan.AutoSize = true;
            this.rdBtnMan.Location = new System.Drawing.Point(131, 243);
            this.rdBtnMan.Name = "rdBtnMan";
            this.rdBtnMan.Size = new System.Drawing.Size(64, 20);
            this.rdBtnMan.TabIndex = 9;
            this.rdBtnMan.TabStop = true;
            this.rdBtnMan.Text = "Adam";
            this.rdBtnMan.UseVisualStyleBackColor = true;
            // 
            // rdBtnWoman
            // 
            this.rdBtnWoman.AutoSize = true;
            this.rdBtnWoman.Location = new System.Drawing.Point(201, 243);
            this.rdBtnWoman.Name = "rdBtnWoman";
            this.rdBtnWoman.Size = new System.Drawing.Size(62, 20);
            this.rdBtnWoman.TabIndex = 10;
            this.rdBtnWoman.TabStop = true;
            this.rdBtnWoman.Text = "Kadın";
            this.rdBtnWoman.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(52, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 33);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PlayerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 372);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdBtnWoman);
            this.Controls.Add(this.rdBtnMan);
            this.Controls.Add(this.cbxDistricts);
            this.Controls.Add(this.cbxCities);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "PlayerAdd";
            this.Text = "PlayerAdd";
            this.Load += new System.EventHandler(this.PlayerAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbxCities;
        private System.Windows.Forms.ComboBox cbxDistricts;
        private System.Windows.Forms.RadioButton rdBtnMan;
        private System.Windows.Forms.RadioButton rdBtnWoman;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}
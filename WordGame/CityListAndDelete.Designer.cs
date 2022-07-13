namespace WordGame
{
    partial class CityListAndDelete
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
            this.dgvCities = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvDistricts = new System.Windows.Forms.DataGridView();
            this.btnDistrictDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistricts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCities
            // 
            this.dgvCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCities.Location = new System.Drawing.Point(30, 34);
            this.dgvCities.Name = "dgvCities";
            this.dgvCities.Size = new System.Drawing.Size(312, 150);
            this.dgvCities.TabIndex = 0;
            this.dgvCities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCities_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(267, 202);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "İl Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvDistricts
            // 
            this.dgvDistricts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDistricts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistricts.Location = new System.Drawing.Point(381, 34);
            this.dgvDistricts.Name = "dgvDistricts";
            this.dgvDistricts.Size = new System.Drawing.Size(285, 150);
            this.dgvDistricts.TabIndex = 3;
            // 
            // btnDistrictDelete
            // 
            this.btnDistrictDelete.Location = new System.Drawing.Point(591, 202);
            this.btnDistrictDelete.Name = "btnDistrictDelete";
            this.btnDistrictDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDistrictDelete.TabIndex = 4;
            this.btnDistrictDelete.Text = "İlçe Sil";
            this.btnDistrictDelete.UseVisualStyleBackColor = true;
            this.btnDistrictDelete.Click += new System.EventHandler(this.btnDistrictDelete_Click);
            // 
            // CityListAndDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 292);
            this.Controls.Add(this.btnDistrictDelete);
            this.Controls.Add(this.dgvDistricts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvCities);
            this.Name = "CityListAndDelete";
            this.Text = "CityListAndDelete";
            this.Load += new System.EventHandler(this.CityListAndDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistricts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCities;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDistricts;
        private System.Windows.Forms.Button btnDistrictDelete;
    }
}
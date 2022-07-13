using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordGame.DAL;

namespace WordGame
{
    public partial class CityListAndDelete : Form
    {
        public CityListAndDelete()
        {
            InitializeComponent();
        }

        CityDAL _cityDAL = new CityDAL();
        DistrictDAL _districtDAL = new DistrictDAL();
        private List<District> _districts;

        private void CityListAndDelete_Load(object sender, EventArgs e)
        {
            LoadCities();
        }

        private void LoadCities()
        {
            dgvCities.DataSource = _cityDAL.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCities.CurrentRow.Cells[0].Value);
            int cityCode = Convert.ToInt32(dgvCities.CurrentRow.Cells[1].Value);
            foreach (District district in _districts)
            {
                if (district.CityCode == cityCode)
                {
                    _districtDAL.Delete(district.Id);
                }
            }
            MessageBox.Show("İlçeler Silindi");
            _cityDAL.Delete(id);
            MessageBox.Show("Şehir Silindi");
            LoadCities();
            LoadDistricts();
        }

        private void dgvCities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDistricts();
        }

        private void LoadDistricts()
        {
            int cityCode = Convert.ToInt32(dgvCities.CurrentRow.Cells[1].Value);

            _districts = _districtDAL.GetAll(cityCode);

            dgvDistricts.DataSource = _districts;
        }

        private void btnDistrictDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDistricts.CurrentRow.Cells[0].Value);

            _districtDAL.Delete(id);
            LoadCities();
            LoadDistricts();
            MessageBox.Show("İlçe Silindi");
        }
    }
}

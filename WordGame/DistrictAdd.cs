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
    public partial class DistrictAdd : Form
    {
        public DistrictAdd()
        {
            InitializeComponent();
        }

        CityDAL _cityDAL = new CityDAL();
        DistrictDAL _districtDAL = new DistrictDAL();
        private List<City> cities;
        private List<District> districts;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DistrictAdd_Load(object sender, EventArgs e)
        {
            cities = _cityDAL.GetAll();
            
            cities.ForEach(city => cbxCities.Items.Add(city.CityName));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = true;
            int cityCode = 0;
            foreach (City city in cities)
            {
                if (cbxCities.SelectedItem.ToString().ToLower() == city.CityName.ToLower())
                {
                    cityCode = city.CityCode;
                    districts = _districtDAL.GetAll(city.CityCode);
                    foreach (District district in districts)
                    {
                        if (district.DistrictName.ToLower() == tbxDistrict.Text.ToLower())
                        {
                            check = false;
                            MessageBox.Show("Girilen İlçe Listede Var");
                            break;
                        }
                    }
                }
            }
            if (check)
            {
                _districtDAL.Add(new District
                {
                    CityCode = cityCode,
                    DistrictName = tbxDistrict.Text,
                });
                tbxDistrict.Clear();
                MessageBox.Show("İlçe Başarıyla Eklendi");
            }
        }
    }
}

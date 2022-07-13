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
    public partial class CityAdd : Form
    {
        public CityAdd()
        {
            InitializeComponent();
        }

        CityDAL _cityDAL = new CityDAL();
        List<City> _cities;
        private void CityAdd_Load(object sender, EventArgs e)
        {
            _cities = _cityDAL.GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach (City city in _cities)
            {
                if (city.CityName.ToLower() == tbxCity.Text.ToLower())
                {
                    check = false;
                    MessageBox.Show("Girilen Şehir Listede Var");
                }
                else if (city.CityCode == Convert.ToInt32(tbxCityCode.Text))
                {
                    check = false;
                    MessageBox.Show("Girilen Şehir Kodu Listede Var");
                }
            }
            if (check)
            {
                _cityDAL.Add(new City
                {
                    CityCode = Convert.ToInt32(tbxCityCode.Text),
                    CityName = tbxCity.Text,
                });
                tbxCity.Clear();
                tbxCityCode.Clear();
                MessageBox.Show("Şehir Başarıyla Eklendi");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

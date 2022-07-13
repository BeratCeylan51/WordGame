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
    public partial class PlayerAdd : Form
    {
        public PlayerAdd()
        {
            InitializeComponent();
        }

        CityDAL _cityDAL = new CityDAL();
        DistrictDAL _districtDAL = new DistrictDAL();
        PlayerDAL _playerDAL = new PlayerDAL();
        private List<PlayerList> _playerList;
        private List<City> _cityList;
        private List<District> _districtList;
        private void PlayerAdd_Load(object sender, EventArgs e)
        {
            _cityList = _cityDAL.GetAll();
            _cityList.ForEach(city => cbxCities.Items.Add(city.CityName));

            _playerList = _playerDAL.GetAll();
        }

        private void cbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDistricts.Items.Clear();
            foreach (City city in _cityList)
            {
                if (cbxCities.SelectedItem.ToString().ToLower() == city.CityName.ToLower())
                {
                    _districtList = _districtDAL.GetAll(city.CityCode);
                }
            }
            _districtList.ForEach(district => cbxDistricts.Items.Add(district.DistrictName));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach (PlayerList playerList in _playerList)
            {
                if (playerList.FirstName.ToLower() == tbxFirstName.Text.ToLower() && playerList.LastName.ToLower() == tbxLastName.Text.ToLower())
                {
                    check = false;
                    MessageBox.Show("Girilen Kişi Listede Var");
                    break;
                }
            }
            if (check)
            {
                int cityCode = 0;
                int districtId = 0;
                foreach (City city in _cityList)
                {
                    if (cbxCities.SelectedItem.ToString().ToLower() == city.CityName.ToLower())
                    {
                        cityCode = city.CityCode;
                        break;
                    }
                }

                foreach (District district in _districtList)
                {
                    if (cbxDistricts.SelectedItem.ToString().ToLower() == district.DistrictName.ToLower())
                    {
                        districtId = district.Id;
                        break;
                    }
                }
                _playerDAL.Add(new Player
                {
                    FirstName = tbxFirstName.Text,
                    LastName = tbxLastName.Text,
                    CityCode = cityCode,
                    DistrictId = districtId,
                    Gender = (rdBtnMan.Checked == true ? 1 : 0)
                });
                tbxFirstName.Clear();
                tbxLastName.Clear();
                MessageBox.Show("Oyuncu Eklendi");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame.DAL
{
    public class DistrictDAL
    {
        SqlConnection _connection = ConnectionSettings.Connection();

        private void ConnectionControl()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı bağlantı hatası " + ex.Message);
            }
        }

        public List<District> GetAll(int cityCode)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Districts where CityCode=@cityCode", _connection);

            command.Parameters.AddWithValue("@cityCode", cityCode);
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();

            List<District> districts = new List<District>();

            while (reader.Read())
            {
                District district = new District
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CityCode = Convert.ToInt32(reader["CityCode"]),
                    DistrictName = reader["DistrictName"].ToString(),
                };
                districts.Add(district);
            }
            reader.Close();
            _connection.Close();

            return districts;
        }

        public string GetDistrict(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select DistrictName from Districts Where Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();

            string value = "";

            if (reader.Read())
            {
                District district = new District
                {
                    DistrictName = reader["DistrictName"].ToString(),
                };
                value = district.DistrictName;
            }

            _connection.Close();

            return value;
        }

        public void Add(District district)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("insert into Districts values (@cityCode, @districtName)", _connection);

            command.Parameters.AddWithValue("@cityCode", district.CityCode);
            command.Parameters.AddWithValue("@districtName", district.DistrictName);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("delete from Districts where Id = @id", _connection);

            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}

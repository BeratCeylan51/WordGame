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
    public class CityDAL
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

        public List<City> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Cities", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<City> cities = new List<City>();

            while (reader.Read())
            {
                City city = new City
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CityCode = Convert.ToInt32(reader["CityCode"]),
                    CityName = reader["CityName"].ToString(),
                };
                cities.Add(city);
            }
            reader.Close();
            _connection.Close();
            return cities;
        }

        public string GetCity(int cityCode)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select CityName from Cities Where CityCode=@cityCode", _connection);

            command.Parameters.AddWithValue("@cityCode", cityCode);
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();

            string value = "";

            if (reader.Read())
            {
                City city = new City
                {
                    CityName = reader["CityName"].ToString(),
                };
                value = city.CityName;
            }

            _connection.Close();

            return value;
        }

        public void Add(City city)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("insert into Cities values (@cityCode, @cityName)", _connection);

            command.Parameters.AddWithValue("@cityCode", city.CityCode);
            command.Parameters.AddWithValue("@cityName", city.CityName);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("delete from Cities where Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}

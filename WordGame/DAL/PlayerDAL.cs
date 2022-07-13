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
    public class PlayerDAL
    {
        SqlConnection _connection = ConnectionSettings.Connection();
        CityDAL _cityDAL = new CityDAL();
        DistrictDAL _districtDAL = new DistrictDAL();

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
                MessageBox.Show("Veri Tabanı Bağlantı Hatası " + ex.Message);
            }
        }

        public List<PlayerList> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("select * from Players", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<PlayerList> players = new List<PlayerList>();

            while (reader.Read())
            {
                PlayerList playerLİst = new PlayerList
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    CityCode = _cityDAL.GetCity(Convert.ToInt32(reader["CityCode"])),
                    DistrictId = _districtDAL.GetDistrict(Convert.ToInt32(reader["DistrictId"])),
                    Gender = string.Format(Convert.ToInt16(reader["Gender"]) == 1 ? "Erkek" : "Kadın"),
                };
                players.Add(playerLİst);
            }

            reader.Close();
            _connection.Close();

            return players;
        }

        public void Add(Player player)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("insert into Players values (@firstName, @lastName, @cityCode, @districtId, @gender)", _connection);

            command.Parameters.AddWithValue("@firstName", player.FirstName);
            command.Parameters.AddWithValue("@lastName", player.LastName);
            command.Parameters.AddWithValue("@cityCode", player.CityCode);
            command.Parameters.AddWithValue("@districtId", player.DistrictId);
            command.Parameters.AddWithValue("@gender", player.Gender);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("delete from Players where Id = @id", _connection);

            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}

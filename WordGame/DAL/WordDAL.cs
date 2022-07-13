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
    public class WordDAL
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

        public List<Word> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("select * from Words", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Word> result = new List<Word>();

            while (reader.Read())
            {
                Word word = new Word
                {
                    Id = reader.GetInt32(0),
                    Level = reader.GetInt32(1), //Convert.ToInt32(reader["Level"]),
                    _Word = reader["Word"].ToString(),
                };
                result.Add(word);
            }
            reader.Close();
            _connection.Close();

            return result;
        }

        public List<string> GetLevelAll(int level)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("select Word from Words where Level = @level", _connection);

            command.Parameters.AddWithValue("@level", level);
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();

            List<string> result = new List<string>();

            while (reader.Read())
            {
                Word word = new Word
                {
                    _Word = reader["Word"].ToString(),
                };
                result.Add(word._Word);
            }
            reader.Close();
            _connection.Close();

            return result;
        }

        public void Add(Word word)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("insert into Words values (@level, @word)", _connection);
            
            command.Parameters.AddWithValue("@level", word.Level);
            command.Parameters.AddWithValue("@word", word._Word);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("delete from Words where Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}

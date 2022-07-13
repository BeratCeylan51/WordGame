using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public static class ConnectionSettings
    {
        private static SqlConnection _connection;
        public static SqlConnection Connection()
        {
            _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog= WordGame; integrated security=true");

            return _connection;
        }
    }
}

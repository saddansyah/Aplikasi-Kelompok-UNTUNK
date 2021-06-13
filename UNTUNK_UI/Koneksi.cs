using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DashboardUNTUNK
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();;
            Conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\UNTUNK_DRAFT1\\UNTUNK_UI\\Database_UNTUNK.mdf;Integrated Security=True";
            return Conn;

        }
    }
}

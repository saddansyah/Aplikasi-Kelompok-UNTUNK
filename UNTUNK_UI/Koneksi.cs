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
            /*
             * 
             * ConnectionString depends on your database's datasource on database properties.
             * 
             * 
             */


            SqlConnection Conn = new SqlConnection();;
            //Conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\UNTUNK_DRAFT1\\UNTUNK_UI\\Database_UNTUNK.mdf;Integrated Security=True";
            Conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\[code] UNTUNK\\remastered\\UNTUNK_UI\\Aplikasi-Kelompok-UNTUNK\\UNTUNK_UI\\Database_UNTUNK.mdf;Integrated Security=True";
            return Conn;

        }
    }
}

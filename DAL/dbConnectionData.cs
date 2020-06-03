using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class dbConnectionData
    {
        public static SqlConnection ketnoi()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=QUANG\SQLEXPRESS;Initial Catalog=QLDiem_SV;Integrated Security=True");
            return Conn;
        }
    }
}

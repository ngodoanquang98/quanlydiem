using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class dalNhatKy
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("select * from NhatKy", Conn);
            //command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertNK(tblNhatKy gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("themnhatky", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);            
            command.Parameters["@MaGV"].Value = gv.MaGV1;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
      
        
    }
}

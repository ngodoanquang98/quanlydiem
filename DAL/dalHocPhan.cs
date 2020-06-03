using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class dalHocPhan
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_HocPhan_SelectAll", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertHP(tblHocPhan hp)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_HocPhan_Insert", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHP", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@TenHP", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@SoTC", SqlDbType.Int, 10);
            command.Parameters["@MaHp"].Value = hp.MaHP1;
            command.Parameters["@TenHP"].Value = hp.TenHP1;
            command.Parameters["@SoTC"].Value = hp.SoTC1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateHP(tblHocPhan hp)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_HocPhan_Update", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHP", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@TenHP", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@SoTC", SqlDbType.Int, 10);
            command.Parameters["@MaHp"].Value = hp.MaHP1;
            command.Parameters["@TenHP"].Value = hp.TenHP1;
            command.Parameters["@SoTC"].Value = hp.SoTC1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteHP(string mahp)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_HocPhan_Delete", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHP", SqlDbType.NVarChar, 10);
            command.Parameters["@MaHp"].Value = mahp;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        public static DataTable SreachHP(string mahp)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("select * from hocphan where tenhp like '%"+mahp+"%'", Conn);
         
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;

        }
    }

}

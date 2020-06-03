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
    public class balDangKi
    {
        public static DataTable getData(string gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_dangki_SelectAll", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ma", SqlDbType.NVarChar, 10);        
            command.Parameters["@ma"].Value = gv;

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertL(tblDangki gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("dangkihoc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLopHP", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@maSV", SqlDbType.NVarChar, 100);
           
            command.Parameters["@MaLopHP"].Value = gv.MaLopHP1;
            command.Parameters["@MaSV"].Value = gv.MaSV1;
        
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable Khoa()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("select * from SinhVien", Conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static DataTable LHP()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("select * from lophocphan", Conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
    }
}

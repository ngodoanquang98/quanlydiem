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
    public class dalLop
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_Lop_SelectAll", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertL(tblLop gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_Lop_Insert", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@TenLop", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@SiSo", SqlDbType.Int, 10);
            command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@NienKhoa", SqlDbType.NVarChar, 100);
            command.Parameters["@MaLop"].Value = gv.MaLop1;
            command.Parameters["@TenLop"].Value = gv.TenLop1;
            command.Parameters["@SiSo"].Value = gv.SiSo1;
            command.Parameters["@MaKhoa"].Value = gv.MaKhoa1;
            command.Parameters["@NienKhoa"].Value = gv.NienKhoa1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateL(tblLop gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_Lop_Update", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@TenLop", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@SiSo", SqlDbType.Int, 10);
            command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@NienKhoa", SqlDbType.NVarChar, 100);
            command.Parameters["@MaLop"].Value = gv.MaLop1;
            command.Parameters["@TenLop"].Value = gv.TenLop1;
            command.Parameters["@SiSo"].Value = gv.SiSo1;
            command.Parameters["@MaKhoa"].Value = gv.MaKhoa1;
            command.Parameters["@NienKhoa"].Value = gv.NienKhoa1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteL(string mal)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_Lop_Delete", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
            command.Parameters["@MaLop"].Value = mal;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        public static DataTable SreachL(string mal)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("select * from Lop where tenLop like '%" + mal + "%'", Conn);

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;

        }
        public static DataTable Khoa()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("select * from khoa", Conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
    }
}

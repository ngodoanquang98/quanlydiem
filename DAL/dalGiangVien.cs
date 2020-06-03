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
    public class dalGiangVien
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_GiangVien_SelectAll", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertGV(tblGiangVien gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_GiangVien_Insert", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@SDT", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@HocVi", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 10);
            command.Parameters["@MaGV"].Value = gv.MaGV1;
            command.Parameters["@HoTen"].Value = gv.HoTen1;
            command.Parameters["@SDT"].Value = gv.SDT1;
            command.Parameters["@HocVi"].Value = gv.HocVi1;
            command.Parameters["@MaKhoa"].Value = gv.MaKhoa1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateGV(tblGiangVien gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_GiangVien_Update", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@SDT", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@HocVi", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 10);
            command.Parameters["@MaGV"].Value = gv.MaGV1;
            command.Parameters["@HoTen"].Value = gv.HoTen1;
            command.Parameters["@SDT"].Value = gv.SDT1;
            command.Parameters["@HocVi"].Value = gv.HocVi1;
            command.Parameters["@MaKhoa"].Value = gv.MaKhoa1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteGV(string magv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_GiangVien_Delete", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
            command.Parameters["@MaGV"].Value = magv;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        public static DataTable SreachGV(string magv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("select * from giangvien where hoten like '%" + magv + "%'", Conn);

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

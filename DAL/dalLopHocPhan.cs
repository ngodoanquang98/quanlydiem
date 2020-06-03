using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
     public class dalLopHocPhan
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_LopHocPhan_SelectAll", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertLHP(tblLopHocPhan gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_LopHocPhan_Insert", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@malophp", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@PhongHoc", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@TongSoSV", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TietBatDau", SqlDbType.Int, 10);
            command.Parameters.Add("@TietKetThuc", SqlDbType.Int, 100);
            command.Parameters.Add("@Thu", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaHP", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@MaHK", SqlDbType.NVarChar, 10);

            command.Parameters["@MaLopHP"].Value = gv.MaLopHP1;
            command.Parameters["@PhongHoc"].Value = gv.PhongHoc1;
            command.Parameters["@TongSoSV"].Value = gv.TongSoSV1;
            command.Parameters["@TietBatDau"].Value = gv.TietBatDau1;
            command.Parameters["@TietKetThuc"].Value = gv.TietKetThuc1;
            command.Parameters["@Thu"].Value = gv.Thu1;
            command.Parameters["@MaHP"].Value = gv.MaHP1;
            command.Parameters["@MaGV"].Value = gv.MaGV1;
            command.Parameters["@MaHK"].Value = gv.MaHK1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateLHP(tblLopHocPhan gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_LopHocPhan_Update", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLopHP", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@PhongHoc", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@TongSoSV", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TietBatDau", SqlDbType.Int, 10);
            command.Parameters.Add("@TietKetThuc", SqlDbType.Int, 100);
            command.Parameters.Add("@Thu", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaHP", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@MaHK", SqlDbType.NVarChar, 10);

            command.Parameters["@MaLopHP"].Value = gv.MaLopHP1;
            command.Parameters["@PhongHoc"].Value = gv.PhongHoc1;
            command.Parameters["@TongSoSV"].Value = gv.TongSoSV1;
            command.Parameters["@TietBatDau"].Value = gv.TietBatDau1;
            command.Parameters["@TietKetThuc"].Value = gv.TietKetThuc1;
            command.Parameters["@Thu"].Value = gv.Thu1;
            command.Parameters["@MaHP"].Value = gv.MaHP1;
            command.Parameters["@MaGV"].Value = gv.MaGV1;
            command.Parameters["@MaHK"].Value = gv.MaHK1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteLHP(string ma)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_LopHocPhan_Delete", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLopHP", SqlDbType.NVarChar, 10);
            command.Parameters["@MaLopHP"].Value = ma; ;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable SreachLHP(string magv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("select * from LopHocPhan where phonghoc like '%" + magv + "%'", Conn);

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;

        }
        public static DataTable LopHP()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("select * from LopHocPhan", Conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static DataTable SL()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("select count(*) as a from LopHocPhan ", Conn);

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

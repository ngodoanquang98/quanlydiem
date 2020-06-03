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
    public class dalSinhVien
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_SinhVien_SelectAll", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertSV(tblSinhVien gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_SinhVien_Insert", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSV", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@NgaySinh", SqlDbType.DateTime, 50);
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DiaChiHT", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@SoTinChiDaDat", SqlDbType.Int, 10);
            command.Parameters.Add("@DiemTichLuy", SqlDbType.Float, 10);
            command.Parameters.Add("@SoTinChiDaDKi", SqlDbType.Int, 10);
            command.Parameters["@MaSV"].Value = gv.MaSV1;
            command.Parameters["@HoTen"].Value = gv.HoTen1;
            command.Parameters["@NgaySinh"].Value = gv.NgaySinh1;
            command.Parameters["@GioiTinh"].Value = gv.GioiTinh1;
            command.Parameters["@QueQuan"].Value = gv.QueQuan1;
            command.Parameters["@DiaChiHT"].Value = gv.DiaChiHT1;
            command.Parameters["@MaLop"].Value = gv.MaLop1;
            command.Parameters["@SoTinChiDaDat"].Value = gv.SoTinChiDaDat1;
            command.Parameters["@DiemTichLuy"].Value = gv.DiemTichLuy1;
            command.Parameters["@SoTinChiDaDKi"].Value = gv.SoTinChiDaDKi1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateSV(tblSinhVien gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_SinhVien_Update", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSV", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@NgaySinh", SqlDbType.DateTime, 50);
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DiaChiHT", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@SoTinChiDaDat", SqlDbType.Int, 10);
            command.Parameters.Add("@DiemTichLuy", SqlDbType.Float, 10);
            command.Parameters.Add("@SoTinChiDaDKi", SqlDbType.Int, 10);
            command.Parameters["@MaSV"].Value = gv.MaSV1;
            command.Parameters["@HoTen"].Value = gv.HoTen1;
            command.Parameters["@NgaySinh"].Value = gv.NgaySinh1;
            command.Parameters["@GioiTinh"].Value = gv.GioiTinh1;
            command.Parameters["@QueQuan"].Value = gv.QueQuan1;
            command.Parameters["@DiaChiHT"].Value = gv.DiaChiHT1;
            command.Parameters["@MaLop"].Value = gv.MaLop1;
            command.Parameters["@SoTinChiDaDat"].Value = gv.SoTinChiDaDat1;
            command.Parameters["@DiemTichLuy"].Value = gv.DiemTichLuy1;
            command.Parameters["@SoTinChiDaDKi"].Value = gv.SoTinChiDaDKi1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteSV(string ma)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_SinhVien_Delete", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSV", SqlDbType.NVarChar, 10);
            command.Parameters["@MaSV"].Value = ma; 

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable SreachSV(string magv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("select * from SinhVien where hoten like '%" + magv + "%'", Conn);

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;

        }
        public static DataTable Lop()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("select * from Lop", Conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static DataTable SreachL(string magv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("select * from SinhVien s,Lop l where s.Malop=l.Malop and l.malop="+magv, Conn);

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

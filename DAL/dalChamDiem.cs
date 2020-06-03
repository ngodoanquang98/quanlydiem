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
    public class dalChamDiem
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_KetQuaLHP_SelectAll", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertL(tblKetQuaLHP gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_KetQuaLHP_Insert", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLopHP", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@MaSV", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DiemCC", SqlDbType.Float, 10);
            command.Parameters.Add("@DiemTX", SqlDbType.Float, 10);
            command.Parameters.Add("@DiemThi", SqlDbType.Float, 100);
            command.Parameters["@MaLopHP"].Value = gv.MaLopHP1;
            command.Parameters["@MaSV"].Value = gv.MaSV1;
            command.Parameters["@DiemCC"].Value = gv.DiemCC1;
            command.Parameters["@DiemTX"].Value = gv.DiemTX1;
            command.Parameters["@DiemThi"].Value = gv.DiemThi1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateL(tblKetQuaLHP gv)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_KetQuaLHP_Update", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLopHP", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@MaSV", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DiemCC", SqlDbType.Float, 10);
            command.Parameters.Add("@DiemTX", SqlDbType.Float, 10);
            command.Parameters.Add("@DiemThi", SqlDbType.Float, 100);
            command.Parameters["@MaLopHP"].Value = gv.MaLopHP1;
            command.Parameters["@MaSV"].Value = gv.MaSV1;
            command.Parameters["@DiemCC"].Value = gv.DiemCC1;
            command.Parameters["@DiemTX"].Value = gv.DiemTX1;
            command.Parameters["@DiemThi"].Value = gv.DiemThi1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteL(string mal)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("pr_KetQuaLHP_Delete", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLopHP", SqlDbType.NVarChar, 10);
            command.Parameters["@MaLopHP"].Value = mal;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable SreachL(string mal)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("select * from KetQuaLHP where MaLopHP='" + mal+"'", Conn);

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
        public static DataTable Khoa1()
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
    }
}

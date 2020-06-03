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
    public class dalXemDiem
    {
        public static DataTable getDuLieu()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("xem_diemfll", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static DataTable getData(string a)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("xem_diem", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@masv", SqlDbType.NVarChar, 10);
            command.Parameters["@masv"].Value = a;
         
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static DataTable getData2(string ac,string bc)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("xeploai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@masv", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@mahk", SqlDbType.NVarChar, 10);
            command.Parameters["@masv"].Value = ac;
            command.Parameters["@mahk"].Value = bc;

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static DataTable LHP1()
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("select * from Hocky", Conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static DataTable getData3(string a)
        {
            SqlConnection Conn = dbConnectionData.ketnoi();
            SqlCommand command = new SqlCommand("hockkk", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@masv", SqlDbType.NVarChar, 10);
            command.Parameters["@masv"].Value = a;

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

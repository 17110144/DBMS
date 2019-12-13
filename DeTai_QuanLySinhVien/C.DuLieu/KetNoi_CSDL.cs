using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace C.DuLieu
{
    class KetNoi_CSDL
    {
        private string LuaChon = ConfigurationManager.AppSettings["LuaChon"].ToString();
        private string clsKetNoi;
        SqlConnection con = new SqlConnection();
           
        
        public KetNoi_CSDL()
        {
            if (LuaChon.Equals("Sử Dụng Tài Khoản"))
            {
                clsKetNoi = @"data source=" + ConfigurationManager.AppSettings["Server"].ToString() + ";initial catalog=QLSINHVIEN;user id=" + ConfigurationManager.AppSettings["Username"].ToString() + ";password=" + ConfigurationManager.AppSettings["Password"].ToString() + "";
            }
            if (LuaChon.Equals("Không Dùng Tài Khoản"))
            {
                clsKetNoi = @"data source=" + ConfigurationManager.AppSettings["Server"].ToString() + ";initial catalog=QLSINHVIEN; integrated security=True;";
            }
            con.ConnectionString = clsKetNoi;
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public DataTable LayDuLieu(string sql)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable LayDuLieuTuView(string sql)
        {
            DataSet data = new DataSet();
            string query = "select * from " + sql + ";";
            using (con)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, clsKetNoi);
                adapter.Fill(data);
            }
            return data.Tables[0];
        }

        public SqlDataReader LayAnh(string sql, string[] name, object[] value, int Nparameter)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparameter; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public DataTable TimKiem(string sql, string[] name, object[] value, int Nparameter)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparameter; i++)
			{
                command.Parameters.AddWithValue(name[i], value[i]);
			}
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //public int CapNhat(string sql)
        //{
        //    SqlCommand command = new SqlCommand(sql, con);
        //    command.CommandType = CommandType.StoredProcedure;
        //    return command.ExecuteNonQuery();
        //}

        public int CapNhat(string sql, string[] name, object[] value, int Nparameter)
        {
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparameter; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            return command.ExecuteNonQuery();
        }
    }
}

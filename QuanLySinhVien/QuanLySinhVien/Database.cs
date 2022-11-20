using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class Database
    {
        
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
        private SqlConnection conn;
        private string sql;
        private DataTable dt;
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                conn=new SqlConnection(connectionString);
            }
            catch(Exception ex)
            {
                MessageBox.Show("connection failed"+ ex.Message);
            }
        }
        public DataTable SelectData(string sql,List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                //sql = "exec SelectAllSinhVien";
                cmd=new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd= new SqlCommand(sql,conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu chi tiết" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public int ExeCute(string sql,List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                Console.WriteLine("Trà về"+rs);
                return (int)rs;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thực thi:" + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

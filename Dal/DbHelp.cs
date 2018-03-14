using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
namespace Dal
{
   public  class DbHelp
    {
        static string strConn = ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString;
         static SqlConnection conn = new SqlConnection(strConn);
        public static void Open()
        {
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
        }
        public static void Close()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
                conn.Close();
        }
        public static DataSet GetDataSet(string strSql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            da.Fill(ds);
            return ds;
        }

        public static int ExecuteNonQuary(string quary, SqlParameter[] p = null)
        {
            SqlCommand cm = new SqlCommand(quary, conn);
            if (p != null)
            {
                cm.Parameters.AddRange(p);
            }
            try
            {
                Open();
                try
                {
                    return cm.ExecuteNonQuery();
                }
                catch
                {
                    return -1;
                }
            }
            catch
            {
                return -2;
            }
            finally
            {
                cm.Dispose();
                Close();
            }
        }
        public static SqlDataReader ExecuteDataReader(string strSql, params SqlParameter[] p)
        {
            SqlDataReader dr = null;
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.Parameters.AddRange(p);
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dr;
        }
        public static object ExecuteScalar(string strsql,params SqlParameter[] p)
        {
            object obj = null;
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand(strsql, conn);
                cmd.Parameters.AddRange(p);
                 obj = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                
            }
            finally
            {
                Close();
            }
            return obj;
        }

    }
}

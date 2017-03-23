using System;
using System.Web.Services;
using MySql.Data.MySqlClient;

namespace FinalProject.Web
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class connection : System.Web.Services.WebService
    {
        string constr = "server=127.0.0.1;port=3307;user=root;pwd=12345;database=register;";

        [WebMethod]
        public string ExecuteScalar(string sql) //This method is simple. Get a single object from MySQL. (SELECT)
        {
            try
            {
                string result = "";
                using (MySqlConnection conn = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        result = cmd.ExecuteScalar() + "";
                        conn.Close();
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        public string ExecuteNonQuery(string sql) //For single SQL execution. Example of SQL type: INSERT, UPDATE, DELETE.
        {
            try
            {
                long i = 0;
                using (MySqlConnection conn = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        i = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                return i + " row(s) affected by the last command, no resultset returned.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
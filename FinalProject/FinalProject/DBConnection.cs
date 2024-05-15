using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class DBConnection
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.ConnStr);
        public DBConnection() { }
        public void Excude(SqlCommand cmd)
        {
            try
            {
                // Ket noi
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Successful!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail!!!" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

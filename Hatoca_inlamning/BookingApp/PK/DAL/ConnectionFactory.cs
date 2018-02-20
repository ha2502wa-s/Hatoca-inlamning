using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingApp.PK.DAL
{
   public class ConnectionFactory
    {
        private static readonly string URL = "Data Source=LAPTOP-SCJU4H3Q;Initial Catalog=hatoca-inlamning;Integrated Security= SSPI;User ID=hatoca;Password=hatoca123;";

        public static SqlConnection GetConnection()
        { try
            { SqlConnection conn = new SqlConnection(URL);
                conn.Open();
                return conn;
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Kunde inte ansulta till \"" + URL + "\" , verifiera att databsen är startad.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            return null;
        }
    }
}

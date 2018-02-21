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
       /* string connectionString = "Data Source=LAPTOP-SCJU4H3Q;Initial Catalog=hatoca-inlamning;Integrated Security= SSPI;User ID=hatoca;Password=hatoca123;";
		SqlConnection conn;

        public void OpenConnection()
        { try
            {
				conn = new SqlConnection(connectionString);
				conn.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show("Kunde inte ansulta till \"" + connectionString + "\" , verifiera att databsen är startad.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }

		public void CloseConnection()
		{
			conn.Close();
		}

		/*public void ExecuteQueries(string Query) // Tror inte vi behöver denna faktiskt
		{
			SqlCommand cmd = new SqlCommand(Query, conn);
			cmd.ExecuteNonQuery();
		}*/

	}
}

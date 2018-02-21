using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookingApp
{
    public partial class BookingApp : Form
	{

        public BookingApp()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}


		private void Botton_Add_SesInfo_Click(object sender, EventArgs e)
        {
         /*
            string cs = null;
            SqlConnection cnn = new SqlConnection(cs);
            SqlCommand cmd;
            string sql = null;

            cs = "Data Source=LAPTOP-SCJU4H3Q;Initial Catalog=hatoca-inlamning;Integrated Security= SSPI;User ID=hatoca;Password=hatoca123;";

            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
                MessageBox.Show("ExecuteNonQuery in SqlCommand executed!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open SqlConnection!");*/
            }


		//  TextB_SesID_SesInfo.Text + "','" + TextB_Title_SesInfo.Text + "','" + Date_Time_Date_SesInfo.Value + "','" + TextB_Spots_SesInfo.Text + "','" + TextB_Instructor_SesInfo.Text+ ")";
	}
    }


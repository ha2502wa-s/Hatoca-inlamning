using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Booking;
using Booking.WebServiceRef;
using BookingApp.PK.Controller;

namespace HatocaGymBooking
{

	public partial class BookingApp : Form
	{
		
		ControllerWS controllerWS = new ControllerWS();
		Booking.WebServiceRef.WebServiceSoapClient client = new Booking.WebServiceRef.WebServiceSoapClient();

		public BookingApp()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}


		private void Botton_Add_SesInfo_Click(object sender, EventArgs e)
		{
			BookingAppContext bc = new BookingAppContext();
			Gymsession g = new Gymsession();
			g.gid = TextB_SesID_SesInfo.Text;
			g.gtitle = TextB_Title_SesInfo.Text;
			g.gdate = Date_Time_Date_SesInfo.Text;
			g.gmax_spots = TextB_Spots_SesInfo.Text;
			g.ginstructor = TextB_Instructor_SesInfo.Text;

			try
			{
				bc.Gymsessions.Add(g);
				bc.SaveChanges();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Varning det blev fel");
			}



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

		private void btn_getFileContent_WS_Click(object sender, EventArgs e)
		{
			try
			{
				FolderBrowserDialog b = new FolderBrowserDialog();
				OpenFileDialog of = new OpenFileDialog();
				of.Filter = "Text Fil (.txt)|*.txt";
				of.Multiselect = false;

				if (of.ShowDialog() == DialogResult.OK)
				{
					text_FilePath_WS.Text = "File Path: " + of.FileName;
					textb_Content_WS.Text = controllerWS.GetFileContent(of.FileName);
				}
			}
			catch (Exception ex)
			{
				//label2.Text = "Meddelande: " + ex.StackTrace;
			}
		}


			//  TextB_SesID_SesInfo.Text + "','" + TextB_Title_SesInfo.Text + "','" + Date_Time_Date_SesInfo.Value + "','" + TextB_Spots_SesInfo.Text + "','" + TextB_Instructor_SesInfo.Text+ ")";
		}
	}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hatoca_inlamning
{


	public partial class Application : Form
	{

		public Application()
        {
            InitializeComponent();
        }
			private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Text_Time_SesInfo_PK_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextB_SesID_SesInfo_PK_TextChanged(object sender, EventArgs e)
        {

        }

        private void Botton_Add_SesInfo_PK_Click(object sender, EventArgs e)
        {
			SqlConnection cs = new SqlConnection("Data Source=LAPTOP-SCJU4H3Q; Initial Catalog=hatoca-inlamning; Integrated Security: TRUE");
			cs.Open();
			MessageBox.Show(cs.State.ToString());
			cs.Close();
        }

		private void Application_Load(object sender, EventArgs e)
		{

		}
	}
}

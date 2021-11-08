using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TakipSistemi
{
    public partial class Form2 : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source=DESKTOP-I66S1RK;Initial Catalog=Employee;Integrated Security=True");
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonArttır_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update Table_Employee set Maas=Maas+@p1 where TcNo=@p2", SqlConnection);
            SqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@p1", maskedDegisim.Text);
            sqlCommand.Parameters.AddWithValue("@p2", maskedTcNo3.Text);
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("Maaş Artırıldı!");
        }

        private void buttonAzalt_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update Table_Employee set Maas=Maas-@p1 where TcNo=@p2", SqlConnection);
            SqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@p1", maskedDegisim.Text);
            sqlCommand.Parameters.AddWithValue("@p2", maskedTcNo3.Text);
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("Maaş Azaltıldı!");
        }


    }
}

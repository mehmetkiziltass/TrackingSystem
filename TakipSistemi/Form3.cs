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
    public partial class Form3 : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-I66S1RK;Initial Catalog=Employee;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonIstenCikar_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("delete from Table_Employee where TcNo=@p1", sqlConnection);
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@p1", maskedTcNo3.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kayıt Silme Başarılı!");
        }

    }
}

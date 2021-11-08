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
    public partial class Form5 : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-I66S1RK;Initial Catalog=Employee;Integrated Security=True");  
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select Ad,Soyad,Maas from Table_Employee where Maas =(select max(Maas) as 'Toplam' from Table_Employee)", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridEnYuksekMaas.DataSource = dt;
            sqlConnection.Close();

        }

   
    }
}

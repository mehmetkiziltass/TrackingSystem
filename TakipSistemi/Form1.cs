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
    public partial class Form1 : System.Windows.Forms.Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source=DESKTOP-I66S1RK;Initial Catalog=Employee;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.table_EmployeeTableAdapter.Fill(this.employeeDataSet.Table_Employee);
        }

        private void buttonKaydet_Click(object sender, EventArgs e)//Bilgileri girilen kullaniciyi DB'ye kaydeder.
        {
            if(alanKontrol() == true)
            {
                return;
            }
      
            SqlCommand sqlCommand = new SqlCommand("insert into Table_Employee(TcNo,Ad,Soyad,Telefon,Meslek,Sehir,Maas,BaslamaTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",SqlConnection);
            SqlConnection.Open();

            try
            {
                sqlCommand.Parameters.AddWithValue("@p1", maskedTcNo.Text);
                sqlCommand.Parameters.AddWithValue("@p2", textAd.Text);
                sqlCommand.Parameters.AddWithValue("@p3", textSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@p4", maskedTelefon.Text);
                sqlCommand.Parameters.AddWithValue("@p5", textMeslek.Text);
                sqlCommand.Parameters.AddWithValue("@p6", comboSehir.Text);
                sqlCommand.Parameters.AddWithValue("@p7", maskedMaas.Text);
                sqlCommand.Parameters.AddWithValue("@p8", dateBaslamaTarihi.Value);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Tc Kimlik No Yada Telefon No Zaten Kayıtlı!","HATA", MessageBoxButtons.OK);
                    SqlConnection.Close();
                    return;
                }

            }
            SqlConnection.Close();
            MessageBox.Show("Kayıt Başarılı!", "BİLGİ", MessageBoxButtons.OK);
        }

        private void buttonIstenCikar_Click(object sender, EventArgs e)//Tc No girilen kullaniciyi DB'den siler.
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void buttonYenile_Click(object sender, EventArgs e)//Guncel personel verilerini dataGridView'de gosterir.
        {
            SqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Table_Employee", SqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlConnection.Close();
        }

        private void buttonMaasGuncelle_Click(object sender, EventArgs e)//Tc No girilen personelin maasini gunceller.
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void buttonEnYuksekMaas_Click(object sender, EventArgs e)//En yüksek maas alan personeli bulmak icin.
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void buttonEnAzMaas_Click(object sender, EventArgs e)//En az maas alan personeli bulmak için.
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void buttonAra_Click(object sender, EventArgs e)//Tc No girilen personeli DB'de arar.
        {
            SqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Table_Employee where TcNo=@p1", SqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", maskedPersonelAra.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlConnection.Close();
        }

        private bool alanKontrol()//Formdaki alanlar bosmu kontrol eder.
        {
            if(maskedTcNo.Text =="" || textAd.Text=="" || textSoyad.Text=="" || maskedTelefon.Text=="" || textMeslek.Text=="" || comboSehir.Text=="" || maskedMaas.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Bütün Alanları Doldurun!", "UYARI");
                return true;
            }

            return false;

        }
    }
}

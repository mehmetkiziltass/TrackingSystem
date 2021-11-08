using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakipSistemi
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            string username = textKullaniciAdi.Text;
            string password = textSifre.Text;

            if(username == "mehmet" && password == "kiziltas")
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
         
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış!","UYARI");
            }
  
        }
    }
}

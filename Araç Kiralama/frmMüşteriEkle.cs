using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama
{
    public partial class frmMüşteriEkle : Form
    {
        Araç_Kiralama araç_Kiralama = new Araç_Kiralama(); 
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }

        private void frmMüşteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into müşteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)"; 
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc",txtTC.Text); 
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text); 
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text); 
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text); 
            komut2.Parameters.AddWithValue("@email", txtMail.Text); 

            araç_Kiralama.ekle_sil_guncelle(komut2, cümle); 
            foreach (Control item in Controls) if (item is TextBox) item.Text = ""; 
      
        }
    }
}

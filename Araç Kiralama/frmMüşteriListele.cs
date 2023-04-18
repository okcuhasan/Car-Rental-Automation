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
    public partial class frmMüşteriListele : Form
    {
        Araç_Kiralama araçkiralama = new Araç_Kiralama(); 
        public frmMüşteriListele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmMüşteriListele_Load(object sender, EventArgs e) 
        {
            YenileListele(); 
        }

        private void YenileListele() 
        {
            string cumle = "select * from müşteri"; 
            SqlDataAdapter adtr2 = new SqlDataAdapter(); 
            dataGridViewListele.DataSource = araçkiralama.listele(adtr2, cumle); 
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtTCAra_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select * from müşteri where tc like '%"+txtTCAra.Text+"%'";  
            SqlDataAdapter adtr2 = new SqlDataAdapter(); 
            dataGridViewListele.Columns[0].HeaderText = "TC";
            dataGridViewListele.Columns[1].HeaderText = "AD SOYAD";
            dataGridViewListele.Columns[2].HeaderText = "TELEFON";
            dataGridViewListele.Columns[3].HeaderText = "ADRES";
            dataGridViewListele.Columns[4].HeaderText = "E-MAİL";
            dataGridViewListele.DataSource = araçkiralama.listele(adtr2, cumle);
        }

        private void dataGridViewListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e) 
        {
            DataGridViewRow satır = dataGridViewListele.CurrentRow; 
            txtTC.Text = satır.Cells[0].Value.ToString(); 
            txtAdSoyad.Text = satır.Cells[1].Value.ToString(); 
            txtTelefon.Text = satır.Cells[2].Value.ToString(); 
            txtAdres.Text = satır.Cells[3].Value.ToString(); 
            txtMail.Text = satır.Cells[4].Value.ToString(); 
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc"; 
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text); 
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text); 
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text); 
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text); 
            komut2.Parameters.AddWithValue("@email", txtMail.Text);  
            araçkiralama.ekle_sil_guncelle(komut2, cumle); 
            foreach (Control item in Controls) if (item is TextBox) item.Text = ""; 
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridViewListele.CurrentRow; 
            string cumle = "delete from müşteri where tc='" + satır.Cells["tc"].Value.ToString() + "'"; 
            SqlCommand komut2 = new SqlCommand();
            araçkiralama.ekle_sil_guncelle(komut2, cumle); 
            foreach (Control item in Controls) if (item is TextBox) item.Text = ""; 
            YenileListele(); 
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

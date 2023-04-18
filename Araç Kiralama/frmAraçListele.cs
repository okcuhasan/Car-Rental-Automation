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
    public partial class frmAraçListele : Form
    {
        Araç_Kiralama araçkiralama = new Araç_Kiralama(); 
        public frmAraçListele()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridViewListele2.CurrentRow; 
            string cümle = "delete from araç where plaka='" + satır.Cells["plaka"].Value.ToString() +"'"; 
            SqlCommand komut2 = new SqlCommand();
            araçkiralama.ekle_sil_guncelle(komut2, cümle); 
            YenileAraçlarListesi(); 
            pictureBoxResim.ImageLocation = ""; 
            cmbSeri.Items.Clear(); 
            foreach (Control item in Controls) if (item is TextBox) item.Text = ""; 
            foreach (Control item in Controls) if (item is ComboBox) item.Text = ""; 
        }

        private void dataGridViewListele2_CellDoubleClick(object sender, DataGridViewCellEventArgs e) 
        {
            DataGridViewRow satır = dataGridViewListele2.CurrentRow; 
            txtPlaka.Text = satır.Cells["plaka"].Value.ToString(); 
            cmbMarka.Text = satır.Cells["marka"].Value.ToString(); 
            cmbSeri.Text = satır.Cells["seri"].Value.ToString(); 
            txtModel.Text = satır.Cells["yil"].Value.ToString(); 
            txtRenk.Text = satır.Cells["renk"].Value.ToString(); 
            txtKm.Text = satır.Cells["km"].Value.ToString(); 
            cmbYakit.Text = satır.Cells["yakit"].Value.ToString(); 
            txtKiraUcreti.Text = satır.Cells["kiraucreti"].Value.ToString(); 
            pictureBoxResim.ImageLocation = satır.Cells["resim"].Value.ToString(); 
        }

        private void dataGridViewListele2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAraçListele_Load(object sender, EventArgs e) 
        {
            YenileAraçlarListesi(); 

            comboAraçlar.SelectedIndex = 0; 
        }

        private void YenileAraçlarListesi()
        {
            string cumle = "select * from araç"; 
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridViewListele2.DataSource = araçkiralama.listele(adtr2, cumle); 
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxResim.ImageLocation = openFileDialog1.FileName; 
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update araç set marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,resim=@resim,tarih=@tarih where plaka=@plaka"; // plakasına göre araçları güncelleyebiliyorum
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut2.Parameters.AddWithValue("@marka", cmbMarka.Text); 
            komut2.Parameters.AddWithValue("@seri", cmbSeri.Text); 
            komut2.Parameters.AddWithValue("@yil", txtModel.Text); 
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text); 
            komut2.Parameters.AddWithValue("@km", txtKm.Text); 
            komut2.Parameters.AddWithValue("@yakit", cmbYakit.Text); 
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text)); 
            komut2.Parameters.AddWithValue("@resim", pictureBoxResim.ImageLocation); 
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            araçkiralama.ekle_sil_guncelle(komut2, cumle); 
            cmbSeri.Items.Clear(); 
            foreach (Control item in Controls) if (item is TextBox) item.Text = ""; 
            foreach (Control item in Controls) if (item is ComboBox) item.Text = ""; 
            pictureBoxResim.ImageLocation = "";  
            YenileAraçlarListesi(); 
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
    }


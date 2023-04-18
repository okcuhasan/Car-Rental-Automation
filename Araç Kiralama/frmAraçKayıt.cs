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
    public partial class frmAraçKayıt : Form
    {
        Araç_Kiralama araçkiralama = new Araç_Kiralama(); 
        public frmAraçKayıt()
        {
            InitializeComponent();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxResim.ImageLocation = openFileDialog1.FileName; 
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                cmbSeri.Items.Clear(); 
                if(cmbMarka.SelectedIndex == 0) 
                {
                    cmbSeri.Items.Add("Astra"); 
                    cmbSeri.Items.Add("Vectra"); 
                    cmbSeri.Items.Add("Corsa"); 
                }
                else if(cmbMarka.SelectedIndex == 1) 
                {
                    cmbSeri.Items.Add("Megane"); 
                    cmbSeri.Items.Add("Clio"); 
                }
                else if(cmbMarka.SelectedIndex == 2) 
                {
                    cmbSeri.Items.Add("Linea"); 
                    cmbSeri.Items.Add("Egea"); 
                }
                else if(cmbMarka.SelectedIndex == 3) 
                {
                    cmbSeri.Items.Add("Fiesta"); 
                    cmbSeri.Items.Add("Focus"); 

                }
            }
            catch { 
                
            
            
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string cumle = "insert into araç(plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,tarih,durumu) values(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@tarih,@durumu)"; 
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
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");
            araçkiralama.ekle_sil_guncelle(komut2, cumle);  
            cmbSeri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = ""; 
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBoxResim.ImageLocation = ""; 
        }

        private void frmAraçKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}

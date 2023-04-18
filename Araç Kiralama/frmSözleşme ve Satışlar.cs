using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama
{
    public partial class frmSözleşme : Form
    {
        public frmSözleşme()
        {
            InitializeComponent();
        }
        Araç_Kiralama araç = new Araç_Kiralama(); 

        private void cmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from araç where plaka like '" + cmbAraclar.SelectedItem + "'";
            araç.CombodanGetir(cmbAraclar, txtMarka, txtSeri, txtModel, txtRenk, sorgu2);

        }

        private void frmSözleşme_Load(object sender, EventArgs e)
        {
            BosAraclar();
            Yenile();
        }

        private void BosAraclar()
        {
            string sorgu2 = "select * from araç where durumu = 'BOŞ'"; 
            araç.Boş_Araçlar(cmbAraclar, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select * from sözleşme ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridViewListe3.DataSource = araç.listele(adtr2, sorgu3);
        }

        private void grpArac_Enter(object sender, EventArgs e)
        {

        }

        private void txtTC_TextChanged(object sender, EventArgs e) 
        {
           
        }

        private void cmbKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from araç where plaka like '" + cmbAraclar.SelectedItem + "'";
            araç.Ücret_Hesapla(cmbKiraSekli,txtKiraUcreti,sorgu2);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           TimeSpan gun = DateTime.Parse(dateTimePickerDonus.Text) - DateTime.Parse(dateTimePickerCikis.Text);

            int gun2 = gun.Days;

            txtGun.Text = gun2.ToString();

            txtTutar.Text = (gun2 * int.Parse(txtKiraUcreti.Text)).ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            dateTimePickerCikis.Text = DateTime.Now.ToString();
            dateTimePickerDonus.Text = DateTime.Now.ToString();
            cmbKiraSekli.Text = "";
            txtKiraUcreti.Text = "";
            txtGun.Text = "";
            txtTutar.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sözleşme(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,ctarih,dtarih) values(@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtEhliyetTarihi.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtE_VerildigiYer.Text);
            komut2.Parameters.AddWithValue("@plaka", cmbAraclar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtModel.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", cmbKiraSekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", txtKiraUcreti.Text);
            komut2.Parameters.AddWithValue("@gun", txtGun.Text);
            komut2.Parameters.AddWithValue("@tutar", txtTutar.Text);
            komut2.Parameters.AddWithValue("@ctarih", dateTimePickerCikis.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateTimePickerDonus.Text);
            araç.ekle_sil_guncelle(komut2, sorgu2);

            string sorgu3 = "update araç set durumu = 'DOLU' where plaka='"+cmbAraclar.Text+"'";
            SqlCommand komut3 = new SqlCommand();
            araç.ekle_sil_guncelle(komut3 , sorgu3);
            cmbAraclar.Items.Clear();
            BosAraclar();
            Yenile();
            foreach (Control item in grpArac.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in grpMusteri.Controls) if (item is TextBox) item.Text = "";
            cmbAraclar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Eklendi");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "") foreach (Control item in grpMusteri.Controls) if (item is TextBox) item.Text = "";

            string sorgu2 = "select * from müşteri where tc like '" + txtTcAra.Text + "'";
            araç.TC_Ara(txtTcAra, txtTC, txtAdSoyad, txtTelefon, sorgu2);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update sözleşme set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,e_tarih=@e_tarih,e_yer=@e_yer,marka=@marka,seri=@seri,yil=@yil,renk=@renk,kirasekli=@kirasekli,kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,ctarih=@ctarih,dtarih=@dtarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtEhliyetTarihi.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtE_VerildigiYer.Text);
            komut2.Parameters.AddWithValue("@plaka", cmbAraclar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtModel.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", cmbKiraSekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", txtKiraUcreti.Text);
            komut2.Parameters.AddWithValue("@gun", txtGun.Text);
            komut2.Parameters.AddWithValue("@tutar", txtTutar.Text);
            komut2.Parameters.AddWithValue("@ctarih", dateTimePickerCikis.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateTimePickerDonus.Text);
            araç.ekle_sil_guncelle(komut2, sorgu2);
            cmbAraclar.Items.Clear();
            BosAraclar();
            Yenile();
            foreach (Control item in grpArac.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in grpMusteri.Controls) if (item is TextBox) item.Text = "";
            cmbAraclar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme güncellendi");
        }

        private void dataGridViewListe3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridViewListe3.CurrentRow;
            txtTC.Text = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtEhliyetNo.Text = satır.Cells[3].Value.ToString();
            txtEhliyetTarihi.Text = satır.Cells[4].Value.ToString();
            txtE_VerildigiYer.Text = satır.Cells[5].Value.ToString();
            cmbAraclar.Text = satır.Cells[6].Value.ToString();
            txtMarka.Text = satır.Cells[7].Value.ToString();
            txtSeri.Text = satır.Cells[8].Value.ToString();
            txtModel.Text = satır.Cells[9].Value.ToString();
            txtRenk.Text = satır.Cells[10].Value.ToString();
            cmbKiraSekli.Text = satır.Cells[11].Value.ToString();
            txtKiraUcreti.Text = satır.Cells[12].Value.ToString();
            txtGun.Text = satır.Cells[13].Value.ToString();
            txtTutar.Text = satır.Cells[14].Value.ToString();
            dateTimePickerCikis.Text = satır.Cells[15].Value.ToString();
            dateTimePickerDonus.Text = satır.Cells[16].Value.ToString();
        }

        private void grpMusteri_Enter(object sender, EventArgs e)
        {

        }
    }
}

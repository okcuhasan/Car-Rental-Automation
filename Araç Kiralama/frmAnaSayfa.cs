using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle frmMüşteriEkle = new frmMüşteriEkle(); 
            frmMüşteriEkle.ShowDialog(); 
        }

        private void btnMusteriListeleme_Click(object sender, EventArgs e)
        {
            frmMüşteriListele frmMüşteriListele = new frmMüşteriListele(); 
            frmMüşteriListele.ShowDialog(); 
        }

        private void btnAracKayit_Click(object sender, EventArgs e)
        {
            frmAraçKayıt frmAraçKayıt = new frmAraçKayıt();
            frmAraçKayıt.ShowDialog();
        }

        private void btnAracListeleme_Click(object sender, EventArgs e)
        {
            frmAraçListele frmAraçListele = new frmAraçListele();
            frmAraçListele.ShowDialog();
        }

        private void btnSozlesme_Click(object sender, EventArgs e)
        {
            frmSözleşme frmSözleşme = new frmSözleşme();
            frmSözleşme.ShowDialog();   
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

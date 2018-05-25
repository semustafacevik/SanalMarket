using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanalMarket
{
    public partial class frm_PersonelGirisi : Form
    {
        public frm_PersonelGirisi()
        {
            InitializeComponent();
        }

        public Market market;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string Kullanici;
            string sifre;


            Kullanici = txtKullaniciAdi.Text;
            sifre = txtSifre.Text;

            if (Kullanici == "AytugOnan" && sifre == "******")
            {
                this.Hide();
                frm_PersonelEkrani frm = new frm_PersonelEkrani();
                frm.market = this.market;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgileri kontrol edip tekrar deneyiniz...");
            }

        }
    }
}

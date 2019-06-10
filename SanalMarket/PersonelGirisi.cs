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
        public HashMap hashTablosu;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string Kullanici;
            string sifre;


            Kullanici = txtKullaniciAdi.Text;
            sifre = txtSifre.Text;

            if (Kullanici == "Admin" && sifre == "******")
            {
                
                frm_PersonelEkrani personelEkrani = new frm_PersonelEkrani();
                personelEkrani.StartPosition = FormStartPosition.CenterParent;
                personelEkrani.market = this.market;
                personelEkrani.hashTablosu = this.hashTablosu;

                this.Hide();
                personelEkrani.ShowDialog();
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgileri kontrol edip tekrar deneyiniz...");
            }

        }
    }
}

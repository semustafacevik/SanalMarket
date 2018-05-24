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
    public partial class PersonelEkrani : Form
    {
        public PersonelEkrani()
        {
            InitializeComponent();
            GerekliGizlemeler();
        }
        public void GerekliGizlemeler()
        {
            cmbKategoriSecim.Hide();
            lblMarka.Hide();
            lblModel.Hide();
            lblMiktar.Hide();
            lblMaliyet.Hide();
            lblSatisFiyati.Hide();
            lblUrunAciklama.Hide();
            txtMarka.Hide();
            txtModel.Hide();
            txtMiktar.Hide();
            txtMaliyet.Hide();
            txtSatisFiyati.Hide();
            txtUrunAciklama.Hide();
            btnUrunuEkle.Hide();
        }
        public void GizlileriGoster()
        {
            cmbKategoriSecim.Show();
            lblMarka.Show();
            lblModel.Show();
            lblMiktar.Show();
            lblMaliyet.Show();
            lblSatisFiyati.Show();
            lblUrunAciklama.Show();
            txtMarka.Show();
            txtModel.Show();
            txtMiktar.Show();
            txtMaliyet.Show();
            txtSatisFiyati.Show();
            txtUrunAciklama.Show();
            btnUrunuEkle.Show();
        }
        private void PersonelEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            GizlileriGoster();
        }
    }
}

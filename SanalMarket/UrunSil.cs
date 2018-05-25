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
    public partial class frm_UrunSil : Form
    {
        public frm_UrunSil()
        {
            InitializeComponent();
        }

        public Market market;

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string silincekMarka = txt_SilinecekUrun.Text;

            foreach (IkiliAramaAgaci kategori in market.kategoriListesi)
            //{
            //    if (kategori.kategoriAdi == hangiKategori)
            //    {
            //        kategori.Ara(agactakiDugumNosu).urunler.;
            //    }
            //}
        }
    }
}

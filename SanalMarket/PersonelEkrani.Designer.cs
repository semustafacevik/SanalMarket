namespace SanalMarket
{
    partial class frm_PersonelEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AnaUrunEkle = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btn_AnaUrunSil = new System.Windows.Forms.Button();
            this.btn_AnaUrunGuncelle = new System.Windows.Forms.Button();
            this.btnMaliRapor = new System.Windows.Forms.Button();
            this.txt_Kategori = new System.Windows.Forms.TextBox();
            this.txt_AltKat = new System.Windows.Forms.TextBox();
            this.lbl_Kat = new System.Windows.Forms.Label();
            this.lbl_AltKat = new System.Windows.Forms.Label();
            this.grb_Kategori = new System.Windows.Forms.GroupBox();
            this.btn_KatEkle = new System.Windows.Forms.Button();
            this.btn_UrunAra = new System.Windows.Forms.Button();
            this.btn_UrunGuncelle = new System.Windows.Forms.Button();
            this.btn_UrunSil = new System.Windows.Forms.Button();
            this.txt_UrunAra = new System.Windows.Forms.TextBox();
            this.cmb_AltKatGym = new System.Windows.Forms.ComboBox();
            this.cmb_AltKatBEsya = new System.Windows.Forms.ComboBox();
            this.cmb_AltKatBilg = new System.Windows.Forms.ComboBox();
            this.btn_UrunEkle = new System.Windows.Forms.Button();
            this.cmb_KategoriSecim = new System.Windows.Forms.ComboBox();
            this.lblUrunAciklama = new System.Windows.Forms.Label();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblMaliyet = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtUrunAciklama = new System.Windows.Forms.TextBox();
            this.txtMaliyet = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.grb_Kategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AnaUrunEkle
            // 
            this.btn_AnaUrunEkle.Location = new System.Drawing.Point(12, 12);
            this.btn_AnaUrunEkle.Name = "btn_AnaUrunEkle";
            this.btn_AnaUrunEkle.Size = new System.Drawing.Size(138, 50);
            this.btn_AnaUrunEkle.TabIndex = 2;
            this.btn_AnaUrunEkle.Text = "Ürün Ekle";
            this.btn_AnaUrunEkle.UseVisualStyleBackColor = true;
            this.btn_AnaUrunEkle.Click += new System.EventHandler(this.AnaMenudekiUrunEklemeyeTiklama);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(170, 12);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(138, 50);
            this.btnKategoriEkle.TabIndex = 3;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.KategoriEkleyeTiklama);
            // 
            // btn_AnaUrunSil
            // 
            this.btn_AnaUrunSil.Location = new System.Drawing.Point(327, 12);
            this.btn_AnaUrunSil.Name = "btn_AnaUrunSil";
            this.btn_AnaUrunSil.Size = new System.Drawing.Size(138, 50);
            this.btn_AnaUrunSil.TabIndex = 4;
            this.btn_AnaUrunSil.Text = "Ürün Sil";
            this.btn_AnaUrunSil.UseVisualStyleBackColor = true;
            this.btn_AnaUrunSil.Click += new System.EventHandler(this.AnaMenudekiUrunSilmeyeTiklama);
            // 
            // btn_AnaUrunGuncelle
            // 
            this.btn_AnaUrunGuncelle.Location = new System.Drawing.Point(488, 12);
            this.btn_AnaUrunGuncelle.Name = "btn_AnaUrunGuncelle";
            this.btn_AnaUrunGuncelle.Size = new System.Drawing.Size(138, 50);
            this.btn_AnaUrunGuncelle.TabIndex = 5;
            this.btn_AnaUrunGuncelle.Text = "Ürün Güncelle";
            this.btn_AnaUrunGuncelle.UseVisualStyleBackColor = true;
            this.btn_AnaUrunGuncelle.Click += new System.EventHandler(this.AnaMenudekiUrunGuncelleyeTiklama);
            // 
            // btnMaliRapor
            // 
            this.btnMaliRapor.Location = new System.Drawing.Point(642, 12);
            this.btnMaliRapor.Name = "btnMaliRapor";
            this.btnMaliRapor.Size = new System.Drawing.Size(138, 50);
            this.btnMaliRapor.TabIndex = 6;
            this.btnMaliRapor.Text = "Mali Rapor";
            this.btnMaliRapor.UseVisualStyleBackColor = true;
            this.btnMaliRapor.Click += new System.EventHandler(this.MaliRaporaTiklama);
            // 
            // txt_Kategori
            // 
            this.txt_Kategori.Location = new System.Drawing.Point(67, 13);
            this.txt_Kategori.Name = "txt_Kategori";
            this.txt_Kategori.Size = new System.Drawing.Size(111, 20);
            this.txt_Kategori.TabIndex = 28;
            // 
            // txt_AltKat
            // 
            this.txt_AltKat.Location = new System.Drawing.Point(67, 39);
            this.txt_AltKat.Name = "txt_AltKat";
            this.txt_AltKat.Size = new System.Drawing.Size(111, 20);
            this.txt_AltKat.TabIndex = 29;
            // 
            // lbl_Kat
            // 
            this.lbl_Kat.AutoSize = true;
            this.lbl_Kat.Location = new System.Drawing.Point(15, 16);
            this.lbl_Kat.Name = "lbl_Kat";
            this.lbl_Kat.Size = new System.Drawing.Size(46, 13);
            this.lbl_Kat.TabIndex = 30;
            this.lbl_Kat.Text = "Kategori";
            // 
            // lbl_AltKat
            // 
            this.lbl_AltKat.AutoSize = true;
            this.lbl_AltKat.Location = new System.Drawing.Point(0, 42);
            this.lbl_AltKat.Name = "lbl_AltKat";
            this.lbl_AltKat.Size = new System.Drawing.Size(61, 13);
            this.lbl_AltKat.TabIndex = 30;
            this.lbl_AltKat.Text = "Alt Kategori";
            // 
            // grb_Kategori
            // 
            this.grb_Kategori.Controls.Add(this.btn_KatEkle);
            this.grb_Kategori.Controls.Add(this.txt_Kategori);
            this.grb_Kategori.Controls.Add(this.lbl_AltKat);
            this.grb_Kategori.Controls.Add(this.txt_AltKat);
            this.grb_Kategori.Controls.Add(this.lbl_Kat);
            this.grb_Kategori.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grb_Kategori.Location = new System.Drawing.Point(149, 68);
            this.grb_Kategori.Name = "grb_Kategori";
            this.grb_Kategori.Size = new System.Drawing.Size(184, 104);
            this.grb_Kategori.TabIndex = 31;
            this.grb_Kategori.TabStop = false;
            // 
            // btn_KatEkle
            // 
            this.btn_KatEkle.Location = new System.Drawing.Point(78, 65);
            this.btn_KatEkle.Name = "btn_KatEkle";
            this.btn_KatEkle.Size = new System.Drawing.Size(92, 23);
            this.btn_KatEkle.TabIndex = 31;
            this.btn_KatEkle.Text = "Kategori Ekle";
            this.btn_KatEkle.UseVisualStyleBackColor = true;
            this.btn_KatEkle.Click += new System.EventHandler(this.btn_KatEkle_Click);
            // 
            // btn_UrunAra
            // 
            this.btn_UrunAra.Location = new System.Drawing.Point(391, 157);
            this.btn_UrunAra.Name = "btn_UrunAra";
            this.btn_UrunAra.Size = new System.Drawing.Size(75, 23);
            this.btn_UrunAra.TabIndex = 69;
            this.btn_UrunAra.Text = "Ürün Ara";
            this.btn_UrunAra.UseVisualStyleBackColor = true;
            this.btn_UrunAra.Click += new System.EventHandler(this.UrunArayaTiklama);
            // 
            // btn_UrunGuncelle
            // 
            this.btn_UrunGuncelle.Location = new System.Drawing.Point(528, 239);
            this.btn_UrunGuncelle.Name = "btn_UrunGuncelle";
            this.btn_UrunGuncelle.Size = new System.Drawing.Size(119, 41);
            this.btn_UrunGuncelle.TabIndex = 68;
            this.btn_UrunGuncelle.Text = "Ürün Güncelle";
            this.btn_UrunGuncelle.UseVisualStyleBackColor = true;
            this.btn_UrunGuncelle.Click += new System.EventHandler(this.UrunGuncelleyeTiklama);
            // 
            // btn_UrunSil
            // 
            this.btn_UrunSil.Location = new System.Drawing.Point(528, 239);
            this.btn_UrunSil.Name = "btn_UrunSil";
            this.btn_UrunSil.Size = new System.Drawing.Size(119, 41);
            this.btn_UrunSil.TabIndex = 67;
            this.btn_UrunSil.Text = "Aranan Ürünü Sil";
            this.btn_UrunSil.UseVisualStyleBackColor = true;
            this.btn_UrunSil.Click += new System.EventHandler(this.UrunSileTiklama);
            // 
            // txt_UrunAra
            // 
            this.txt_UrunAra.Location = new System.Drawing.Point(267, 159);
            this.txt_UrunAra.Name = "txt_UrunAra";
            this.txt_UrunAra.Size = new System.Drawing.Size(100, 20);
            this.txt_UrunAra.TabIndex = 66;
            // 
            // cmb_AltKatGym
            // 
            this.cmb_AltKatGym.FormattingEnabled = true;
            this.cmb_AltKatGym.Items.AddRange(new object[] {
            "Gömlek",
            "Pantolon"});
            this.cmb_AltKatGym.Location = new System.Drawing.Point(325, 157);
            this.cmb_AltKatGym.Name = "cmb_AltKatGym";
            this.cmb_AltKatGym.Size = new System.Drawing.Size(121, 21);
            this.cmb_AltKatGym.TabIndex = 65;
            this.cmb_AltKatGym.SelectedIndexChanged += new System.EventHandler(this.cmb_AltKatGym_SelectedIndexChanged);
            // 
            // cmb_AltKatBEsya
            // 
            this.cmb_AltKatBEsya.FormattingEnabled = true;
            this.cmb_AltKatBEsya.Items.AddRange(new object[] {
            "Buzdolabı",
            "Çamaşır Makinesi"});
            this.cmb_AltKatBEsya.Location = new System.Drawing.Point(325, 157);
            this.cmb_AltKatBEsya.Name = "cmb_AltKatBEsya";
            this.cmb_AltKatBEsya.Size = new System.Drawing.Size(121, 21);
            this.cmb_AltKatBEsya.TabIndex = 64;
            this.cmb_AltKatBEsya.SelectedIndexChanged += new System.EventHandler(this.cmb_AltKatBEsya_SelectedIndexChanged);
            // 
            // cmb_AltKatBilg
            // 
            this.cmb_AltKatBilg.FormattingEnabled = true;
            this.cmb_AltKatBilg.Items.AddRange(new object[] {
            "Dizüstü",
            "Masaüstü",
            "Oyun"});
            this.cmb_AltKatBilg.Location = new System.Drawing.Point(327, 158);
            this.cmb_AltKatBilg.Name = "cmb_AltKatBilg";
            this.cmb_AltKatBilg.Size = new System.Drawing.Size(121, 21);
            this.cmb_AltKatBilg.TabIndex = 63;
            this.cmb_AltKatBilg.SelectedIndexChanged += new System.EventHandler(this.cmb_AltKatBilg_SelectedIndexChanged);
            // 
            // btn_UrunEkle
            // 
            this.btn_UrunEkle.Location = new System.Drawing.Point(528, 239);
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.btn_UrunEkle.Size = new System.Drawing.Size(119, 41);
            this.btn_UrunEkle.TabIndex = 62;
            this.btn_UrunEkle.Text = "Belirtilen Ürünü Ekle";
            this.btn_UrunEkle.UseVisualStyleBackColor = true;
            this.btn_UrunEkle.Click += new System.EventHandler(this.UrunEklemeyeTiklama);
            // 
            // cmb_KategoriSecim
            // 
            this.cmb_KategoriSecim.FormattingEnabled = true;
            this.cmb_KategoriSecim.Items.AddRange(new object[] {
            "Bilgisayar",
            "Beyaz Eşya",
            "Giyim"});
            this.cmb_KategoriSecim.Location = new System.Drawing.Point(198, 158);
            this.cmb_KategoriSecim.Name = "cmb_KategoriSecim";
            this.cmb_KategoriSecim.Size = new System.Drawing.Size(121, 21);
            this.cmb_KategoriSecim.TabIndex = 61;
            this.cmb_KategoriSecim.SelectedIndexChanged += new System.EventHandler(this.cmb_KategoriSecim_SelectedIndexChanged);
            // 
            // lblUrunAciklama
            // 
            this.lblUrunAciklama.AutoSize = true;
            this.lblUrunAciklama.Location = new System.Drawing.Point(284, 288);
            this.lblUrunAciklama.Name = "lblUrunAciklama";
            this.lblUrunAciklama.Size = new System.Drawing.Size(83, 13);
            this.lblUrunAciklama.TabIndex = 60;
            this.lblUrunAciklama.Text = "Ürün Açıklaması";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Location = new System.Drawing.Point(307, 253);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.lblSatisFiyati.TabIndex = 59;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // lblMaliyet
            // 
            this.lblMaliyet.AutoSize = true;
            this.lblMaliyet.Location = new System.Drawing.Point(324, 218);
            this.lblMaliyet.Name = "lblMaliyet";
            this.lblMaliyet.Size = new System.Drawing.Size(40, 13);
            this.lblMaliyet.TabIndex = 58;
            this.lblMaliyet.Text = "Maliyet";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(99, 288);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(36, 13);
            this.lblMiktar.TabIndex = 57;
            this.lblMiktar.Text = "Miktar";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(99, 253);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 56;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(99, 218);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(37, 13);
            this.lblMarka.TabIndex = 55;
            this.lblMarka.Text = "Marka";
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(370, 285);
            this.txtUrunAciklama.Multiline = true;
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(129, 20);
            this.txtUrunAciklama.TabIndex = 54;
            // 
            // txtMaliyet
            // 
            this.txtMaliyet.Location = new System.Drawing.Point(370, 215);
            this.txtMaliyet.Multiline = true;
            this.txtMaliyet.Name = "txtMaliyet";
            this.txtMaliyet.Size = new System.Drawing.Size(129, 20);
            this.txtMaliyet.TabIndex = 53;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(370, 250);
            this.txtSatisFiyati.Multiline = true;
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(129, 20);
            this.txtSatisFiyati.TabIndex = 52;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(149, 285);
            this.txtMiktar.Multiline = true;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(129, 20);
            this.txtMiktar.TabIndex = 51;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(149, 250);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(129, 20);
            this.txtModel.TabIndex = 50;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(149, 215);
            this.txtMarka.Multiline = true;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(129, 20);
            this.txtMarka.TabIndex = 49;
            // 
            // frm_PersonelEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 367);
            this.Controls.Add(this.btn_UrunAra);
            this.Controls.Add(this.btn_UrunGuncelle);
            this.Controls.Add(this.btn_UrunSil);
            this.Controls.Add(this.txt_UrunAra);
            this.Controls.Add(this.cmb_AltKatGym);
            this.Controls.Add(this.cmb_AltKatBEsya);
            this.Controls.Add(this.cmb_AltKatBilg);
            this.Controls.Add(this.btn_UrunEkle);
            this.Controls.Add(this.cmb_KategoriSecim);
            this.Controls.Add(this.lblUrunAciklama);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.lblMaliyet);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.txtUrunAciklama);
            this.Controls.Add(this.txtMaliyet);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.grb_Kategori);
            this.Controls.Add(this.btnMaliRapor);
            this.Controls.Add(this.btn_AnaUrunGuncelle);
            this.Controls.Add(this.btn_AnaUrunSil);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btn_AnaUrunEkle);
            this.Name = "frm_PersonelEkrani";
            this.Text = "PersonelEkrani";
            this.grb_Kategori.ResumeLayout(false);
            this.grb_Kategori.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AnaUrunEkle;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btn_AnaUrunSil;
        private System.Windows.Forms.Button btn_AnaUrunGuncelle;
        private System.Windows.Forms.Button btnMaliRapor;
        private System.Windows.Forms.TextBox txt_Kategori;
        private System.Windows.Forms.TextBox txt_AltKat;
        private System.Windows.Forms.Label lbl_Kat;
        private System.Windows.Forms.Label lbl_AltKat;
        private System.Windows.Forms.GroupBox grb_Kategori;
        private System.Windows.Forms.Button btn_UrunAra;
        private System.Windows.Forms.Button btn_UrunGuncelle;
        private System.Windows.Forms.Button btn_UrunSil;
        public System.Windows.Forms.TextBox txt_UrunAra;
        public System.Windows.Forms.ComboBox cmb_AltKatGym;
        public System.Windows.Forms.ComboBox cmb_AltKatBEsya;
        public System.Windows.Forms.ComboBox cmb_AltKatBilg;
        public System.Windows.Forms.Button btn_UrunEkle;
        public System.Windows.Forms.ComboBox cmb_KategoriSecim;
        public System.Windows.Forms.Label lblUrunAciklama;
        public System.Windows.Forms.Label lblSatisFiyati;
        public System.Windows.Forms.Label lblMaliyet;
        public System.Windows.Forms.Label lblMiktar;
        public System.Windows.Forms.Label lblModel;
        public System.Windows.Forms.Label lblMarka;
        public System.Windows.Forms.TextBox txtUrunAciklama;
        public System.Windows.Forms.TextBox txtMaliyet;
        public System.Windows.Forms.TextBox txtSatisFiyati;
        public System.Windows.Forms.TextBox txtMiktar;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Button btn_KatEkle;
    }
}
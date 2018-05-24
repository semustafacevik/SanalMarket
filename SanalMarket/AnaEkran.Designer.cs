namespace SanalMarket
{
    partial class frm_AnaEkran
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
            this.btn_Olustur = new System.Windows.Forms.Button();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Miktar = new System.Windows.Forms.TextBox();
            this.txt_Maliyet = new System.Windows.Forms.TextBox();
            this.txt_SatisFiyati = new System.Windows.Forms.TextBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.cmb_Kategori = new System.Windows.Forms.ComboBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.cmb_AltKategori = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dizüstüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaüstüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Olustur
            // 
            this.btn_Olustur.Location = new System.Drawing.Point(128, 70);
            this.btn_Olustur.Name = "btn_Olustur";
            this.btn_Olustur.Size = new System.Drawing.Size(75, 23);
            this.btn_Olustur.TabIndex = 1;
            this.btn_Olustur.Text = "button1";
            this.btn_Olustur.UseVisualStyleBackColor = true;
            this.btn_Olustur.Click += new System.EventHandler(this.btn_Olustur_Click);
            // 
            // txt_Marka
            // 
            this.txt_Marka.Location = new System.Drawing.Point(354, 86);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(100, 20);
            this.txt_Marka.TabIndex = 2;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(354, 112);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(100, 20);
            this.txt_Model.TabIndex = 2;
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.Location = new System.Drawing.Point(354, 138);
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Size = new System.Drawing.Size(100, 20);
            this.txt_Miktar.TabIndex = 2;
            // 
            // txt_Maliyet
            // 
            this.txt_Maliyet.Location = new System.Drawing.Point(354, 164);
            this.txt_Maliyet.Name = "txt_Maliyet";
            this.txt_Maliyet.Size = new System.Drawing.Size(100, 20);
            this.txt_Maliyet.TabIndex = 2;
            // 
            // txt_SatisFiyati
            // 
            this.txt_SatisFiyati.Location = new System.Drawing.Point(354, 190);
            this.txt_SatisFiyati.Name = "txt_SatisFiyati";
            this.txt_SatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txt_SatisFiyati.TabIndex = 2;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(354, 216);
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(100, 20);
            this.txt_Aciklama.TabIndex = 2;
            // 
            // cmb_Kategori
            // 
            this.cmb_Kategori.FormattingEnabled = true;
            this.cmb_Kategori.Items.AddRange(new object[] {
            "PC",
            "Beyaz Eşya"});
            this.cmb_Kategori.Location = new System.Drawing.Point(217, 138);
            this.cmb_Kategori.Name = "cmb_Kategori";
            this.cmb_Kategori.Size = new System.Drawing.Size(121, 21);
            this.cmb_Kategori.TabIndex = 4;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(464, 138);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 5;
            this.btn_Ekle.Text = "button1";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // cmb_AltKategori
            // 
            this.cmb_AltKategori.FormattingEnabled = true;
            this.cmb_AltKategori.Items.AddRange(new object[] {
            "Dizüstü Bilgisayar",
            "Masaüstü Bilgisayar",
            "Ultrabook",
            "Notebook",
            "Oyun Bilgisayarı"});
            this.cmb_AltKategori.Location = new System.Drawing.Point(217, 163);
            this.cmb_AltKategori.Name = "cmb_AltKategori";
            this.cmb_AltKategori.Size = new System.Drawing.Size(121, 21);
            this.cmb_AltKategori.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCToolStripMenuItem});
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            // 
            // pCToolStripMenuItem
            // 
            this.pCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dizüstüToolStripMenuItem,
            this.masaüstüToolStripMenuItem});
            this.pCToolStripMenuItem.Name = "pCToolStripMenuItem";
            this.pCToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pCToolStripMenuItem.Text = "PC";
            // 
            // dizüstüToolStripMenuItem
            // 
            this.dizüstüToolStripMenuItem.Name = "dizüstüToolStripMenuItem";
            this.dizüstüToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dizüstüToolStripMenuItem.Text = "Dizüstü";
            // 
            // masaüstüToolStripMenuItem
            // 
            this.masaüstüToolStripMenuItem.Name = "masaüstüToolStripMenuItem";
            this.masaüstüToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.masaüstüToolStripMenuItem.Text = "Masaüstü";
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.Location = new System.Drawing.Point(800, 0);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(97, 24);
            this.btnPersonelGiris.TabIndex = 7;
            this.btnPersonelGiris.Text = "Personel Girişi";
            this.btnPersonelGiris.UseVisualStyleBackColor = true;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // frm_AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 315);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.cmb_AltKategori);
            this.Controls.Add(this.cmb_Kategori);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.txt_SatisFiyati);
            this.Controls.Add(this.txt_Maliyet);
            this.Controls.Add(this.txt_Miktar);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_Marka);
            this.Controls.Add(this.btn_Olustur);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_AnaEkran";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.frm_AnaEkran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Olustur;
        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_Miktar;
        private System.Windows.Forms.TextBox txt_Maliyet;
        private System.Windows.Forms.TextBox txt_SatisFiyati;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.ComboBox cmb_Kategori;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ComboBox cmb_AltKategori;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dizüstüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaüstüToolStripMenuItem;
        private System.Windows.Forms.Button btnPersonelGiris;
    }
}


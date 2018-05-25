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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dizüstüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaüstüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.btn_Bul = new System.Windows.Forms.Button();
            this.txt_Bul = new System.Windows.Forms.TextBox();
            this.txt_Goster = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.pCToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.pCToolStripMenuItem.Text = "PC";
            // 
            // dizüstüToolStripMenuItem
            // 
            this.dizüstüToolStripMenuItem.Name = "dizüstüToolStripMenuItem";
            this.dizüstüToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.dizüstüToolStripMenuItem.Text = "Dizüstü";
            // 
            // masaüstüToolStripMenuItem
            // 
            this.masaüstüToolStripMenuItem.Name = "masaüstüToolStripMenuItem";
            this.masaüstüToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
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
            // btn_Bul
            // 
            this.btn_Bul.Location = new System.Drawing.Point(696, 86);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(75, 23);
            this.btn_Bul.TabIndex = 8;
            this.btn_Bul.Text = "button1";
            this.btn_Bul.UseVisualStyleBackColor = true;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // txt_Bul
            // 
            this.txt_Bul.Location = new System.Drawing.Point(682, 59);
            this.txt_Bul.Name = "txt_Bul";
            this.txt_Bul.Size = new System.Drawing.Size(100, 20);
            this.txt_Bul.TabIndex = 9;
            // 
            // txt_Goster
            // 
            this.txt_Goster.Location = new System.Drawing.Point(682, 125);
            this.txt_Goster.Name = "txt_Goster";
            this.txt_Goster.Size = new System.Drawing.Size(100, 20);
            this.txt_Goster.TabIndex = 10;
            // 
            // frm_AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 315);
            this.Controls.Add(this.txt_Goster);
            this.Controls.Add(this.txt_Bul);
            this.Controls.Add(this.btn_Bul);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_AnaEkran";
            this.Text = "Ana Ekran";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dizüstüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaüstüToolStripMenuItem;
        private System.Windows.Forms.Button btnPersonelGiris;
        private System.Windows.Forms.Button btn_Bul;
        private System.Windows.Forms.TextBox txt_Bul;
        private System.Windows.Forms.TextBox txt_Goster;
    }
}


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
            this.mst_Kategori = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // mst_Kategori
            // 
            this.mst_Kategori.Location = new System.Drawing.Point(0, 0);
            this.mst_Kategori.Name = "mst_Kategori";
            this.mst_Kategori.Size = new System.Drawing.Size(551, 24);
            this.mst_Kategori.TabIndex = 0;
            this.mst_Kategori.Text = "menuStrip1";
            // 
            // frm_AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 262);
            this.Controls.Add(this.mst_Kategori);
            this.MainMenuStrip = this.mst_Kategori;
            this.Name = "frm_AnaEkran";
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mst_Kategori;
    }
}


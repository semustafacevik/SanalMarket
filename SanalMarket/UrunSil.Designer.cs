namespace SanalMarket
{
    partial class frm_UrunSil
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
            this.txt_SilinecekUrun = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_SilinecekUrun
            // 
            this.txt_SilinecekUrun.Location = new System.Drawing.Point(78, 37);
            this.txt_SilinecekUrun.Name = "txt_SilinecekUrun";
            this.txt_SilinecekUrun.Size = new System.Drawing.Size(100, 20);
            this.txt_SilinecekUrun.TabIndex = 0;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(94, 63);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 1;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // frm_UrunSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 256);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.txt_SilinecekUrun);
            this.Name = "frm_UrunSil";
            this.Text = "UrunSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SilinecekUrun;
        private System.Windows.Forms.Button btn_Sil;
    }
}
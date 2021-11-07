
namespace Hamburger_Sipariş_Menüsü_Oluşturma
{
    partial class MyMDIForm
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
            this.tsmSiparisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisYonetimi,
            this.tsmUrunYonetimi,
            this.tsmCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(920, 125);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSiparisYonetimi
            // 
            this.tsmSiparisYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisOlustur,
            this.tsmSiparisBilgileri});
            this.tsmSiparisYonetimi.Name = "tsmSiparisYonetimi";
            this.tsmSiparisYonetimi.Size = new System.Drawing.Size(206, 117);
            this.tsmSiparisYonetimi.Text = "Sipariş Yönetimi";
            // 
            // tsmSiparisOlustur
            // 
            this.tsmSiparisOlustur.Name = "tsmSiparisOlustur";
            this.tsmSiparisOlustur.Size = new System.Drawing.Size(304, 44);
            this.tsmSiparisOlustur.Text = "Sipariş Oluştur";
            this.tsmSiparisOlustur.Click += new System.EventHandler(this.tsmSiparisOlustur_Click);
            // 
            // tsmSiparisBilgileri
            // 
            this.tsmSiparisBilgileri.Name = "tsmSiparisBilgileri";
            this.tsmSiparisBilgileri.Size = new System.Drawing.Size(304, 44);
            this.tsmSiparisBilgileri.Text = "Sipariş Bilgileri";
            this.tsmSiparisBilgileri.Click += new System.EventHandler(this.tsmSiparisBilgileri_Click);
            // 
            // tsmUrunYonetimi
            // 
            this.tsmUrunYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuEkle,
            this.tsmEkstraMalzemeEkle});
            this.tsmUrunYonetimi.Name = "tsmUrunYonetimi";
            this.tsmUrunYonetimi.Size = new System.Drawing.Size(189, 117);
            this.tsmUrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // tsmMenuEkle
            // 
            this.tsmMenuEkle.Name = "tsmMenuEkle";
            this.tsmMenuEkle.Size = new System.Drawing.Size(366, 44);
            this.tsmMenuEkle.Text = "Menü Ekle";
            this.tsmMenuEkle.Click += new System.EventHandler(this.tsmMenuEkle_Click);
            // 
            // tsmEkstraMalzemeEkle
            // 
            this.tsmEkstraMalzemeEkle.Name = "tsmEkstraMalzemeEkle";
            this.tsmEkstraMalzemeEkle.Size = new System.Drawing.Size(366, 44);
            this.tsmEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.tsmEkstraMalzemeEkle.Click += new System.EventHandler(this.tsmEkstraMalzemeEkle_Click);
            // 
            // tsmCikis
            // 
            this.tsmCikis.Name = "tsmCikis";
            this.tsmCikis.Size = new System.Drawing.Size(84, 117);
            this.tsmCikis.Text = "Çıkış";
            this.tsmCikis.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // MyMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 681);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyMDIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisYonetimi;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisOlustur;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisBilgileri;
        private System.Windows.Forms.ToolStripMenuItem tsmUrunYonetimi;
        private System.Windows.Forms.ToolStripMenuItem tsmCikis;
        private System.Windows.Forms.ToolStripMenuItem tsmMenuEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmEkstraMalzemeEkle;
    }
}


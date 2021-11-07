
namespace Hamburger_Sipariş_Menüsü_Oluşturma
{
    partial class Sipariş_Oluştur
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
            this.cmBoxMenüler = new System.Windows.Forms.ComboBox();
            this.nmrSiparis = new System.Windows.Forms.NumericUpDown();
            this.btnSiparişEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flpEkstraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.grpBoyutSec = new System.Windows.Forms.GroupBox();
            this.rdoBuyuk = new System.Windows.Forms.RadioButton();
            this.rdoOrta = new System.Windows.Forms.RadioButton();
            this.rdoKucuk = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.pctrBxHamburger = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSiparis)).BeginInit();
            this.grpBoyutSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxHamburger)).BeginInit();
            this.SuspendLayout();
            // 
            // cmBoxMenüler
            // 
            this.cmBoxMenüler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBoxMenüler.FormattingEnabled = true;
            this.cmBoxMenüler.Location = new System.Drawing.Point(35, 225);
            this.cmBoxMenüler.Name = "cmBoxMenüler";
            this.cmBoxMenüler.Size = new System.Drawing.Size(315, 28);
            this.cmBoxMenüler.TabIndex = 1;
            // 
            // nmrSiparis
            // 
            this.nmrSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrSiparis.Location = new System.Drawing.Point(35, 526);
            this.nmrSiparis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSiparis.Name = "nmrSiparis";
            this.nmrSiparis.Size = new System.Drawing.Size(137, 26);
            this.nmrSiparis.TabIndex = 5;
            this.nmrSiparis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrSiparis.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparişEkle
            // 
            this.btnSiparişEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparişEkle.Location = new System.Drawing.Point(196, 496);
            this.btnSiparişEkle.Name = "btnSiparişEkle";
            this.btnSiparişEkle.Size = new System.Drawing.Size(154, 56);
            this.btnSiparişEkle.TabIndex = 6;
            this.btnSiparişEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparişEkle.UseVisualStyleBackColor = true;
            this.btnSiparişEkle.Click += new System.EventHandler(this.btnSiparişEkle_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(391, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Tutar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.BackColor = System.Drawing.Color.Aqua;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplamTutar.Location = new System.Drawing.Point(518, 469);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(107, 30);
            this.lblToplamTutar.TabIndex = 2;
            this.lblToplamTutar.Text = "0";
            this.lblToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisTamamla.Location = new System.Drawing.Point(631, 438);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(116, 81);
            this.btnSiparisTamamla.TabIndex = 6;
            this.btnSiparisTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sipariş Adediniz:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lütfen Ekstra Malzeme Seçiniz:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(35, 327);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(315, 163);
            this.flpEkstraMalzemeler.TabIndex = 15;
            // 
            // grpBoyutSec
            // 
            this.grpBoyutSec.Controls.Add(this.rdoBuyuk);
            this.grpBoyutSec.Controls.Add(this.rdoOrta);
            this.grpBoyutSec.Controls.Add(this.rdoKucuk);
            this.grpBoyutSec.Location = new System.Drawing.Point(36, 255);
            this.grpBoyutSec.Name = "grpBoyutSec";
            this.grpBoyutSec.Size = new System.Drawing.Size(314, 44);
            this.grpBoyutSec.TabIndex = 16;
            this.grpBoyutSec.TabStop = false;
            this.grpBoyutSec.Text = "Hangi Boy İstersiniz:";
            // 
            // rdoBuyuk
            // 
            this.rdoBuyuk.AutoSize = true;
            this.rdoBuyuk.Location = new System.Drawing.Point(236, 19);
            this.rdoBuyuk.Name = "rdoBuyuk";
            this.rdoBuyuk.Size = new System.Drawing.Size(55, 17);
            this.rdoBuyuk.TabIndex = 0;
            this.rdoBuyuk.TabStop = true;
            this.rdoBuyuk.Text = "Büyük";
            this.rdoBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdoOrta
            // 
            this.rdoOrta.AutoSize = true;
            this.rdoOrta.Location = new System.Drawing.Point(124, 19);
            this.rdoOrta.Name = "rdoOrta";
            this.rdoOrta.Size = new System.Drawing.Size(45, 17);
            this.rdoOrta.TabIndex = 0;
            this.rdoOrta.TabStop = true;
            this.rdoOrta.Text = "Orta";
            this.rdoOrta.UseVisualStyleBackColor = true;
            // 
            // rdoKucuk
            // 
            this.rdoKucuk.AutoSize = true;
            this.rdoKucuk.Location = new System.Drawing.Point(7, 21);
            this.rdoKucuk.Name = "rdoKucuk";
            this.rdoKucuk.Size = new System.Drawing.Size(56, 17);
            this.rdoKucuk.TabIndex = 0;
            this.rdoKucuk.TabStop = true;
            this.rdoKucuk.Text = "Küçük";
            this.rdoKucuk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lütfen Menü Seçiniz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.HorizontalScrollbar = true;
            this.lbxSiparisler.Location = new System.Drawing.Point(395, 32);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(352, 381);
            this.lbxSiparisler.TabIndex = 18;
            // 
            // pctrBxHamburger
            // 
            this.pctrBxHamburger.Image = global::Hamburger_Sipariş_Menüsü_Oluşturma.Properties.Resources.giphy;
            this.pctrBxHamburger.Location = new System.Drawing.Point(35, 32);
            this.pctrBxHamburger.Name = "pctrBxHamburger";
            this.pctrBxHamburger.Size = new System.Drawing.Size(282, 150);
            this.pctrBxHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxHamburger.TabIndex = 0;
            this.pctrBxHamburger.TabStop = false;
            // 
            // Sipariş_Oluştur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBoyutSec);
            this.Controls.Add(this.flpEkstraMalzemeler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.btnSiparişEkle);
            this.Controls.Add(this.nmrSiparis);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBoxMenüler);
            this.Controls.Add(this.pctrBxHamburger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sipariş_Oluştur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sipariş Oluştur";
            this.Load += new System.EventHandler(this.Sipariş_Oluştur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSiparis)).EndInit();
            this.grpBoyutSec.ResumeLayout(false);
            this.grpBoyutSec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxHamburger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrBxHamburger;
        private System.Windows.Forms.ComboBox cmBoxMenüler;
        private System.Windows.Forms.NumericUpDown nmrSiparis;
        private System.Windows.Forms.Button btnSiparişEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpEkstraMalzemeler;
        private System.Windows.Forms.GroupBox grpBoyutSec;
        private System.Windows.Forms.RadioButton rdoBuyuk;
        private System.Windows.Forms.RadioButton rdoOrta;
        private System.Windows.Forms.RadioButton rdoKucuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxSiparisler;
    }
}

namespace Hamburger_Sipariş_Menüsü_Oluşturma
{
    partial class Ekstra_Malzeme_Ekle
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
            this.grpMenuBilgileri = new System.Windows.Forms.GroupBox();
            this.btnEkstraMalzemeKaydet = new System.Windows.Forms.Button();
            this.nmrEkstraMalzemeFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenuBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuBilgileri
            // 
            this.grpMenuBilgileri.Controls.Add(this.btnEkstraMalzemeKaydet);
            this.grpMenuBilgileri.Controls.Add(this.nmrEkstraMalzemeFiyati);
            this.grpMenuBilgileri.Controls.Add(this.txtEkstraMalzemeAdi);
            this.grpMenuBilgileri.Controls.Add(this.label2);
            this.grpMenuBilgileri.Controls.Add(this.label1);
            this.grpMenuBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMenuBilgileri.Location = new System.Drawing.Point(50, 52);
            this.grpMenuBilgileri.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpMenuBilgileri.Name = "grpMenuBilgileri";
            this.grpMenuBilgileri.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpMenuBilgileri.Size = new System.Drawing.Size(978, 527);
            this.grpMenuBilgileri.TabIndex = 1;
            this.grpMenuBilgileri.TabStop = false;
            this.grpMenuBilgileri.Text = "Ekstra Malzeme Bilgileri";
            // 
            // btnEkstraMalzemeKaydet
            // 
            this.btnEkstraMalzemeKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkstraMalzemeKaydet.Location = new System.Drawing.Point(156, 354);
            this.btnEkstraMalzemeKaydet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEkstraMalzemeKaydet.Name = "btnEkstraMalzemeKaydet";
            this.btnEkstraMalzemeKaydet.Size = new System.Drawing.Size(632, 119);
            this.btnEkstraMalzemeKaydet.TabIndex = 3;
            this.btnEkstraMalzemeKaydet.Text = "YENİ EKSTRA MAZLEME KAYDET";
            this.btnEkstraMalzemeKaydet.UseVisualStyleBackColor = true;
            this.btnEkstraMalzemeKaydet.Click += new System.EventHandler(this.btnEkstraMalzemeKaydet_Click);
            // 
            // nmrEkstraMalzemeFiyati
            // 
            this.nmrEkstraMalzemeFiyati.DecimalPlaces = 2;
            this.nmrEkstraMalzemeFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrEkstraMalzemeFiyati.Location = new System.Drawing.Point(470, 244);
            this.nmrEkstraMalzemeFiyati.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nmrEkstraMalzemeFiyati.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrEkstraMalzemeFiyati.Name = "nmrEkstraMalzemeFiyati";
            this.nmrEkstraMalzemeFiyati.Size = new System.Drawing.Size(472, 44);
            this.nmrEkstraMalzemeFiyati.TabIndex = 2;
            this.nmrEkstraMalzemeFiyati.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtEkstraMalzemeAdi
            // 
            this.txtEkstraMalzemeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkstraMalzemeAdi.Location = new System.Drawing.Point(470, 148);
            this.txtEkstraMalzemeAdi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            this.txtEkstraMalzemeAdi.Size = new System.Drawing.Size(468, 44);
            this.txtEkstraMalzemeAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ekstra Malzeme Fiyatı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ekstra_Malzeme_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 604);
            this.Controls.Add(this.grpMenuBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Ekstra_Malzeme_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ekstra_Malzeme_Ekle";
            this.grpMenuBilgileri.ResumeLayout(false);
            this.grpMenuBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuBilgileri;
        private System.Windows.Forms.Button btnEkstraMalzemeKaydet;
        private System.Windows.Forms.NumericUpDown nmrEkstraMalzemeFiyati;
        private System.Windows.Forms.TextBox txtEkstraMalzemeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
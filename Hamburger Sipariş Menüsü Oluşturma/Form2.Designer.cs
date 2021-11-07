
namespace Hamburger_Sipariş_Menüsü_Oluşturma
{
    partial class Menü_Ekle
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
            this.btnMenuyuKaydet = new System.Windows.Forms.Button();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenuBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuBilgileri
            // 
            this.grpMenuBilgileri.Controls.Add(this.btnMenuyuKaydet);
            this.grpMenuBilgileri.Controls.Add(this.nmrMenuFiyati);
            this.grpMenuBilgileri.Controls.Add(this.txtMenuAdi);
            this.grpMenuBilgileri.Controls.Add(this.label2);
            this.grpMenuBilgileri.Controls.Add(this.label1);
            this.grpMenuBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMenuBilgileri.Location = new System.Drawing.Point(44, 44);
            this.grpMenuBilgileri.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpMenuBilgileri.Name = "grpMenuBilgileri";
            this.grpMenuBilgileri.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpMenuBilgileri.Size = new System.Drawing.Size(872, 527);
            this.grpMenuBilgileri.TabIndex = 0;
            this.grpMenuBilgileri.TabStop = false;
            this.grpMenuBilgileri.Text = "Menü Bilgileri";
            // 
            // btnMenuyuKaydet
            // 
            this.btnMenuyuKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuyuKaydet.Location = new System.Drawing.Point(348, 348);
            this.btnMenuyuKaydet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMenuyuKaydet.Name = "btnMenuyuKaydet";
            this.btnMenuyuKaydet.Size = new System.Drawing.Size(472, 85);
            this.btnMenuyuKaydet.TabIndex = 3;
            this.btnMenuyuKaydet.Text = "MENÜYÜ KAYDET";
            this.btnMenuyuKaydet.UseVisualStyleBackColor = true;
            this.btnMenuyuKaydet.Click += new System.EventHandler(this.btnMenuyuKaydet_Click);
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.DecimalPlaces = 2;
            this.nmrMenuFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrMenuFiyati.Location = new System.Drawing.Point(348, 240);
            this.nmrMenuFiyati.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nmrMenuFiyati.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(472, 44);
            this.nmrMenuFiyati.TabIndex = 2;
            this.nmrMenuFiyati.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMenuAdi.Location = new System.Drawing.Point(348, 148);
            this.txtMenuAdi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(468, 44);
            this.txtMenuAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menü Fiyatı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Menü_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 596);
            this.Controls.Add(this.grpMenuBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Menü_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menü_Ekle";
            this.grpMenuBilgileri.ResumeLayout(false);
            this.grpMenuBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuBilgileri;
        private System.Windows.Forms.Button btnMenuyuKaydet;
        private System.Windows.Forms.NumericUpDown nmrMenuFiyati;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
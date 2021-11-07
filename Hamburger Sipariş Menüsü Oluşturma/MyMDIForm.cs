using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger_Sipariş_Menüsü_Oluşturma
{
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }

        void ChildForm(Form childForm)      //Form1'i açmasını istiyoruz. Açılan Form başta false yani yok olarak algılıyor. Daha sonra 
        {
            //this.ClientSize = childForm.ClientSize;   Araştır bunu.
            this.Width = childForm.Width + 20;
            this.Height = childForm.Height + 108;

            bool durum = false;     //Formumuz açık mı değil mi

            foreach (Form form in this.MdiChildren)     //
            {
                if(form.Text== childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
        }
        

        private void tsmSiparisOlustur_Click(object sender, EventArgs e)    //Sipariş oluştura basarsak ChildForm metodu çalışcak ve Form1'den açıcak.
        {
            ChildForm(new Sipariş_Oluştur());
        }

        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new Sipariş_Bilgileri());
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Menü_Ekle());
        }

        private void tsmEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Ekstra_Malzeme_Ekle());
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bütün pencereler kapatılsın mı?", "Hepsini kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}

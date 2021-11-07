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
    public partial class Menü_Ekle : Form
    {
        public Menü_Ekle()
        {
            InitializeComponent();
        }

        private void btnMenuyuKaydet_Click(object sender, EventArgs e)
        {
            Sipariş_Oluştur.menuler.Add(new Menü { MenuAdi = txtMenuAdi.Text, Fiyati = nmrMenuFiyati.Value });

            MessageBox.Show("Menü başarılı şekilde eklendi.");
        }
    }
}

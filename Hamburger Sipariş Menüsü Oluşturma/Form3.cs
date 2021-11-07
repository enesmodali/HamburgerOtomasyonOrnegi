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
    public partial class Ekstra_Malzeme_Ekle : Form
    {
        public Ekstra_Malzeme_Ekle()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeKaydet_Click(object sender, EventArgs e)
        {
            Sipariş_Oluştur.ekstralar.Add(new Ekstra { EkstraAdı = txtEkstraMalzemeAdi.Text, Fiyati = nmrEkstraMalzemeFiyati.Value });

            MessageBox.Show("Ekstra Malzeme başarılı şekilde eklendi.");
        }
    }
}

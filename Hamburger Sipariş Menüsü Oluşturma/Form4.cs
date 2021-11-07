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
    public partial class Sipariş_Bilgileri : Form
    {
        public Sipariş_Bilgileri()
        {
            InitializeComponent();
        }

        private void Sipariş_Bilgileri_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach (Sipariş sipariş in Sipariş_Oluştur.tumSiparisler)
            {
                ciro += sipariş.ToplamTutar;

                foreach (Ekstra item in sipariş.EkstraMalzemeSec)
                {
                    ekstraMalzemeGeliri += item.Fiyati;
                }

                satisAdedi += sipariş.SiparisAdedi;

                lbxTümSiparisler.Items.Add(sipariş);
            }
            lblToplamSiparisSayisi.Text = lbxTümSiparisler.Items.Count.ToString();
            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
            lblSatilanUrunAdedi.Text = satisAdedi.ToString();
        }
    }
}

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
    public partial class Sipariş_Oluştur : Form
    {
        public Sipariş_Oluştur()
        {
            InitializeComponent();
        }
        public static List<Sipariş> tumSiparisler = new List<Sipariş>();        //Static yazıyorsa program çalıştığında Ram'de otomatik çalışır. İnstance alıp çağırmama gerek yok.
        public static List<Sipariş> mevcutSiparisler = new List<Sipariş>();

        public static List<Menü> menuler = new List<Menü>()
        {
            new Menü {MenuAdi = "Big King", Fiyati=18.25m },
            new Menü {MenuAdi = "Double King Chicken", Fiyati=19.75m },
            new Menü {MenuAdi = "SteakHouse", Fiyati=22.50m },
            new Menü {MenuAdi = "Whopper", Fiyati=20.00m },
            new Menü {MenuAdi = "Whopper Jr.", Fiyati=17.75m },
            new Menü {MenuAdi = "Chicken Royal", Fiyati=21.25m }

        };

        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra {EkstraAdı = "Ketçap", Fiyati=0.50m },
            new Ekstra {EkstraAdı = "Mayonez", Fiyati=0.50m },
            new Ekstra {EkstraAdı = "Hardal", Fiyati=0.75m },
            new Ekstra {EkstraAdı = "BBQ", Fiyati=1.00m },
            new Ekstra {EkstraAdı = "Ranch", Fiyati=1.00m },
            new Ekstra {EkstraAdı = "Buffalo", Fiyati=1.25m }

        };

        private void Sipariş_Oluştur_Load(object sender, EventArgs e)
        {
            foreach (Menü item in menuler)
                cmBoxMenüler.Items.Add(item);       //ToString() metodunu overide ettiğimiz için .......Menü şeklinde bastıracak.
            foreach (Ekstra item in ekstralar)
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraAdı, Tag = item }); //Tag içinde object tutan bir property dir.
            foreach (Sipariş item in mevcutSiparisler)
                lbxSiparisler.Items.Add(item);      //Form açıldığında mevcut sipariş varsa listbox'a ekleyecek. 

            TutarHesapla();

            rdoKucuk.Checked = true;

            cmBoxMenüler.SelectedIndex = 0; //-1 olursa herhangibir eleman seçili olmaz. 0 olursa ilk eleman seçili gelecektir. Program açıldığında ilk menü Big King seçili gelicek.
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Sipariş gelenSiparis = (Sipariş)lbxSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");

            return toplamTutar;
        }

        private void btnSiparişEkle_Click(object sender, EventArgs e)
        {
            Sipariş yeniSiparis = new Sipariş();
            yeniSiparis.SeciliMenusu = (Menü)cmBoxMenüler.SelectedItem;

            if(rdoKucuk.Checked)
            {
                yeniSiparis.Boyutu = Boyut.Kucuk;
            }
            else if(rdoOrta.Checked)
                yeniSiparis.Boyutu = Boyut.Orta;
            else if (rdoBuyuk.Checked)
                yeniSiparis.Boyutu = Boyut.Buyuk;

            yeniSiparis.EkstraMalzemeSec = new List<Ekstra>();

            foreach (CheckBox item in flpEkstraMalzemeler.Controls)
            {
                if (item.Checked)
                    yeniSiparis.EkstraMalzemeSec.Add((Ekstra)item.Tag);
            }

            yeniSiparis.SiparisAdedi=Convert.ToInt32(nmrSiparis.Value);

            yeniSiparis.Hesapla();

            tumSiparisler.Add(yeniSiparis);
            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            TutarHesapla();

            Fonksiyonlar.Temizle(this.Controls);
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı: " + TutarHesapla().ToString("c2")+"\nSatın almayı tamamlamak ister misiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();     //Label'daki değeri temizlemesi için.
                MessageBox.Show("Siparişiniz Tamamlandı.");
            }
            else
                MessageBox.Show("Siparişiniz İptal Edildi.");
        }
    }
}

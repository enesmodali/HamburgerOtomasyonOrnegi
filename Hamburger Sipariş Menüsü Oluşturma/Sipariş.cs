using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Sipariş_Menüsü_Oluşturma
{
    public class Sipariş
    {
        //public Sipariş()
        //{

        //}

        public Menü SeciliMenusu { get; set; }
        public Boyut Boyutu { get; set; }

        public int SiparisAdedi { get; set; }

        public List<Ekstra> EkstraMalzemeSec { get; set; }

        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenusu.Fiyati;

            switch (Boyutu)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10m;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25m;
                    break;
            }

            foreach (Ekstra item in EkstraMalzemeSec)
            {
                ToplamTutar += item.Fiyati;
            }

            ToplamTutar = ToplamTutar * SiparisAdedi;

        }
        public override string ToString()   //Nesne adıyla çağrıldığında şu şekilde listbox'a bastırılsın.
        {
            if(EkstraMalzemeSec.Count<1)
            {
                return string.Format("{0} Menü x {1} Adet, {2} Boy, Toplam: {3}", SeciliMenusu.MenuAdi, SiparisAdedi, Boyutu.ToString(), ToplamTutar.ToString("C2"));   //C2 = 2 haneli para işaretine çeviriyor.
            }
            else
            {
                string ekstraMalzemeler = null;

                foreach (Ekstra ekstra in EkstraMalzemeSec)
                {
                    ekstraMalzemeler += ekstra.EkstraAdı + ", ";
                }

                ekstraMalzemeler = ekstraMalzemeler.Trim(',');  //Sonundaki virgülü temizler.

                return string.Format("{0} Menü x {1} Adet, {2} Boy, ({3}), Toplam: {4}", SeciliMenusu.MenuAdi, SiparisAdedi, Boyutu.ToString(), ekstraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}

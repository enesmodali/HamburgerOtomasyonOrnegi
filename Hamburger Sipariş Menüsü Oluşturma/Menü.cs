using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Sipariş_Menüsü_Oluşturma
{
    public class Menü
    {
        public string MenuAdi { get; set; }

        public decimal Fiyati { get; set; }

        
        public override string ToString()   //Nesne adıyla çağrıldığında Combobox'da ......... Menü şeklinde görünmesi için.
        {
            return MenuAdi + "Menü";
        }
    }
}

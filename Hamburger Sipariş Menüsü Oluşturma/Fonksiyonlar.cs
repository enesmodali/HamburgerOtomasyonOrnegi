using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger_Sipariş_Menüsü_Oluşturma
{
    //Fonksiyonlar isimli bir class oluşturunuz ve temizle isimli metot oluşturup burdaki her controlü temizleryiniz.
    //Menü comboboxı ilk eleman seçili olucak.
    //Boyut küçük olcak
    //FlowLayoutun içindeki checkler silincek
    //Adet numericUpDown 1 yani minimum değere çekilcek.
    public class Fonksiyonlar
    {
        public static void Temizle(Control.ControlCollection ctrl)    //Formlardan çağrıldığında ilgili kontrolleri temizleyebilecek bir metot tanımladık. Instance almadan çağırabilmek için static olarak tanımlıyoruz.
        {
            {
                foreach (Control item in ctrl)
                {
                    if (item is ComboBox)
                        ((ComboBox)item).SelectedIndex = 0;
                    else if (item is TextBox)
                        ((TextBox)item).Text = "";
                    else if (item is RadioButton)
                    {
                        RadioButton rdo = (RadioButton)item;
                        if (rdo.Name == "rdoKucuk")
                            rdo.Checked = true;
                        else
                            rdo.Checked = false;
                    }
                    else if (item is NumericUpDown)
                    {
                        ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
                    }
                    else if (item is CheckBox)
                        ((CheckBox)item).Checked = false;
                    else if (item is GroupBox)
                        Temizle(((GroupBox)item).Controls);
                    else if (item is FlowLayoutPanel)
                        Temizle(((FlowLayoutPanel)item).Controls);


                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Menu : IMenu
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }

        public void Ekle(Menu menu)
        {
            Database.menuListesi.Add(menu);
        }

        public List<Menu> Listele()
        {
            return Database.menuListesi.ToList();
        }
        //public static List<Menu> Menuler { get; set; }
        public override string ToString()
        {
            return $"{Adi} {Fiyat}";
        }

    }
}

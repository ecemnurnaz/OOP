using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Menu
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public static List<Menu> Menuler { get; set; }
        public override string ToString()
        {
            return Adi;
        }

    }
}

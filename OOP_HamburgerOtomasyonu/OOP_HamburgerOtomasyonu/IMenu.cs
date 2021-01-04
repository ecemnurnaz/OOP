using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public interface IMenu
    {
        List<Menu> Listele();
        void Ekle(Menu menu);

    }
}

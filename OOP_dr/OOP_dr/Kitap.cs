using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dr
{
    public class Kitap : Urun
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public int BasimYili { get; set; }
        public string YayinEvi { get; set; }
        public string KapakTuru { get; set; }
    }
}

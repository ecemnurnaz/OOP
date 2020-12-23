using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dr
{
    public class Muzik : Urun
    {
        public string SanatciAdi { get; set; }
        public string AlbumAdi { get; set; }
        public int CikisYili { get; set; }
        public string Dil { get; set; }
        public string Turu { get; set; }
    }
}

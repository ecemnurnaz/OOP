using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dr
{
    public class Elektronik : Urun
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool SarjliMi { get; set; }
        public bool KabloluMu { get; set; }
    }
}

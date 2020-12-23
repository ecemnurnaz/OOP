using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dr
{
    public class Telefon : Elektronik
    {
        public int sarjKapasitesi { get; set; }
        public int RamKapasitesi { get; set; }
        public int Hafiza { get; set; }
        public bool KablosuzSarjVarMi { get; set; }
    }
}

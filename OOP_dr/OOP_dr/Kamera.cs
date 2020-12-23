using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dr
{
    public class Kamera : Elektronik
    {
        public int CekimKalitesi { get; set; }
        public double CekimFrekansAraligi { get; set; }
        public int Hafiza { get; set; }
    }
}

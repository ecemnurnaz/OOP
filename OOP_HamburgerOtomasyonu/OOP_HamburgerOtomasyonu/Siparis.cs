﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Siparis
    {
        public string Menu { get; set; }
        public string Boyut { get; set; }
        public string Ekstra { get; set; }
        public int Adet { get; set; }
        public decimal AraToplam { get; set; }
        public override string ToString()
        {
            return Menu + Boyut + Ekstra + Adet;
        }
    }
}

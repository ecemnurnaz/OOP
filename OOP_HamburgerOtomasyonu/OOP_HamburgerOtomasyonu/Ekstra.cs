using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Ekstra : IEkstra
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }

        public void Ekle(Ekstra ekstra)
        {
            Database.ekstraListesi.Add(ekstra);
        }

        public List<Ekstra> Listele()
        {
            return Database.ekstraListesi.ToList();
        }
        public override string ToString()
        {
            return $"{Adi} {Fiyat}";
        }
        

    }
}

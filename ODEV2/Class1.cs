using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV2
{
    // Genel Müdür Sınıfı
    public class GenelMudur : Calisan
    {
        public GenelMudur(string ad) : base(ad, "Genel Müdür") { }

        public override decimal MaasinizNedir()
        {
            return 80000;
        }
    }

    // Müdür Sınıfı
    public class Mudur : Calisan
    {
        public Mudur(string ad) : base(ad, "Müdür") { }

        public override decimal MaasinizNedir()
        {
            return 60000;
        }
    }

    // Programcı Sınıfı
    public class Programci : Calisan
    {
        public Programci(string ad) : base(ad, "Programcı") { }

        public override decimal MaasinizNedir()
        {
            return 40000;
        }
    }

    // Stajyer Sınıfı
    public class Stajyer : Calisan
    {
        public Stajyer(string ad) : base(ad, "Stajyer") { }

        public override decimal MaasinizNedir()
        {
            return 5000;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV3
{
    // BMW Sınıfı
    public class BMW : Araba
    {
        public BMW() : base("BMW", 80.0) { }
    }

    // Mercedes Sınıfı
    public class Mercedes : Araba
    {
        public Mercedes() : base("Mercedes", 70.0) { }
    }

    // Porsche Sınıfı
    public class Porsche : Araba
    {
        public Porsche() : base("Porsche", 60.0) { }
    }

}

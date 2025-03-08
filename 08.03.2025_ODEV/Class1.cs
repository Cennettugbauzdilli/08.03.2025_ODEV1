using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._03._2025_ODEV
{
    // BMW sınıfı, IHareket interface'ini uygular ve tüm hareketleri gerçekleştirir
    public class BMW : IHareket
    {
        public void Git()
        {
            Console.WriteLine("BMW çok hızlı gider.");
        }

        public void Yuz()
        {
            Console.WriteLine("BMW denizde yüzer.");
        }

        public void Uc()
        {
            Console.WriteLine("BMW havada uçar.");
        }
    }

    // Mercedes sınıfı, IHareket interface'ini uygular ancak sadece yüzme ve uçma özelliklerine sahiptir
    public class Mercedes : IHareket
    {
        public void Git()
        {
            Console.WriteLine("Mercedes karada gitme özelliğine sahip değildir.");
        }

        public void Yuz()
        {
            Console.WriteLine("Mercedes denizde yüzer.");
        }

        public void Uc()
        {
            Console.WriteLine("Mercedes havada uçar.");
        }
    }

    // Porsche sınıfı, IHareket interface'ini uygular ancak sadece uçabilir
    public class Porsche : IHareket
    {
        public void Git()
        {
            Console.WriteLine("Porsche karada gitme özelliğine sahip değildir.");
        }

        public void Yuz()
        {
            Console.WriteLine("Porsche denizde yüzme özelliğine sahip değildir.");
        }

        public void Uc()
        {
            Console.WriteLine("Porsche havada uçar.");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public sealed class Crocodile : Reptile, IHunt
    {
        public Crocodile(string name, double weight, ushort birthYear) : base(name, weight, birthYear)
        {
        }
        public override void Crawl()
        {
            Console.WriteLine("Крокодил ползёт со скоростью 2 км/ч");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Шшшшшш!");
        }
            public override bool IsHunt()
            {
                Console.WriteLine("Крокодил - хищник (из абстрактного класса Animal)");
                return true;
            }

            bool IHunt.IsHunt()
            {
                Console.WriteLine("Крокодил - хищник (из интерфейса Hunt)");
                return true;
            }
    }
}

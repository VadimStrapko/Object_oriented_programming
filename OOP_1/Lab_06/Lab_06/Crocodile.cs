using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public sealed partial class Crocodile : Reptile
    {
        public Crocodile(string name, double weight, ushort birthYear) : base(name, weight, birthYear, new AnimalInfo
        {
            Habitat = "Тропические реки и болота",
            ConservationStatus = "Мало охраняемый"
        })
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
    }
}

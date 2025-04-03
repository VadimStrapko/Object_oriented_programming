using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public sealed class Lion : Mammal
    {
        public Lion(string name, double weight, ushort birthYear) : base(name, weight, birthYear, new AnimalInfo
        {
            Habitat = "Саванна",
            ConservationStatus = "Уязвимый"
        })
        {
        }
        public override void Run()
        {
            Console.WriteLine("Лев бежит со скоростью 74 км/ч");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Грррр!");
        }
        public override bool IsHunt()
        {
            return true;
        }
    }
}

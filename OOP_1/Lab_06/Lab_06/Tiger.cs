using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public sealed class Tiger : Mammal
    {
        public Tiger(string name, double weight, ushort birthYear) : base(name, weight, birthYear, new AnimalInfo
        {
            Habitat = "Саванна",
            ConservationStatus = "Умеренно охраняемый"
        })
        {
        }
        public override void Run()
        {
            Console.WriteLine("Тигр бежит со скоростью 65 км/ч");
        }
        public override void MakeSound()
        {
            Console.WriteLine("РРРРРРР!");
        }
        public override bool IsHunt()
        {
            return true;
        }
    }
}

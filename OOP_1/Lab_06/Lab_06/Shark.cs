using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public sealed class Shark : Fish
    {
        public Shark(string name, double weight, ushort birthYear) : base(name, weight, birthYear, new AnimalInfo
        {
            Habitat = "Океан",
            ConservationStatus = "Умеренно охраняемый"
        })
        {
        }
        public override void Swim()
        {
            Console.WriteLine("Акула плывет со скоростью 19 км/ч");
        }
        public override void MakeSound()
        {
            Console.WriteLine("*Вибрация*");
        }
        public override bool IsHunt()
        {
            return true;
        }
    }
}

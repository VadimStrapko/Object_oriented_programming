using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public sealed class Owl : Bird
    {
        public Owl(string name, double weight, ushort birthYear) : base(name, weight, birthYear, new AnimalInfo
        {
            Habitat = "Лес",
            ConservationStatus = "Мало охраняемый"
        })
        {
        }
        public override void Fly()
        {
            Console.WriteLine("Сова летит за жертвой!");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Ху-ху!");
        }
        public override bool IsHunt()
        {
            return true;
        }
    }
}

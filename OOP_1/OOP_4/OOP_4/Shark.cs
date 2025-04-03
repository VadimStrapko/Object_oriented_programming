using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public sealed class Shark : Fish
    {
        public Shark(string name, double weight, ushort birthYear) : base(name, weight, birthYear)
        {
        }
        public override void Swim()
        {
            Console.WriteLine("Акула плывет со скоростью 19 км/ч");
        }
        public override void MakeSound()
        {
            Console.WriteLine("У акулы беззвучный режим");
        }
        public override bool IsHunt()
        {
            Console.WriteLine("Акула - хищник");
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public sealed class Lion : Mammal
    {
        public Lion(string name, double weight, ushort birthYear) : base(name, weight, birthYear)
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
            Console.WriteLine("Лев - хищник");
            return true;
        }
    }
}

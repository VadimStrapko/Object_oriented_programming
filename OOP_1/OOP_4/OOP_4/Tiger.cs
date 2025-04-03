using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{

    public sealed class Tiger : Mammal
    {

        public Tiger(string name, double weight, ushort birthYear) : base(name, weight, birthYear)
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
            Console.WriteLine("Тигр - хищник");
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public sealed class Parrot : Bird
    {
        public Parrot(string name, double weight, ushort birthYear) : base(name, weight, birthYear)
        {
        }
        public override void Fly()
        {
            Console.WriteLine("Попугай летит!");
        }
        public override void MakeSound()
        {
            Console.WriteLine("*Звуки попугая*");
        }
        public override bool IsHunt()
        {
            Console.WriteLine("Попугай - травоядный");
            return false;
        }
    }
}

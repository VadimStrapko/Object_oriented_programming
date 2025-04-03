using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public sealed class Owl : Bird
    {

        public Owl(string name, double weight, ushort birthYear) : base(name, weight, birthYear)
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
            Console.WriteLine("Сова - хищник");
            return true;
        }
    }
}

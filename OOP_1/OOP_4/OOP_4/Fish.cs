using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public abstract class Fish : Animal, IAnimal
    {

        public Fish(string name, double weight, ushort birthYear) : base(name, weight, birthYear)
        {
        }
        public abstract void Swim();
    }
}

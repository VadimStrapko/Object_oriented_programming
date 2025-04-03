using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public abstract class Fish : Animal, IAnimal
    {

        public Fish(string name, double weight, ushort birthYear, AnimalInfo info) : base(name, weight, birthYear, info)
        {
        }
        public abstract void Swim();
    }
}

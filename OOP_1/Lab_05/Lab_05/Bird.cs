using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    public abstract class Bird : Animal, IAnimal
    {
        public Bird(string name, double weight, ushort birthYear, AnimalInfo info) : base(name, weight, birthYear, info)
        {
        }
        public abstract void Fly();
    }
}

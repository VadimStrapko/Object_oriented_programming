using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public abstract class Reptile : Animal, IAnimal
    {
        public Reptile(string name, double weight, ushort birthYear) : base(name, weight, birthYear)
        {
        }
        public abstract void Crawl();
    }
}

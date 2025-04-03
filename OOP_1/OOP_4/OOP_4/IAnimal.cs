using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public interface IAnimal
    {
        double kg_weight { get; set; }
        string Name { get; set; }

        ushort year_of_birth { get; set; }
        void MakeSound();

    }
}

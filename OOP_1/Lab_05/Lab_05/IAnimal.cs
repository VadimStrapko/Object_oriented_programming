using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    public interface IAnimal
    {
        double kg_weight { get; set; }
        string Name { get; set; }

        public ushort year_of_birth { get; set; }
        void MakeSound();

    }
}

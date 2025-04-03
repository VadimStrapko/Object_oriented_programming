using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class AnimalException : Exception
    {
        //связан с операциями или состоянием объектов типа Animal
        public AnimalException(string message) : base(message) { }
    }
}

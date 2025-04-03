using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public class Printer
    {
        public void IAmPrinting(Animal someObj)
        {
            Console.WriteLine(someObj.ToString());
        }
    }
}

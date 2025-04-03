using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class Printer
    {
        public void IAmPrinting(Animal someObj)
        {
            Console.WriteLine(someObj.ToString());
        }
    }
}

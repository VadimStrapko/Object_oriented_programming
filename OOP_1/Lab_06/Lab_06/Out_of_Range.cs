using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class Out_of_Range : ArgumentOutOfRangeException
    {
        public int value;
        public Out_of_Range(string paramName, int actualValue, int minValue, int maxValue) : base(paramName, actualValue, $"Значение {actualValue} вышло за пределы. Оно должно быть между {minValue} и {maxValue}.") { }

        public string About_exception()
        {
            Console.WriteLine(Message);
            Console.WriteLine(StackTrace);
            return Message;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class OutOfYearRange : Out_of_Range
    {
        //связан с выходом значения за пределы допустимого диапазона года
        public OutOfYearRange(string paramName, int actualValue, int minValue, int maxValue)
        : base(paramName, actualValue, minValue, maxValue)
        {
        }
    }
}

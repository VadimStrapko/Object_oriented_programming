using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    internal class Program
    {
        public interface Person<T>
        {
            void Add(T item);
            void Delete(T item);
            void GetItem(T item);
        }
        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
 class Program
{
    static void Main()
    {
        CustomQueue<int> customQueue1 = new CustomQueue<int>();
        customQueue1 = customQueue1 + 5;
        customQueue1 = customQueue1 + 10;
        customQueue1 = customQueue1 + 3;
        customQueue1--;

        CustomQueue<int> customQueue2 = new CustomQueue<int>();
        customQueue2 = customQueue2 + 7;
        customQueue2 = customQueue2 + 1;

        customQueue1 = customQueue1 < customQueue2;

        Console.WriteLine("Количество элементов в очереди: " + (int)customQueue1);
        Console.WriteLine("Индекс первого вхождения числа 10: " + customQueue1.FirstIndex(10));
        Console.WriteLine("Последний элемент: " + customQueue1.LastElement());


        Console.WriteLine("Пуста ли очередь? " + (customQueue1 == true));

        /////////////////////////////////////////////////////////////////////////////////////////

        Console.WriteLine("Сумма: " + StatisticOperation.Sum(customQueue1));
        Console.WriteLine("Разница: " + StatisticOperation.Difference(customQueue1));
        Console.WriteLine("Количество: " + StatisticOperation.Count(customQueue1));

        string str = "Hello, World!";
        Console.WriteLine("Длина строки: " + str.Length);

        CustomQueue<string> stringQueue = new CustomQueue<string>();
        stringQueue = stringQueue + "Line 1";
        stringQueue = stringQueue + "Line 2";
        Console.WriteLine(" Количество строк в очереди строк: " + stringQueue.CountLines());

    }
}
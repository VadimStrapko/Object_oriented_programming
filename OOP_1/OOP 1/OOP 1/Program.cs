using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            switch (a)
            {


                case 1:
                    int intValue;
                    bool boolValue;
                    short shortValue;
                    sbyte sbyteValue;
                    long longValue;
                    byte byteValue;
                    ushort ushortValue;
                    uint uintValue;
                    ulong ulongValue;
                    object b = 184; 
                    object c = "д21у2щ3";  
                    Console.WriteLine("Введите число типа int: ");
                    intValue = int.Parse(Console.ReadLine());
                    Console.WriteLine(intValue);

                    Console.WriteLine("Введите число типа bool: ");
                    boolValue = bool.Parse(Console.ReadLine());
                    Console.WriteLine(boolValue);

                    Console.WriteLine("Введите число типа short: ");
                    shortValue = short.Parse(Console.ReadLine());
                    Console.WriteLine(shortValue);

                    Console.WriteLine("Введите число типа sbyte: ");
                    sbyteValue = sbyte.Parse(Console.ReadLine());
                    Console.WriteLine(sbyteValue);

                    Console.WriteLine("Введите число типа long: ");
                    longValue = long.Parse(Console.ReadLine());
                    Console.WriteLine(longValue);

                    Console.WriteLine("Введите число типа byte: ");
                    byteValue = byte.Parse(Console.ReadLine());
                    Console.WriteLine(byteValue);

                    Console.WriteLine("Введите число типа ushort: ");
                    ushortValue = ushort.Parse(Console.ReadLine());
                    Console.WriteLine(ushortValue);

                    Console.WriteLine("Введите число типа uint: ");
                    uintValue = uint.Parse(Console.ReadLine());
                    Console.WriteLine(uintValue);

                    Console.WriteLine("Введите число типа ulong: ");
                    ulongValue = ulong.Parse(Console.ReadLine());
                    Console.WriteLine(ulongValue);
                    //неявное приведение
                    int Value1 = 12;
                    float Value2 = Convert.ToSingle(Value1);
                    uint q = 10;
                    double w = Convert.ToSingle(q);
                    long t = 10;
                    double v = t;
                    ulong u = 10;
                    double j = u;
                    short i = 10;
                    double e = i;
                    //явное приведение
                    double Value3 = 9.5;
                    int Value4 = Convert.ToInt32(Value3);
                    //упаковка
                    int Value5 = 12;
                    object Value6 = Value5;
                    //распаковка
                    object Value7 = 12;
                    int Value8 = (int)Value7;
                    //неявно типизированная переменная
                    var Value9 = 12;
                    var STRING = "DSWGKEUIFO";
                    //работа с nullable
                    int? nullableInt = null;
                    //ошибка с var
                    //var Value10 = 12;
                    //var Value10 = 10.3;
                    break;

                case 2:
                    ////строковые литералы
                    string literal = "qweer";
                    string literal2 = "1+2+3";

                    string string1 = "qwdsfghjert dfolikjhgf fdflkjyhtgrfe";
                    string delete = "qwdsfghjert";
                    string string2 = "hello re wq";
                    string string3 = "yu iop sd dsq";
                    //сцеление
                    string concatenation = string1 + string2;
                    //копирование
                    string copy = string3;
                    //выделение подстроки
                    string substring = string1.Substring(4, 3);
                    //разделение строки на слова
                    string[] separation = string2.Split();
                    //вставки подстроки в заданную позицию
                    //string result = string1.Insert(4, string3);
                    //удаление заданной подстроки
                    string resString = string1.Replace(delete, "");
                    Console.WriteLine(resString);
                    //интерполирование
                    string reSTR = $"qwer {literal} rdkgermk {literal2}";

                    string nullstr = null;
                    bool res = string.IsNullOrEmpty(nullstr);//true

                    //создайте строку на основе StringBuilder 
                    var sb = new StringBuilder("Hello World"); //динамическая строка
                    break;

                case 3:
                    // Объявление и инициализация двумерного массива(матрица)
                    int[,] numbers = {
                                     {1, 2, 3},
                                     {4, 5, 6},
                                     {7, 8, 9}
                                               };

                    Console.WriteLine("\nДвумерный массив (матрица): ");
                    int rows = numbers.GetLength(0);
                    int columns = numbers.GetLength(1);

                    for (int iv = 0; iv < rows; iv++)
                    {
                        for (int p = 0; p < columns; p++)
                        {
                            Console.Write($"{numbers[iv, p]} \t");
                        }
                        Console.WriteLine();
                    }

                    //одномерный массив строк
                    int[] arrayMy = { 12, 13, 14, 15, 16, 17, 44 };
                    int lenght = arrayMy.Length;
                    //for (int i = 0; i < 6; i++)
                    //{
                    //    Console.WriteLine(arrayMy[i]);

                    //}
                    Console.WriteLine("Вывод длинны массива: " + lenght);
                    double[][] Array = new double[3][];
                    Array[0] = new double[2] { 1.1, 1.2 };
                    Array[1] = new double[3] { 2.1, 2.2, 2.3 };
                    Array[2] = new double[4] { 3.1, 3.2, 3.3, 3.4 };

                    //for (int i = 0; i < Array.Length; i++)
                    //{
                    //    for (int j = 0; j < Array[i].Length; j++)
                    //    {
                    //        Console.Write(Array[i][j] + " ");
                    //    }
                    //    Console.WriteLine();
                    //}
                    int[][] nums = new int[3][];
                    nums[0] = new int[] { 1, 2 };
                    nums[1] = new int[] { 1, 2, 3 };
                    nums[2] = new int[] { 1, 2, 3, 4, 5 };
                    foreach (int[] row in nums)
                    {
                        foreach (int number in row)
                        {
                            Console.Write($"{number} \t");
                        }
                        Console.WriteLine();
                    }
                    // перебор с помощью цикла for
                    for (int g = 0; g < nums.Length; g++)
                    {
                        //for (int j = 0; j < nums[g].Length; j++)
                        //{
                          //  Console.Write($"{nums[g][j]}\t");
                        //}
                        //Console.WriteLine();
                    }
                                        
                    //var myArray = new[] { 1, 2, 3, 4, 5 };
                    //var myString = "Это неявно типизированная строка.";
                    break;

                case 4:
                    var kortesh = ("wifiuwn", "qwertyuio", 'W', "asdfghjkl", 21);
                    (string frt, string two, char tre, string four, int five) = kortesh;//распаковка
                    //(_, string two, char tre, _, int five) = kortesh;
                  
                    Console.WriteLine(kortesh);
                    int n;
                    n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Первый элемент: " + frt);
                    Console.WriteLine("Третий элемент:" + tre);
                    Console.WriteLine("Четвертый элемент: " + four);
                    var krt1 = (12, 23, "qwerty");
                    var krt2 = (23, 21, "grngnwe");
                    if (krt1 == krt2)
                    {
                        Console.WriteLine("Кортежи равны");
                    }
                    else Console.WriteLine("Кортежи не равны");
                    break;

                case 5:
                    int[] nmb = { 5, 12, 8, 7, 15 };
                    string str = "Hello, world!";

                    // локальная функция для выполнения задачи
                    (int max, int min, int sum, char frtChar) CalculateInfo()
                    {
                        if (nmb.Length == 0)
                            throw new ArgumentException("Массив чисел пуст.");

                        int max = nmb.Max();
                        int min = nmb.Min();
                        int sum = nmb.Sum();
                        char frtChar = str.FirstOrDefault();

                        return (max, min, sum, frtChar);
                    }

                    // Вызов локальной функции
                    var result = CalculateInfo();

                    Console.WriteLine($"Максимальное значение: {result.max}");
                    Console.WriteLine($"Минимальное значение: {result.min}");
                    Console.WriteLine($"Сумма элементов: {result.sum}");
                    Console.WriteLine($"Первая буква строки: {result.frtChar}");
                    break;

                case 6:
                    int z2 = 1;
                    int localfunction2()
                    {
                        int z1 = Int32.MaxValue;

                        unchecked //результат усекается, чтобы не выйти за пределы диапазона представления чисел для целевого типа выражения
                        {
                            z1 += z2;
                            Console.WriteLine(z1);
                        }
                        return z1;
                    }

                    int localfunction1()
                    {
                        int z1 = Int32.MaxValue;
                        checked
                        {
                            z1 += z2;
                            Console.WriteLine(z1);
                        }
                        return z1;
                    }

                    Console.WriteLine(localfunction2()); //мусор выводится

                    try
                    {
                        Console.WriteLine(localfunction1());
                    }

                    catch
                    {
                        Console.WriteLine("Ошибка!");
                        
                    }
                    break;
            }

            

        }
    }
}

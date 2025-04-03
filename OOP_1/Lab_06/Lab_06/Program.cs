using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates; 

namespace Lab_06
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            ZooController zooController = new ZooController();

            Animal lion = new Lion("Simba", 190, 1999);
            Animal owl = new Owl("Hedwig", 0.2, 2010);
            Animal owl2 = new Owl("Hedwig", 0.2, 2010);
            Animal tiger = new Tiger("Rajah", 250, 2005);
            Animal crocodile = new Crocodile("Croc", 400, 1990);
            Animal shark = new Shark("Jaws", 1000, 1979);
            Animal parrot = new Parrot("Polly", 0.456, 2020);

            zooController.AddAnimal(lion);
            zooController.AddAnimal(owl);
            zooController.AddAnimal(owl2);
            zooController.AddAnimal(tiger);
            zooController.AddAnimal(crocodile);
            zooController.AddAnimal(shark);
            zooController.AddAnimal(parrot);

            double avgLionWeight = zooController.GetAverageWeightByType((AnimalType)1);
            int predatoryBirdCount = zooController.CountPredatoryBirds();

            Console.WriteLine($"Средний вес млекопитающих: {avgLionWeight} кг");
            Console.WriteLine($"Количество хищных птиц: {predatoryBirdCount}");

            Console.WriteLine("Животные, отсортированные по году рождения:");
            zooController.SortAnimalsByBirthYear();
            //////////////////////////////////////////////////////////////////////////
            try 
            {
                Animal lion2 = new Lion("Vadim", -190, 1999); // Вес не может быть отрицательным
                zooController.AddAnimal(lion2); // Здесь будет сгенерировано исключение AnimalInitializationException
                                                // пользовательский класс исключения, который наследуется от ArgumentException.
            }
            catch (AnimalInitializationException ex)
            {
                Console.WriteLine($"Общая ошибка животного: {ex.Message}");

                // Используем Debugger для вставки точки останова в случае исключения
                Debugger.Break();
            }
            finally
            {
                Console.WriteLine("Блок finally выполняется всегда.");
            }
            //разные типы
            try
            {
                Crocodile crocObj1 = lion as Crocodile; // приведение типов не произошло и movieObj1 принял значение null 
                crocObj1.Crawl();  // и при обращении возникл exception 
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message + "(Null значение)");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Идем в finally");
                Console.WriteLine();
                Console.WriteLine("--------------------------------");
                try
                {

                    int a = 200000;
                    int b = 200000;
                    int c = checked(a * b);

                }
                //переполнение
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.HelpLink);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine(ex.StackTrace);
                }

                finally { Console.WriteLine("Вложенность продемонстрирована"); }
            }
            try
            {
                Animal parrot2 = new Parrot("Петя", 0.5, 1900);
                if (parrot2.year_of_birth < 1935) throw new OutOfYearRange("Год рождения", parrot2.year_of_birth, minValue: 1935, maxValue: 2023);
            }
            //////////////////////////////////////////////////////////////////////////

            catch (OutOfYearRange ex)
            {
                ex.About_exception();


            }
            Animal[] animals2 = { lion, crocodile, parrot };
            Printer printer = new Printer();
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            try
            {
                printer.IAmPrinting(animals2[3]);
            }
            // индекс выходит за пределы массива, то есть получить доступ к элементу с индексом 3 
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(DateTime.Now);
                Console.WriteLine(ex.HelpLink);

            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            try
            {
                // Исключение пользовательское
                throw new AnimalException("Это пользовательское исключение.");
            }
            //////////////////////////////////////////////////////////////////////////

            catch (AnimalException ex)
            {
                Console.WriteLine("Пользовательское исключение:");
                Console.WriteLine($"Исключение: {ex.GetType().Name}");
                Console.WriteLine($"Сообщение: {ex.Message}");
            }
            //универсальный(для перехвата всех исключений)
            catch (Exception ex)
            {
                Console.WriteLine("Универсальный обработчик catch:");
                Console.WriteLine($"Исключение: {ex.GetType().Name}");
                Console.WriteLine($"Сообщение: {ex.Message}");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------------");
            }
            //используется для вставки точки останова в коде
            Debugger.Break();// Приостанавливает выполнение программы и открывает отладчик
            int[] aa = null;
            //используется для проверки условия
            Debug.Assert(aa != null, "Values array cannot be null");
            Debug.WriteLine("asdasdasd");
            int x = 10;
            //используется для вывода отладочной информации в консоль
            Debug.Assert(x == 10, "x должно быть равно 10.");
        }
    }

}
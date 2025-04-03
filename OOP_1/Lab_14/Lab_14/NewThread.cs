using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_14
{
    static class NewThread
    {
        public static void OutputNumber(object? n)
        {
            int num = (int)n;
            for (int i = 2; i <= num; i++)
            {
                if (IsPrime(i))
                {
                    
                    Console.WriteLine($"Простое число: {i}");

                    using (StreamWriter writer = new StreamWriter("primes.txt", true))
                    {
                        writer.WriteLine(i);
                    }

                   
                    Thread.Sleep(500);
                }
            }
        }
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        
        public static void CreateThread(int n)
        {
            //Thread myThread1 = new Thread(My);
            Thread myThread = new Thread(new ParameterizedThreadStart(OutputNumber));
            myThread.Start(n);

            
            myThread.Name = "NewThread";
            Console.WriteLine("Имя потока: " + myThread.Name + "\t Приоритет: " + myThread.Priority + "\t Числовой идентификатор: " + myThread.ManagedThreadId
                + "\t Состояние потока: " + myThread.ThreadState);
            try
            {
                
                myThread.Suspend();

               
                Console.WriteLine($"Статус потока: {myThread.ThreadState}");

                
                myThread.Resume();

                
                myThread.Join();

                Console.WriteLine("Главный поток завершается.");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}

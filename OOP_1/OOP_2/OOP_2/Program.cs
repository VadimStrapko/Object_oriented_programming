using System;

namespace ConsoleApp1
{
    public class Stack
    {
        private static int objectCount = 0; // Статическое поле для хранения количества созданных объектов

        private int id; // Закрытое поле для хранения ID
        public int Id // Свойство для доступа к ID с геттером и сеттером
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public const double Value = 1213; // Публичное константное поле

        static Stack()
        {
            // Статический конструктор
        }

        public Stack()
        {
            // Конструктор без параметров
            id = GetHashCode();
            objectCount++; // Увеличиваем счетчик созданных объектов при создании нового объекта
        }

        public Stack(double x)
        {
            // Конструктор с одним параметром
            id = GetHashCode();
            objectCount++; // Увеличиваем счетчик созданных объектов при создании нового объекта
        }

        private Stack(double x, double y)
        {
            // Закрытый конструктор
            id = GetHashCode();
            objectCount++; // Увеличиваем счетчик созданных объектов при создании нового объекта
        }

        // Переопределение метода Equals для сравнения объектов
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Stack other = (Stack)obj;
            return Id == other.Id;
        }

        // Переопределение метода GetHashCode для вычисления хэша объекта
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        // Переопределение метода ToString для вывода информации об объекте
        public override string ToString()
        {
            return $"Stack Object - ID: {Id}";
        }

        // Статический метод для вывода информации о классе
        public static void PrintClassInfo()
        {
            Console.WriteLine($"Class Stack. Number of objects created: {objectCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack1 = new Stack();
            stack1.Id = 42; // Установка значения свойства Id
            int idValue1 = stack1.Id; // Чтение значения свойства Id
            Console.WriteLine($"ID: {idValue1}");

            Stack stack2 = new Stack(3.14);

            // Сравнение объектов
            Console.WriteLine("stack1 equals stack2: " + stack1.Equals(stack2));

            // Проверка типа созданных объектов
            Console.WriteLine("Type of stack1: " + stack1.GetType());
            Console.WriteLine("Type of stack2: " + stack2.GetType());

            // Создание массива объектов вашего типа
            Stack[] stackArray = { stack1, stack2 };

            // Вывод информации о массиве объектов
            foreach (var stack in stackArray)
            {
                Console.WriteLine(stack.ToString());
            }

            // Создание и вывод анонимного типа
            var anonymousObject = new { Name = "Anonymous Object", Value = 12345 };
            Console.WriteLine($"Anonymous Object - Name: {anonymousObject.Name}, Value: {anonymousObject.Value}");

            Stack.PrintClassInfo(); // Вызов статического метода для вывода информации о классе
        }
    }
}

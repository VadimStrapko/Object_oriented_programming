using System;
using System.Collections.Generic;
using System.Linq;

class RealStack
{
    private List<double> stack;

    public RealStack()
    {
        stack = new List<double>();
    }

    public double this[int index]
    {
        get
        {
            if (index < 0 || index >= stack.Count)
                throw new IndexOutOfRangeException("Индекс вне диапазона");
            return stack[index];
        }
    }

    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    public int Count()
    {
        return stack.Count;
    }

    public void Push(double item)
    {
        stack.Add(item);
    }

    public double Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Стек пуст");
        double item = stack.Last();
        stack.RemoveAt(stack.Count - 1);
        return item;
    }

    public IEnumerable<double> GetAllItems()
    {
        return stack.AsEnumerable();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем массив объектов RealStack
        RealStack[] stacks = new RealStack[5];
        Random random = new Random();

        for (int i = 0; i < stacks.Length; i++)
        {
            stacks[i] = new RealStack();

            // Заполняем стеки случайными элементами
            for (int j = 0; j < 5; j++)
            {
                double randomValue = random.NextDouble() * 10 - 5; // От -5 до 5
                stacks[i].Push(randomValue);
            }
        }

        // a) Находим стек с наименьшим и наибольшим верхним элементом
        RealStack minStack = stacks.Where(stack => !stack.IsEmpty()).OrderBy(stack => stack[0]).FirstOrDefault();
        RealStack maxStack = stacks.Where(stack => !stack.IsEmpty()).OrderByDescending(stack => stack[0]).FirstOrDefault();

        if (minStack != null)
        {
            Console.WriteLine("Стек с наименьшим верхним элементом:");
            foreach (var item in minStack.GetAllItems())
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Все стеки пусты.");
        }

        if (maxStack != null)
        {
            Console.WriteLine("Стек с наибольшим верхним элементом:");
            foreach (var item in maxStack.GetAllItems())
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Все стеки пусты.");
        }

        // b) Находим стеки, содержащие отрицательные элементы
        var stacksWithNegatives = stacks.Where(stack => !stack.IsEmpty() && stack[0] < 0).ToList();

        if (stacksWithNegatives.Count > 0)
        {
            Console.WriteLine("Список стеков, содержащих отрицательные элементы:");
            foreach (var stack in stacksWithNegatives)
            {
                foreach (var item in stack.GetAllItems())
                {
                    Console.WriteLine(item);
                }
            }
        }
        else
        {
            Console.WriteLine("Нет стеков, содержащих отрицательные элементы.");
        }
    }
}

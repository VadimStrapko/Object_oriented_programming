using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;



// Основной класс Queue
public class CustomQueue<T>
{
    // Вложенный объект Production
    class Production
    {
        public int Id { get; set; }
        public string OrganizationName { get; set; }

        public Production(int id, string organizationName)
        {
            Id = id;
            OrganizationName = organizationName;
        }
    }

    // Вложенный класс Developer
    class Developer
    {
        public string FullName { get; set; }
        public int Id { get; set; }
        public string Department { get; set; }

        public Developer(string fullName, int id, string department)
        {
            FullName = fullName;
            Id = id;
            Department = department;
        }
    }
    private Queue<T> queue;

    public CustomQueue()
    {
        queue = new Queue<T>();
    }

    public Queue<T> Queue
    {
        get { return queue; }
    }

    // Перегрузка оператора + для добавления элемента в очередь
    public static CustomQueue<T> operator +(CustomQueue<T> customQueue, T item)
    {
        customQueue.queue.Enqueue(item);
        return customQueue;
    }

    // Перегрузка оператора -- для извлечения элемента из очереди
    public static CustomQueue<T> operator --(CustomQueue<T> customQueue)
    {
        customQueue.queue.Dequeue();
        return customQueue;
    }

    // Перегрузка оператора true для проверки, пустая ли очередь
    public static bool operator true(CustomQueue<T> customQueue)
    {
        return customQueue.queue.Count == 0;
    }

    public static bool operator false(CustomQueue<T> customQueue)
    {
        return customQueue.queue.Count > 0;
    }

    // Перегрузка оператора < для копирования и сортировки очереди в убывающем порядке
    public static CustomQueue<T> operator <(CustomQueue<T> customQueue1, CustomQueue<T> customQueue2)
    {
        var sortedQueue = new CustomQueue<T>();
        var sortedList = customQueue1.queue.OrderByDescending(x => x).ToList();
        foreach (var item in sortedList)
        {
            sortedQueue.queue.Enqueue(item);
        }
        return sortedQueue;
    }

    public static CustomQueue<T> operator >(CustomQueue<T> customQueue1, CustomQueue<T> customQueue2)
    {
        var sortedQueue = new CustomQueue<T>();
        var sortedList = customQueue1.queue.OrderBy(x => x).ToList();
        foreach (var item in sortedList)
        {
            sortedQueue.queue.Enqueue(item);
        }
        return sortedQueue;
    }
    // Неявное преобразование в int - мощность очереди
    public static implicit operator int(CustomQueue<T> customQueue)
    {
        return customQueue.queue.Count;
    }

    public static bool operator ==(CustomQueue<T> customQueue, bool value)
    {
        return (customQueue.queue.Count == 0) == value;
    }

    public static bool operator !=(CustomQueue<T> customQueue, bool value)
    {
        return (customQueue.queue.Count == 0) != value;
    }
}

// Необобщенный статический класс с методами расширения
public static class CustomQueueExtensions
{
    // Метод расширения: Индекс первой точки
    public static int FirstIndex(this CustomQueue<int> customQueue, int item)
    {
        return customQueue.Queue.ToList().IndexOf(item);
    }

    // Метод расширения: Последний элемент очереди
    public static int LastElement(this CustomQueue<int> customQueue)
    {
        return customQueue.Queue.LastOrDefault();
    }
}




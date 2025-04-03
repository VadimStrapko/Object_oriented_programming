using System.Linq;

static class StatisticOperation
{
    // Метод для вычисления суммы элементов в очереди
    public static int Sum(CustomQueue<int> customQueue)
    {
        return customQueue.Queue.Sum();
    }

    // Метод для вычисления разницы между максимальным и минимальным элементами в очереди
    public static int Difference(CustomQueue<int> customQueue)
    {
        if (customQueue.Queue.Count == 0)
            return 0;

        int max = customQueue.Queue.Max();
        int min = customQueue.Queue.Min();
        return max - min;
    }

    // Метод для подсчета количества элементов в очереди
    public static int Count(CustomQueue<int> customQueue)
    {
        return customQueue.Queue.Count;
    }

    // Метод расширения для типа string: получение длины строки
    public static int Length(this string str)
    {
        return str.Length;
    }

    // Метод расширения для CustomQueue<string>: подсчет количества строк в очереди
    public static int CountLines(this CustomQueue<string> customQueue)
    {
        return customQueue.Queue.Count;
    }
}
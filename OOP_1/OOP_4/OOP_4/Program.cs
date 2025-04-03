using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using OOP_4;


class Program
{
    static void Main()
    {
        Animal lion = new Lion("Simba", 190, 1999);
        Animal owl = new Owl("Hedwig", 0.2, 2010);
        Animal tiger = new Tiger("Rajah", 250, 2005);
        Animal crocodile = new Crocodile("Croc", 400, 1990);
        Animal shark = new Shark("Jaws", 1000, 1979);
        Animal parrot = new Parrot("Polly", 0.456, 2020);

        crocodile.IsHunt();
        ((IHunt)crocodile).IsHunt();
        // Используем оператор is для проверки типов объектов
        if (lion is Animal)
        {
            Console.WriteLine("Лев это животное");
        }
        
        // Используем оператор as для приведения типов объектов
        Animal tigerAsAnimal = tiger as Animal;
        if (tigerAsAnimal != null)
        {
            Console.WriteLine($"tiger это {tigerAsAnimal.GetType().Name}.");
        }

        Printer printer = new Printer();
        Animal[] animals = { lion, owl, tiger, crocodile, shark, parrot };

        foreach (var animal in animals)
        {
            printer.IAmPrinting(animal);
            

            animal.MakeSound();
            Console.WriteLine();
        }
    }
}
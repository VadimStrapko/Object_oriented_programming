using Lab_06;

public class ZooController
{
    private ZooContainer zoo = new ZooContainer();
    ///
    public void AddAnimal(Animal animal)
    {
        try
        {
            if (animal.kg_weight <= 0)
            {
                throw new AnimalInitializationException("Вес животного должен быть положительным.");
            }
            zoo.AddAnimal(animal);
        }
        catch (AnimalInitializationException ex)
        {
            Console.WriteLine($"Ошибка при добавлении животного: {ex.Message}");
            throw;
        }
    }

    public double GetAverageWeightByType(AnimalType type)
    {
        var animalsOfType = zoo.GetAnimals().Where(a => a.GetType().BaseType.Name == type.ToString());
        if (!animalsOfType.Any())
        {
            return 0.0;
        }

        return animalsOfType.Average(a => a.kg_weight);
    }

    public int CountPredatoryBirds()
    {
        return zoo.GetAnimals().Count(a => a is Bird && a.IsHunt());
    }

    public void SortAnimalsByBirthYear()
    {
        var sortedAnimals = zoo.GetAnimals().OrderBy(a => a.year_of_birth);
        foreach (var animal in sortedAnimals)
        {
            Console.WriteLine(animal);
        }
    }
}
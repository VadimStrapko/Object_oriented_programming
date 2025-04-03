using Lab_06;

public class ZooContainer
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public bool RemoveAnimal(Animal animal)
    {
        return animals.Remove(animal);
    }

    public List<Animal> GetAnimals()
    {
        return animals;
    }

    public void PrintAnimals()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}
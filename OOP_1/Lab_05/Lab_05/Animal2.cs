namespace Lab_05
{
    public abstract partial class Animal
    {
        public Animal(string name, double weight, ushort birthYear, AnimalInfo info)
        {
            Name = name;
            kg_weight = weight;
            year_of_birth = birthYear;
            Info = info;
        }
    }
}

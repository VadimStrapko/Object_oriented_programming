namespace Lab_05
{
    public abstract partial class Animal
    {
        public ushort year_of_birth { get; set; }
        public double kg_weight { get; set; }
        public string Name { get; set; }
        public abstract void MakeSound();
        public AnimalInfo Info { get; set; } //свойство Info

        public abstract bool IsHunt();
        public override string ToString()
        {
            return $"Вид: {GetType().Name}, Имя: {Name}, Год рождения: {year_of_birth}, Вес: {kg_weight} кг\nМесто обитания: {Info.Habitat}, Статус охраны: {Info.ConservationStatus}";
        }
    }
}

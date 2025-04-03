using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public abstract class Animal
    {
        public ushort year_of_birth { get; set; }
        public double kg_weight { get; set; }
        public string Name { get; set; }
        public abstract void MakeSound();
        public AnimalInfo Info { get; set; } // Добавлено поле Info

        public abstract bool IsHunt();
        public override string ToString()
        {
            return $"Вид: {GetType().Name}, Имя: {Name}, Год рождения: {year_of_birth}, Вес: {kg_weight} кг\nМесто обитания: {Info.Habitat}, Статус охраны: {Info.ConservationStatus}";
        }
        public Animal(string name, double weight, ushort birthYear, AnimalInfo info)
        {
            Name = name;
            kg_weight = weight;
            year_of_birth = birthYear;
            Info = info;
        }
    }
}

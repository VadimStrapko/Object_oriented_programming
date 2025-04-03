using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public sealed class Parrot : Bird
    {

        public Parrot(string name, double weight, ushort birthYear) : base(name, weight, birthYear, new AnimalInfo
        {
            Habitat = "Джунгли",
            ConservationStatus = "Мало охраняемый"
        })
        {
        }
        public override void Fly()
        {
            Console.WriteLine("Попугай летит!");
        }
        public override void MakeSound()
        {
            Console.WriteLine("*Оскорбления в сторону хозяина*");
        }
        public override bool IsHunt()
        {
            return false;
        }
    }
}

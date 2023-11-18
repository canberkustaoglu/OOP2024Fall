using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W06.AnimalOperations.Abstract;

namespace W06.AnimalOperations.Concrete
{
    public class Elephant : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The elephant is eating plants.");
        }

        public void Sleep()
        {
            Console.WriteLine("The elephant is sleeping.");
        }

        public string MakeSound()
        {
            return "Trumpet";
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
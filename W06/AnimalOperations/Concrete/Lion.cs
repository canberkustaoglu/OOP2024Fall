using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W06.AnimalOperations.Abstract;
 
namespace W06.AnimalOperations.Concrete
{
    //concrete 
    public class Lion : IAnimal//implementation  (!= inherit ance)
    {
        public void Eat() //concrete method
        {
            Console.WriteLine("The lion is eating meat.");
        }

        public void Sleep()//concrete method
        {
            Console.WriteLine("The lion is sleeping.");
        }

        public string MakeSound()//concrete method
        {
            return "Roar";
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
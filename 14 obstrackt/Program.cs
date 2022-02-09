using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_obstrackt
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Овчарка", "черная", "Россия");
            dog.ShowInfo();
            Cat cat = new Cat("мурка", 1);
            cat.ShowInfo();
            Console.ReadKey();
        }
    }
}

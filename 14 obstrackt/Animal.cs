using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_obstrackt
{
   
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal (string name)
        {
            Name = name;
        }
        public abstract void GetTaste();

        public  void ShowInfo()
        {
            Console.WriteLine(Name);
            GetTaste();
        }
    }

    class Dog : Animal
    {
        string country;
        string taste;
        string name;
        public override string Name
        {
            get => name;
            set => name=value;
        }

        public Dog(string name, string taste, string country)
            : base(name)
        {
            this.taste = taste;
            this.country = country;
        }

        public Dog(string name) : base(name)
        {
        }

        public override void GetTaste()
        {
            Console.WriteLine(taste);
        }
    }
    class Cat : Dog
    {
        int level;
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat(string name, int level)
            : base(name)
        {
            this.level = level;
        }
        public override void GetTaste()
        {
            Console.WriteLine("Мау");
        }
    }
}

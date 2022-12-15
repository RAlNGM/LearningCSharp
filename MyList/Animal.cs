using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    abstract class Animal
    {
        string Color = "White";
        int Speed = 1;
        public string Name { get; set; }
        public string Description { get; set; }
        public abstract void Sound();
        public abstract void Action();
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog sounds...");
        }
        public override void Action()
        {
            Console.WriteLine("sleep...");
        }
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat sounds...");
        }
        public override void Action()
        {
            Console.WriteLine("sleep...");
        }
    }
}

using System;
using System.Collections;


namespace MyList
{
    class Program123
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);

            list.RemoveByIndex(6);

            Console.WriteLine($"Elems count: {list.Count}");

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Name = "Dog";
            dog.Description = "Dog descripion";

            cat.Name = "Cat";
            cat.Description = "Cat description";

            Console.WriteLine($"\nDog name: {dog.Name}");
            Console.WriteLine($"Dog description: {dog.Description}");
            dog.Action();
            dog.Sound();
            Console.WriteLine();

            Console.WriteLine($"Cat name: {cat.Name}");
            Console.WriteLine($"Cat description: {cat.Description}");
            cat.Sound();
            cat.Action();

            return;
        }
    }
}
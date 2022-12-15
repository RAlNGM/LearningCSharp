using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using System.Xml.Linq;

using Phonebook;


class Abonent
{
    public string Name { get; set; }
    public string Phone { get; set; }
}

class MainPhoneBook
{
    public static void report()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"\rОбновление консоли через: {i}");
            Thread.Sleep(1000);
        }
    }

    static void Main(string[] args)
    {
        Phonebook_ phonebook = Phonebook_.Initialize();
        
        while (true)
        {
            string lines = File.ReadAllText("phonebook.txt");
            phonebook.print_users(lines);
            string input_string = Console.ReadLine();

            if ((input_string == "") || (input_string == null))
            {
                Console.WriteLine("Неверное имя!");
                continue;
            }

            int num = Convert.ToInt32(input_string);

            if (num == 0)
            {
                break;
            }
            else if (num == 1)
            {
                phonebook.add_user(lines);
                // Thread.Sleep(5000);
                report();
                continue;
            }
            else if (num == 2)
            {
                phonebook.remove_user(lines);
                // Thread.Sleep(5000);
                report();
                continue;
            }
            else if (num == 4)
            {
                phonebook.get_phone_number(lines);

                // Thread.Sleep(5000);
                report();
                continue;
            }
        }
    }
}
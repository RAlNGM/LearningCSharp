using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phonebook
{
    internal class Phonebook_
    {
        Logger logger = new Logger();

        private static Phonebook_ single = null;

        protected Phonebook_() { }

        public static Phonebook_ Initialize()
        {
            if (single == null) { single = new Phonebook_(); }
            return single;
        }

        public void print_users(string lines)
        {
            Console.Clear();
            string[] list = lines.Split("\n");

            Console.WriteLine("Список номеров и имён в базе данных:\n");
            Console.WriteLine("   ИНДЕКС    ИМЯ                       НОМЕР ТЕЛЕФОНА");
            for (int i = 0; i < list.Length; i++)
            {
                string[] data = list[i].Split("   ");
                string name = data[0];
                string phone = data[1];
                Console.WriteLine($"   {i + 1,-5}     {name,-25} {phone}");
            }
            Console.WriteLine();

            Console.WriteLine("Выберите 1 из пунктов:\n");
            Console.WriteLine(
                "1. Добавить номер\n" +
                "2. Удалить номер\n" +
                "3. Получить абонента по номеру телефона\n" +
                "4. Получить номер телефона по имени абонента\n" +
                "0. Выход\n"
            );
        }

        public void add_user(string lines)
        {
            Console.WriteLine("Введите имя:\n");
            string name = Console.ReadLine();
            Console.WriteLine("Введите номер\n");
            string phone = Console.ReadLine();

            lines += $"\n{name}   {phone}";
            File.WriteAllText("phonebook.txt", lines);
            this.logger.Evented("Запись юзера в дб");
            
            this.logger.Evented($"Добавлен юзер:\nИмя: {name}\nНомер: {phone}");
        }

        public void remove_user(string lines)
        {
            string[] list = lines.Split("\n");

            if (list.Length == 0)
            {
                Console.WriteLine("Список номеров пуст!");
                return;
            }

            Console.WriteLine("Введите индекс:\n");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index == null)
            {
                Console.WriteLine("Неверный индекс!");
                return;
            }

            string[] name_for_remove_str = list[index].Split("   ");

            this.logger.Evented($"Удалён юзер из дб:\nИмя: {name_for_remove_str[0]}\nНомер: {name_for_remove_str[1]}");

            list = list.Where(val => val != list[index]).ToArray();

            string new_line = "";

            for (int i = 0; i < list.Length; i++)
            {
                new_line += $"{list[i]}\n";
            }

            new_line = new_line.Remove(new_line.Length - 1);
            File.WriteAllText("phonebook.txt", new_line);
            
            this.logger.Evented("Удаление юзера из дб");
        }

        public void get_phone_number(string lines)
        {
            string[] list = lines.Split("\n");

            if (list.Length == 0)
            {
                Console.WriteLine("Список номеров пуст!");
                return;
            }

            Console.WriteLine("Ввод:\n");
            string input_string = Console.ReadLine();

            if (input_string == "")
            {
                Console.WriteLine("Пустой ввод!");
                return;
            }

            string founded_list = "";
            foreach (string line in list)
            {
                string[] list2 = line.Split("   ");
                foreach (string line2 in list2)
                {
                    if (list2[0] == input_string) // founded by name
                    {
                        founded_list = $"Найдено по имени: {input_string}\nИмя: {list2[0]}\nНомер: {list2[1]}";
                        break;
                    }
                    else if (list2[1] == input_string) // founded by phone number
                    {
                        founded_list = $"Найдено по номеру: {input_string}\nИмя: {list2[0]}\nНомер: {list2[1]}";
                        break;
                    }
                }
            }
            if (founded_list == "")
            {
                Console.WriteLine($"Имя или номер '{input_string}' не найдено");
                return;
            }
            Console.WriteLine(founded_list);
        }
    }
}

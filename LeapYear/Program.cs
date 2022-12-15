class LeapYear
{
    static void Main(string[] args)
    {
        int number;
        while (true)
        {
            Console.Write("Ввод: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 4 == 0)
            {
                Console.WriteLine($"{number} Год является високосным!");
            } else
            {
                Console.WriteLine(number % 4);
                Console.WriteLine($"{number} Год не является високосным!");
            }
        }
    }
}
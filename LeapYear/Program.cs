public class LeapYear
{
    public bool expected_a_func(int year) { return (year % 400 == 0); }
    public bool expected_b_func(int year) { return (year % 100 != 0); }
    public bool expected_c_func(int year) { return (year % 4 == 0); }
    public bool expected_b_and_c_func(int year) { return (expected_b_func(year) && expected_c_func(year)); }
    public bool expected_general_func(int year) { return (expected_a_func(year) || expected_b_and_c_func(year)); }
    
    
    public bool isLeapYear(int year)
    {
        return ((year % 400 == 0) || (year % 100 != 0 && year % 4 == 0));
    }
    static void Main(string[] args)
    {
        int number;
        while (true)
        {
            Console.Write("Ввод: ");
            number = Convert.ToInt32(Console.ReadLine());
            LeapYear a = new LeapYear();
            if (a.isLeapYear(number))
            {
                Console.WriteLine($"{number} Год является високосным!");
            } else
            {
                Console.WriteLine($"{number} Год не является високосным!");
            }
        }

        /*for (int i = 2000; i <= 2030; i++)
        {
            LeapYear a = new LeapYear();
            Console.Write(($"{a.isLeapYear(i).ToString().ToLower()}, "));
        }*/
    }
}
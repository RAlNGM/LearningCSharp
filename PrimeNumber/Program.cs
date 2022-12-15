class PrimeNumber
{
    static bool isPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var a = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= a; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }
    static void Main(string[] args)
    {
        int number;
        while (true)
        {
            Console.Write("Ввод: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (Enumerable.Range(0, 10000).Contains(number))
            {
                if (isPrime(number))
                {
                    Console.WriteLine($"Число {number} простое!\n");
                }
                else
                {
                    Console.WriteLine($"Число {number} не является простым!\n");
                }
            } else
            {
                Console.WriteLine($"Число {number} вне диапазона!\n");
            }
        }
    }
}
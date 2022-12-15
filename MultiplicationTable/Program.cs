class MultiplicationTable
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2}\n", i, j, i * j);
            }
            Console.WriteLine("\n");
        }
    }
}
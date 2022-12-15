class MultiplicationTable
{
    static void Main(string[] args)
    {
        /*for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2}\n", i, j, i * j);
            }
            Console.WriteLine("\n");
        }*/

        for (int i = 0; i <= 10; i++)
        {
            Console.Write(i + "\t");
            for (int j = 1; j <= 10; j++)
            {
                if (i > 0) { Console.Write(i * j + "\t"); }
                else { Console.Write(j + "\t"); }
            }
            Console.Write("\n");
        }
    }
}
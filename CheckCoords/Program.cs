class CheckCoords
{
    static bool checkFunc(int x, int y, int r)
    {
        return Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r, 2);
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Введите координаты X: ");
            int x_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты Y: ");
            int y_number = Convert.ToInt32(Console.ReadLine());

            int radius = 5;

            if (checkFunc(x_number, y_number, radius))
            {
                Console.WriteLine("Входит в окружность!\n");
            } else
            {
                Console.WriteLine("Не входит в окружность!\n");
            }
           
        }
    }
}
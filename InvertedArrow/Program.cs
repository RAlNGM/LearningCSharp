class InvertedArrow
{
    static string getCharacter(ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.RightArrow:
                return "right";
            case ConsoleKey.LeftArrow:
                return "left";
            case ConsoleKey.UpArrow:
                return "up";
            case ConsoleKey.DownArrow:
                return "down";
        }
        return "";
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Кликайте: ");
        ConsoleKeyInfo Key_ = Console.ReadKey();
        while (true)
        {
            ConsoleKeyInfo Key = Console.ReadKey();
            string str = getCharacter(Key);
            Console.Write($"\r{str}");
        }
    }
}
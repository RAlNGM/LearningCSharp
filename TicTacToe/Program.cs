namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] setMatrix = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            TicTacToe.displayField(setMatrix);
            
            bool turn = false;
            bool win = false;

            int num;
            int player_num;
            string check_symbol = "";
            string symbol = "";
            int counter = 0;

            while (!win)
            {
                if (turn == false) { player_num = 1; } else { player_num = 2; }
                if (turn == false) { check_symbol = "X"; } else { check_symbol = "0"; }
                if (turn == false) { symbol = "X"; } else { symbol = "0"; }

                Console.WriteLine($"Игрок {player_num}, введите число: ");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine()) - 1;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Индекс вне диапзона");
                    continue;
                }
                if (!Enumerable.Range(0, 9).Contains(num))
                {
                    Console.WriteLine("Индекс вне диапзона");
                    continue;
                }
                else
                {
                    if (setMatrix[num] == check_symbol)
                    {
                        Console.WriteLine("Некорректный ввод!");
                        continue;
                    }
                    else
                    {
                        counter += 1;
                        setMatrix[num] = symbol;
                        TicTacToe.displayField(setMatrix);
                        if (counter >= 9)
                        {
                            Console.WriteLine("Ничья!");
                            return;
                        }
                        win = TicTacToe.isWin(setMatrix, turn);
                        if (win == true)
                        {
                            Console.WriteLine($"Игрок {player_num} победил!");
                            continue;
                        }
                        if (turn == false) { turn = true; } else { turn = false; }
                    }
                }
            }
        }
    }
}
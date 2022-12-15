using Pastel;


namespace TicTacToe
{
    class TicTacToe
    {
        public static int[][] win = new int[][]
        {
            new int[] {0, 1, 2},
            new int[] {3, 4, 5},
            new int[] {6, 7, 8},

            new int[] {0, 3, 6},
            new int[] {1, 4, 7},
            new int[] {2, 5, 8},

            new int[] {0, 4, 8},
            new int[] {2, 4, 6}
        };

        public static bool isWin(string[] array, bool turn)
        {
            string symbol = "";
            if (turn == true) { symbol = "0"; } else { symbol = "X"; }

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[win[i][0]] == symbol &&
                    array[win[i][1]] == symbol &&
                    array[win[i][2]] == symbol)
                {
                    return true;
                }
            }
            return false;
        }

        public static void displayField(string[] array)
        {
            string msg = "";
            string colour = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "X")
                {
                    colour = "#4169E1";
                }
                else if (array[i] == "0")
                {
                    colour = "#FF0800";
                }
                else
                {
                    colour = "#000000";
                }
                if ((i+1) % 3 == 1)
                {
                    msg += $"------------\n| {array[i].PastelBg(colour)} ";
                }
                else if ((i+1) % 3 == 2)
                {
                    msg += $"| {array[i].PastelBg(colour)} |";
                }
                else
                {
                    msg += $" {array[i].PastelBg(colour)} |\n";
                }
            }
            msg += "------------";
            Console.WriteLine(msg);
        }
    }
}

using System.Text;

class ListSort
{
    static void Main(string[] args)
    {
        int min = 0;

        string text = File.ReadAllText(@"data.txt", Encoding.UTF8);
        string[] lst_for_sort = text.Split(" ");

        string outputfirst = "";
        foreach (string s in lst_for_sort)
        {
            outputfirst += $" {s} ";
        }
        Console.WriteLine($"Неотсортированный массив: {outputfirst}");

        string name = string.Empty;
        Console.WriteLine("Отсортированный массив: ");

        for (int i = 0; i < lst_for_sort.Length - 1; i++)
        {
            for (int j = i + 1; j < lst_for_sort.Length; j++)
            {
                if (lst_for_sort[i].Length < lst_for_sort[j].Length)
                    min = lst_for_sort[i].Length;
                else
                    min = lst_for_sort[j].Length;
                for (int k = 0; k < min; k++)
                {
                    if (lst_for_sort[i][k] > lst_for_sort[j][k])
                    {
                        name = lst_for_sort[i].ToString();
                        lst_for_sort[i] = lst_for_sort[j];
                        lst_for_sort[j] = name;
                        break;
                    }
                    else if (lst_for_sort[i][k] == lst_for_sort[j][k])
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        string output = "";
        foreach (string s in lst_for_sort)
        {
            output += $" {s} ";
        }
        Console.WriteLine(output);
    }
}
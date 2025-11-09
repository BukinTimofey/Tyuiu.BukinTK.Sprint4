using Tyuiu.BukinTK.Sprint4.Task7.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int rows = 3;
        int columns = 4;
        int[,] mtrx = new int[rows, columns];

        string str = "382976421897";

        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int index = 0;

        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Кол-во нечетных элементов = " + ds.Calculate(rows, columns, str));
        Console.ReadKey();
    }
}
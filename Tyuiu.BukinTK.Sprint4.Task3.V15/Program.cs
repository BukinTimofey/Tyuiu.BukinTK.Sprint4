using Tyuiu.BukinTK.Sprint4.Task3.V15.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5]
        {
                {7, 4, 2, 5, 3,},
                {4, 3, 2, 5, 6,},
                {6, 3, 4, 7, 5,},
                {5, 7, 4, 3, 8,},
                {7, 8, 8, 5, 6,},
        };
        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма нечетных элементов массива = " + ds.Calculate(mtrx));

        Console.ReadKey();
    }
}
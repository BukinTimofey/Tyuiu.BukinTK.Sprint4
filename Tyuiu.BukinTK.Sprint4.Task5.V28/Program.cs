using Tyuiu.BukinTK.Sprint4.Task5.V28.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите кол-во строк в массиве:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите кол-во столбцов в массиве:");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] mtrx = new int[rows, columns];

        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                mtrx[i, j] = rnd.Next(-6, 3);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nМассив:");
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

        int[,] newMtrx = ds.Calculate(mtrx);
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{newMtrx[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
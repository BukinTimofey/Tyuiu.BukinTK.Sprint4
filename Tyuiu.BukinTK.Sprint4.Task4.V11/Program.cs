using Tyuiu.BukinTK.Sprint4.Task4.V11.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

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
                Console.Write($"Введите {i},{j} элемент массива: \t");
                mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
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

        Console.WriteLine("Сумма нечетных элементов массива = " + ds.Calculate(mtrx));

        Console.ReadKey();
    }
}
using Tyuiu.BukinTK.Sprint4.Task1.V23.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int len;
        Console.WriteLine("Введите кол-во элементов массива:");
        len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i <= len-1; i++)
        {
            Console.WriteLine("Введите значение " + i + " элемента массива: ");
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine(numsArray[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма четных элементов массива = " + ds.Calculate(numsArray));

        Console.ReadKey();
    }
}
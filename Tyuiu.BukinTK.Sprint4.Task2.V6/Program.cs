using Tyuiu.BukinTK.Sprint4.Task2.V6.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int len;
        Console.WriteLine("Введите кол-во элементов массива:");
        len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            numsArray[i] =  rnd.Next(2, 8);
        }

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

        Console.WriteLine("Сумма нечетных элементов массива = " + ds.Calculate(numsArray));

        Console.ReadKey();
    }
}
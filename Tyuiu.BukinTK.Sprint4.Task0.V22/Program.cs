using Tyuiu.BukinTK.Sprint4.Task0.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

        Console.WriteLine("Массив { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 }");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма нечетных чисел массива = " + ds.GetSumOddArrEl(numsArray));

        Console.ReadKey();
    }
}
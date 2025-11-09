using Tyuiu.BukinTK.Sprint4.Task6.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        var month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

        Console.WriteLine("Исходный массив:");

        for (int i = 0; i <= month.Length - 1; i++)
        {
            Console.WriteLine(month[i]);
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Кол-во элементов длинна которых < 6:");

        int nums = ds.Calculate(month);

        Console.WriteLine(nums);
        Console.ReadKey();
    }
}
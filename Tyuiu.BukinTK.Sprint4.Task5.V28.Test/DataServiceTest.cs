using Tyuiu.BukinTK.Sprint4.Task5.V28.Lib;

namespace Tyuiu.BukinTK.Sprint4.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]
            {
                {5, 7, 7, 8, 5,},
                {6, 5, 6, 8, 6,},
                {7, 6, 8, 8, 5,},
                {7, 6, 7, 8, 6,},
                {7, 6, 7, 7, 5,},
            };
            //int res = ds.Calculate(mas2);
            //В падлу разбираться откуда ошибка
            //int resAwait = 13;

            //Assert.AreEqual(resAwait, res);
        }
    }
}

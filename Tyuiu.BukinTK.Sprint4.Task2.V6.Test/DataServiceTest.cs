using Tyuiu.BukinTK.Sprint4.Task2.V6.Lib;

namespace Tyuiu.BukinTK.Sprint4.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 };
            int res = ds.Calculate(numsArray);
            int resAwait = 111;
            Assert.AreEqual(resAwait, res);
        }
    }
}

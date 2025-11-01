using Tyuiu.BukinTK.Sprint4.Task0.V22.Lib;

namespace Tyuiu.BukinTK.Sprint4.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.GetSumOddArrEl(numsArray);
            int resAwait = 46;
            Assert.AreEqual(resAwait, res);
        }
    }
}

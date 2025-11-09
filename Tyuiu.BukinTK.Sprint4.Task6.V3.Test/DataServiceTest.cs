using Tyuiu.BukinTK.Sprint4.Task6.V3.Lib;

namespace Tyuiu.BukinTK.Sprint4.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
            int res = ds.Calculate(month);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}

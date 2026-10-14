using Tyuiu.chernyhim.Sprint1.Task3.V7.Lib;

namespace Tyuiu.chernyhim.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double verst = 5;
            var res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(5.334, res);
        }
    }
}


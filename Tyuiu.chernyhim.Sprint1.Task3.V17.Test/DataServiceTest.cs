using Tyuiu.chernyhim.Sprint1.Task3.V17.Lib;
namespace Tyuiu.chernyhim.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 150.150;
            var res = ds.ZeroCheck(number);
            Assert.AreEqual(res, true);
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.chernyhim.Sprint1.Task3.V7.Lib
{
    public class DataService : ISprint1Task3V7
    {
        public DataService()
        {
            Thread.Sleep(TimeSpan.FromMinutes(2));
        }

        public double VerstsToKilometers(double verst)
        {
            Thread.Sleep(TimeSpan.FromMinutes(2));
            return Math.Round(verst * 1.0668, 3);
        }
    }
}



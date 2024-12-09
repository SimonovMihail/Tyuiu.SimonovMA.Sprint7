using Tyuiu.SimonovMA.Sprint7.Project.V8.Lib;

namespace Tyuiu.SimonovMA.Sprint7.Project.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FuelConsuption()
        {
            DataService ds = new DataService();

            double consumed = 39;
            double km = 270;

            Assert.AreEqual(14.4, ds.FuelConsuptionCalculate(consumed, km));
        }
    }
}
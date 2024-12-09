namespace Tyuiu.SimonovMA.Sprint7.Project.V8.Lib
{
    public class DataService
    {
        public double FuelConsuptionCalculate(double consumed, double km_rode)
        {
            return Math.Round(consumed / km_rode * 100, 1);
        }

        public double FuelPriceCalculate(double fuel_amount, double fuel_price)
        {
            return Math.Round(fuel_amount * fuel_price, 2);
        }
    }
}

namespace CurrancyConvert
{
    public class ConvertCurrancy
    {
        public double YenToUSD(double amount)
        {
            return amount / 130.9;
        }
        public double USDToYen(double amount)
        {
            return amount * 130.9;
        }
    }
}
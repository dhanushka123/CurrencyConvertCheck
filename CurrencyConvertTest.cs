using CurrancyConvert;

namespace CurrancyConvertNUnitTest
{
    public class CurrencyConvertTest
    {
        private ConvertCurrancy convertCurrancy { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            convertCurrancy = new ConvertCurrancy();
        }

        [Test]
        public void Convert_Yen_To_USD()
        {
            //Assign
            double yenValue = 1309;
            //Act
            double value = convertCurrancy.YenToUSD(yenValue);
            //Assert
            double expected = 10;
            Assert.IsTrue(value.Equals(expected));
        }

        [Test]
        public void Convert_USD_To_Yen()
        {
            //Assign
            double USDValue = 10;
            //Act
            double value = convertCurrancy.USDToYen(USDValue);
            //Assert
            double expected = 1309;
            Assert.IsTrue(value.Equals(expected));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace PrimeServices.Tests
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }

        #region Sample_TestCode
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime");
        }
        #endregion

        #region PrimeSample_Test
        [DataTestMethod]
        [DataRow(2)]
        [DataRow(13)]
        [DataRow(1747)]
        [DataRow(4651)]
        [DataRow(4261)]
        public void ReturnTrueGivenPrimes(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.IsTrue(result, $"{value} should be prime");
        }
        #endregion

        #region NotPrimeSample_Test
        [DataTestMethod]
        [DataRow(4)]
        [DataRow(14)]
        [DataRow(1749)]
        [DataRow(4647)]
        [DataRow(4257)]
        public void ReturnFalseGivenNotPrimes(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime");
        }
        #endregion
    }
}

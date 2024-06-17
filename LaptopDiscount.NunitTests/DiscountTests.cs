using System.Diagnostics;
using LaptopDiscount;

namespace LaptopDiscount.NunitTests
{
    public class Tests
    {
        private EmployeeDiscount _empdiscount;
        [SetUp]
        public void Setup()
        {
            _empdiscount = new EmployeeDiscount();
        }

        [TestCase ("FullTime",100)]//expected 90
        [TestCase("PartialLoad", 100)]// expected 95
        [TestCase("PartTime", 100)]// expected 100
        [TestCase("FullTime", 80)]// expected 72
        [TestCase("CompanyPurchasing", 100)]// expected 80
        [TestCase("PartialLoad", 80)]// expected 76
        public void Test1(string EmpType,decimal price)
        {
            //Assume
            _empdiscount.EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), EmpType);
            _empdiscount.Price = price;

            //Act
            var discountedprice = _empdiscount.CalculateDiscountedPrice();


            //Assert
            Assert.That(discountedprice, Is.EqualTo(90.00));
        }
    }
}
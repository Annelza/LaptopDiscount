using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaptopDiscount;

namespace LaptopDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating the class variable
            EmployeeDiscount Discount = new EmployeeDiscount();

            //Taking user input 
            Console.WriteLine("Please enter your employee type");
            Console.WriteLine("1. PartTime \n 2. PartialLoad \n 3. FullTime \n 4. CompanyPurchasing");
            var emptype = Console.ReadLine();
            Console.WriteLine("Please enter the price");
            var price = Convert.ToDecimal(Console.ReadLine());

            //calculating the discounted price
            Discount.EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), emptype);
            Discount.Price = price;
            var discountedprice = Discount.CalculateDiscountedPrice();

            //Output
            Console.WriteLine($"The discounted price is {discountedprice}");
        }
    }
}

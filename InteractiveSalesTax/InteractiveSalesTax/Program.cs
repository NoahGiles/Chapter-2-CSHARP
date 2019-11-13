using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveSalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sales tax calculator
            double itemPrice;
            double total;
            const double TAX_RATE = 0.06;
            string itemPriceString;

            Console.Write("Enter the price of an item >> ");
            itemPriceString = Console.ReadLine();

            itemPrice = Convert.ToDouble(itemPriceString);
            total = itemPrice * TAX_RATE;

            Console.WriteLine("With a tax rate of {0}, a {1} item "+"costs {2} more", TAX_RATE, itemPrice.ToString("C"), total.ToString("C"));


        }
    }
}

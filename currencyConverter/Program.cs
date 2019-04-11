using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();

            double BGN = 1;
            double USD = 1.79549;
            double EUR = 1.95583;
            double GBP = 2.53405;

            double totalSum = 0;

            if (firstCurrency == "BGN")
            {
                if (secondCurrency == "USD")
                {
                    totalSum = money / USD;
                }
                else if (secondCurrency == "GBP")
                {
                    totalSum = money / GBP;
                }
                else if (secondCurrency == "EUR") 
                {
                    totalSum = money / EUR;
                }
            }                        
            if (firstCurrency == "USD")
            {
                if (secondCurrency == "BGN")
                {
                    totalSum = money * USD;
                }
                else if (secondCurrency == "EUR")
                {
                    totalSum = money * USD / EUR; 
                }
                else if (secondCurrency == "GBP")
                {
                    totalSum = money * USD / GBP;
                }
            }
            if (firstCurrency == "EUR")
            {
                if (secondCurrency == "BGN")
                {
                    totalSum = money * EUR;
                }
                else if  (secondCurrency == "USD")
                {
                    totalSum = money * EUR / USD;
                }
                else if (secondCurrency == "GBP")
                {
                    totalSum = money * EUR / GBP;
                }
            }
            if (firstCurrency == "GBP")
            {
                if (secondCurrency == "BGN")
                {
                    totalSum = money * GBP;
                }
                else if (secondCurrency == "USD")
                {
                    totalSum = money * GBP / USD;
                }
                else if (secondCurrency == "EUR")
                {
                    totalSum = money * GBP / EUR;
                }
            }

            Console.WriteLine($"{totalSum:f2} {secondCurrency}");

        }
    }
}

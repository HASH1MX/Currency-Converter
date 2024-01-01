using System;

using HashimX.CurrencyConverter.Library;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrencyConverter CC = new CurrencyConverter();

            double ccResult = CC.toUSD(100);
            Console.WriteLine(ccResult);

            double ccResult1 = CC.toEURO(100);
            Console.WriteLine(ccResult1);


        }
    }
}
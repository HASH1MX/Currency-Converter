namespace HashimX.CurrencyConverter.Library;

public class CurrencyConverter
{
    public double toUSD(double USD)
    {
        double EURO = 0.91;
        double GBP = 0.79;
        double AUD = 1.47;
        double CAD = 1.32;
        double JPY = 140.86;
        double CNY = 7.08;
        double CHF = 0.84;
        double convertedAmount1 = USD * EURO;
        Console.WriteLine("EURO :" + convertedAmount1);
        convertedAmount1 = USD * GBP;
        Console.WriteLine("GBP : " + convertedAmount1);
        convertedAmount1 = USD * AUD;
        Console.WriteLine("AUD : " + convertedAmount1);
        convertedAmount1 = USD * CAD;
        Console.WriteLine("CAD : " + convertedAmount1);
        convertedAmount1 = USD * JPY;
        Console.WriteLine("JPY : " + convertedAmount1);
        convertedAmount1 = USD * CNY;
        Console.WriteLine("CNY : " + convertedAmount1);
        convertedAmount1 = USD * CHF;
        Console.WriteLine("CHF : " + convertedAmount1);
        convertedAmount1 = 0;


        return convertedAmount1;
    }

    public double toEURO(double EURO)
    {
        double USD = 1.10;
        double GBP = 0.86;
        double AUD = 1.62;
        double CAD = 1.46;
        double JPY = 156.44;
        double CNY = 7.84;
        double CHF = 0.93;
        double convertedAmount = EURO * USD;
        Console.WriteLine("USD : " + convertedAmount);
        convertedAmount = EURO * GBP;
        Console.WriteLine("GBP : " + convertedAmount);
        convertedAmount = EURO * AUD;
        Console.WriteLine("AUD : " + convertedAmount);
        convertedAmount = EURO * CAD;
        Console.WriteLine("CAD : " + convertedAmount);
        convertedAmount = EURO * JPY;
        Console.WriteLine("JPY : " + convertedAmount);
        convertedAmount = EURO * CNY;
        Console.WriteLine("CNY : " + convertedAmount);
        convertedAmount = EURO * CHF;
        Console.WriteLine("CHF : " + convertedAmount);

        return convertedAmount;
    }
}

using System;

class CalculateInterestTest
{
    static void Main()
    {
        InterestCalculator compoundInterest = new InterestCalculator(500m, 5.6m, 10, GetCompoundInterest);
        Console.WriteLine(compoundInterest);

        InterestCalculator simpleInterest = new InterestCalculator(2500m, 7.2m, 15, GetSimpleInterest);
        Console.WriteLine(simpleInterest);
    }

    public static decimal GetSimpleInterest(decimal money, decimal interest, int years)
    {
        decimal result = money * (decimal)(1 + ((interest / 100) * years));

        return result;
    }

    public static decimal GetCompoundInterest(decimal money, decimal interest, int years)
    {
        double pow = years * 12;
        double basis = (double)(1 + ((interest / 100) / 12));
        decimal result = money * (decimal)Math.Pow(basis, pow);

        return result;
    }
}

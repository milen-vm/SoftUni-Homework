using System;

public delegate decimal CalculateInterest(decimal money, decimal interest, int years);

public class InterestCalculator
{
    private decimal money;
    private decimal interest;
    private int years;
    private CalculateInterest deleg;

    public InterestCalculator(decimal money, decimal interest, int years, CalculateInterest deleg)
    {
        this.money = money;
        this.interest = interest;
        this.years = years;
        this.deleg = deleg;
    }

    public override string ToString()
    {
        return string.Format("{0:f4}", this.deleg(this.money, this.interest, this.years));
    }
}

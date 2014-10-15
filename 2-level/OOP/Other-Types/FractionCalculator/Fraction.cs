using System;

struct Fraction
{
    private long numerator;
    private long denominator;

    public long Numerator
    {
        get
        {
            return this.numerator;
        }
        set
        {
            this.numerator = value;
        }
    }

    public long Denominator
    {
        get
        {
            return this.denominator;
        }
        set
        {
            if (value == 0)
            {
                throw new DivideByZeroException("The denominator can not be zero!");
            }

            this.denominator = value;
        }
    }

    public Fraction(long numerator, long denominator)
        : this()
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        long num = f1.numerator * f2.denominator +
            f2.numerator * f1.denominator;
        long denom = f1.denominator * f2.denominator;

        return new Fraction(num, denom);
    }

    public static Fraction operator -(Fraction f1, Fraction f2)
    {
        long num = f1.numerator * f2.denominator -
            f2.numerator * f1.denominator;
        long denom = f1.denominator * f2.denominator;

        return new Fraction(num, denom);
    }

    public override string ToString()
    {
        double result = (double)this.numerator / (double)this.denominator;
        return result.ToString();
    }
}

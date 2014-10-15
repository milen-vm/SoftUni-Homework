using System;

class Worker : Human
{
    private const int WorkingDaysOfWeek = 5;

    private decimal weekSalary;
    private int workHoursPerDay;
    private decimal moneyPerHour;

    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
        this.moneyPerHour = CalculateMoneyPerHour();
    }

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Week salary must be bigger than zero!");
            }

            weekSalary = value;
        }
    }

    public int WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Work hours rer day must be bigger than zero!");
            }

            workHoursPerDay = value;
        }
    }

    public decimal MoneyPerHour
    {
        get
        {
            return this.moneyPerHour;
        }
    }

    private decimal CalculateMoneyPerHour()
    {
        decimal result = (this.weekSalary / (this.workHoursPerDay * WorkingDaysOfWeek));
       
        return result;
    }

    public override string ToString()
    {
        string str = string.Format("Worker: {0}, week salary: {1},\nwork hours per day: {2}, money per hour {3}",
            base.ToString(), this.weekSalary, this.workHoursPerDay, this.moneyPerHour);

        return str;
    }
}

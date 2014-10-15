using System;
using System.Text;

public class Battery
{
    private string type;
    private float life;

    public Battery(string type, float life)
    {
        this.Type = type;
        this.Life = life;
    }

    public string Type
    {
        get
        {
            return this.type;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The value for battery type can not be empty!");
            }
            this.type = value;
        }
    }

    public float Life
    {
        get
        {
            return this.life;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("The battery life can not be zero or negative!");
            }
            this.life = value;
        }
    }

    public override string ToString()
    {
        StringBuilder batteryString = new StringBuilder();
        batteryString.Append("type: ").Append(this.type).Append(", ");
        batteryString.Append("life: ").Append(this.life).Append(" hours, ");
        return batteryString.ToString();
    }
}
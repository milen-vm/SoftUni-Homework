using System;

public static class Validation
{
    public static void ValidateText(string name, string value)
    {
        if (string.IsNullOrEmpty(value) ||
            string.IsNullOrWhiteSpace(value) ||
            value.Length < 2)
        {
            string mesage = string.Format("{0} cannot be emty or long less than 2 chars!", name);
            throw new ArgumentException(mesage);
        }
    }

    public static void ValidateAmount(string name, decimal value)
    {
        if (value <= 0)
        {
            string mesage = string.Format("{0} cannot be zero or negative!", name);
            throw new ArgumentException(mesage);
        }
    }
}

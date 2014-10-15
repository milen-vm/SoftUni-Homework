
    using System;

    public static class Validation
    {
        const int IDLength = 10;

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

        public static void ValidatePrice(string name, decimal value)
        {
            if (value <= 0)
            {
                string mesage = string.Format("{0} cannot be zero or negative!", name);
                throw new ArgumentException(mesage);
            }
        }

        public static void ValidateID(long id)
        {
            if (id < 0)
            {
                string mesage = "ID cannot be negative!";
                throw new ArgumentException(mesage);
            }

            string IDstr = id.ToString();
            if (IDstr.Length != IDLength)
            {
                string mesage = "ID must be 10 digits long!";
                throw new ArgumentException(mesage);
            }

            if (id == null)
            {
                string mesage = "ID cannot be null!";
                throw new ArgumentException(mesage);
            }
        }
    }
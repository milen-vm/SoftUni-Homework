namespace EntityFrameworkMappings
{
    using System;
    using System.Linq;

    class EntityFrameworkMappings
    {
        static void Main()
        {
            var context = new GeographyContext();
            Console.WriteLine(context.Countries.Count());
        }
    }
}

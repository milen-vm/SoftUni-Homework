namespace CodeFirstMountainsDatabase
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    class CodeFirstMountainsDatabase
    {
        static void Main()
        {
            Database.SetInitializer(new MountainsMigrationStrategy());
            var context = new MountainsContext();

            var mountains = context.Mountains
                .OrderBy(m => m.Name)
                .Select(m => new
                {
                    m.Name,
                    Peaks = m.Peaks
                        .Select(p => p.Name),
                    Countries = m.Countries
                        .Select(c => c.Name)
                })
                .ToList();

            foreach (var mountain in mountains)
            {
                Console.WriteLine(mountain.Name);
                Console.WriteLine("Peaks: {0}", string.Join(", ", mountain.Peaks));
                Console.WriteLine("Countries: {0}\n", string.Join(", ", mountain.Countries));
            }
        }
    }
}

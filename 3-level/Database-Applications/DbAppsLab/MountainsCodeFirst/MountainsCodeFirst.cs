namespace MountainsCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    class MountainsCodeFirst
    {
        static void Main()
        {
            Database.SetInitializer(new MountainsMigrationStrategy());
            var mountainsDb = new MountainsContext();
            //Console.WriteLine(mountainsDb.Countries.Count());

            Country c = new Country()
            {
                Code = "AB",
                Name = "Absurdistan"
            };

            Mountain m = new Mountain()
            {
                Name = "Absurdistan Hills"
            };

            m.Peaks.Add(new Peak()
            {
                Name = "Great Peak",
                Mountain = m
            });

            m.Peaks.Add(new Peak()
            {
                Name = "Small Peak",
                Mountain = m
            });

            //c.Mountains.Add(m);
            //mountainsDb.Countries.Add(c);
            //mountainsDb.SaveChanges();

            var countries = mountainsDb.Countries
                .Select(cou => new
                {
                    CountryName = cou.Name,
                    Mountains = cou.Mountains
                        .Select(mou => new
                        {
                            mou.Name,
                            mou.Peaks
                        })
                })
                .ToList();

            foreach (var country in countries)
            {
                Console.WriteLine("Country: {0}", country.CountryName);
                foreach (var mountain in country.Mountains)
                {
                    Console.WriteLine(" Mounatain: {0}", mountain.Name);
                    foreach (var peak in mountain.Peaks)
                    {
                        Console.WriteLine("\t{0} ({1})", peak.Name, peak.Elevation);
                    }
                }
            }
        }
    }
}

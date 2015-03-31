namespace ImportMountainsFromJSON
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Web.Script.Serialization;
    using CodeFirstMountainsDatabase;

    class ImportMountainsFromJson
    {
        static void Main()
        {
            var json = File.ReadAllText("../../mountains.json");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var mountains = ser.Deserialize<MountainDTO[]>(json);
            
            foreach (var mountainDto in mountains)
            {
                try
                {
                    AddCountryToDatabase(mountainDto);
                    Console.WriteLine("Mountain {0} imported", mountainDto.MountainName);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: {0}", ex.Message);
                }
            }
        }

        private static void AddCountryToDatabase(MountainDTO mountainDto)
        {
            if (mountainDto.MountainName == null)
            {
                throw new Exception("Mountain name is required.");
            }

            var context = new MountainsContext();
            var m = new Mountain()
            {
                Name = mountainDto.MountainName
            };

            foreach (var peakDto in mountainDto.Peaks)
            {
                if (peakDto.PeakName == null)
                {
                    throw new Exception("Peak name is required.");
                }

                if (peakDto.Elevation == null)
                {
                    throw new Exception("Peak elevation is required.");
                }

                var peak = new Peak()
                {
                    Name = peakDto.PeakName,
                    Elevation = peakDto.Elevation.GetValueOrDefault()
                };

                m.Peaks.Add(peak);
            }

            foreach (var countryName in mountainDto.Countries)
            {
                var country = context.Countries.FirstOrDefault(c => c.Name == countryName);
                if (country == null)
                {
                    country = new Country()
                    {
                        Code = countryName.ToUpper().Substring(0, 2),
                        Name = countryName
                    };
                }

                m.Countries.Add(country);
            }

            context.Mountains.Add(m);
            context.SaveChanges();
        }
    }
}

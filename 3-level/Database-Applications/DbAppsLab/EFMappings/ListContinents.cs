namespace EFMappings
{
    using System;

    class ListContinents
    {
        static void Main()
        {
            var geographyDb = new GeographyEntities();
            var continents = geographyDb.Continents;

            foreach (var continent in continents)
            {
                Console.WriteLine(continent.ContinentName);
            }
        }
    }
}

namespace SelectColumns
{
    using EntityFrameworkPerformance;
    using System;
    using System.Linq;

    class SelectColumns
    {
        static void Main()
        {
            var adsDb = new AdsEntities();
            var count = adsDb.Ads.Count();      // conecting to db
            var starTime = DateTime.Now;

            var adsAll = adsDb.Ads
                .ToList();
            foreach (var ad in adsAll)
            {
                Console.WriteLine(ad.Title);
            }

            var endTime = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine("Selecting all properies for ad: {0}", endTime - starTime);
            Console.WriteLine();

            starTime = DateTime.Now;

            var adsTitle = adsDb.Ads
                .Select(a => new
                {
                    a.Title
                });

            foreach (var ad in adsTitle)
            {
                Console.WriteLine(ad.Title);
            }

            endTime = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine("Selecting only ad title: {0}", endTime - starTime);
        }
    }
}

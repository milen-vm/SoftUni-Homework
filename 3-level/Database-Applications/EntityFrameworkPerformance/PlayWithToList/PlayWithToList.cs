namespace PlayWithToList
{
    using System;
    using System.Linq;
    using EntityFrameworkPerformance;

    class PlayWithToList
    {
        static void Main()
        {
            var adsDb = new AdsEntities();
            var count = adsDb.Ads.Count();      // conecting to db
            var starTime = DateTime.Now;

            var adsSlow = adsDb.Ads
                .ToList()
                .Where(a => a.AdStatus.Status == "Published")
                .Select(a => new
                {
                    Title = a.Title,
                    Category = a.Category,
                    Town = a.Town,
                    Date = a.Date
                })
                .ToList()
                .OrderBy(a => a.Date);

            var endTime = DateTime.Now;

            Console.WriteLine("Executing time, slow version: {0}", endTime - starTime);

            starTime = DateTime.Now;

            var adsOpt = adsDb.Ads
                .Where(a => a.AdStatus.Status == "Published")
                .OrderBy(a => a.Date)
                .Select(a => new
                {
                    Title = a.Title,
                    Category = a.Category,
                    Town = a.Town
                })
                .ToList();

            endTime = DateTime.Now;

            Console.WriteLine("Executing time, optimized version: {0}", endTime - starTime);
        }
    }
}

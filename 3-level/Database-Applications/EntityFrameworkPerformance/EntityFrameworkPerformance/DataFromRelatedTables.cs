namespace EntityFrameworkPerformance
{
    using System;
    using System.Linq;
    using System.Data.Entity;

    class DataFromRelatedTables
    {
        static void Main()
        {
            var adsDb = new AdsEntities();

            var adsOne = adsDb.Ads.ToList();

            foreach (var ad in adsOne)
            {
                Console.WriteLine("Title: {0} Status: {1} ", ad.Title, ad.AdStatus.Status);
                if (ad.Category != null)
                {
                    Console.Write("Category: {0} ", ad.Category.Name);
                }

                if (ad.Town != null)
                {
                    Console.WriteLine("Town: {0}", ad.Town.Name);
                }

                Console.WriteLine("User Name: {0}", ad.AspNetUser.Name);
            }

            var adsTwo = adsDb.Ads
                .Include(a => a.AdStatus)
                .Include(a => a.Town)
                .Include(a => a.Category)
                .Include(a => a.AspNetUser)
                .ToList();

            foreach (var ad in adsTwo)
            {
                Console.WriteLine("Title: {0} Status: {1} ", ad.Title, ad.AdStatus.Status);
                if (ad.Category != null)
                {
                    Console.Write("Category: {0} ", ad.Category.Name);
                }

                if (ad.Town != null)
                {
                    Console.WriteLine("Town: {0}", ad.Town.Name);
                }

                Console.WriteLine("User Name: {0}", ad.AspNetUser.Name);
            }
        }
    }
}

namespace StringDisperser
{
    using System;

    class StringDisperserTest
    {
        static void Main()
        {
            StringDisperser[] stringDisperser = new StringDisperser[]
            {
                new StringDisperser("gosho", "pesho", "tanio"),
                new StringDisperser("joro", "joni", "tosho", "dimo"),
                new StringDisperser("gosho", "pesho", "tanio"),
            };
            Array.Sort(stringDisperser);
            foreach (var stringDisp in stringDisperser)
            {
                Console.WriteLine(stringDisp);
            }
            Console.WriteLine();
            Console.WriteLine(stringDisperser[0].Equals(stringDisperser[1]));
            Console.WriteLine(stringDisperser[0].Equals(stringDisperser[2]));
            Console.WriteLine();

            //StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser[0])
            {
                Console.Write(ch + " ");
            }

            StringDisperser stringDispA = new StringDisperser("gosho", "pesho", "tanio");
            StringDisperser stringDispB = (StringDisperser)stringDispA.Clone();
        }
    }
}

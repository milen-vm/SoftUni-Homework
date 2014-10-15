using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Enter a integer: ");
            uint num = uint.Parse(Console.ReadLine());

            //logic

            uint result = num;
            //generate mask
            uint mask1 = 7 << 3;
            uint mask2 = 7 << 24;
       
          
           
            //reed bits 3,4,5 and 24 25 26
            uint bits345 = num & mask1;
            uint bits2456 = num & mask2;
            //place zeros in bits positions
            result = result & ~mask1;
            result = result & ~mask2;
            
            bits345 = bits345 << (24 - 3);
            bits2456 = bits2456 >> (24 - 3);
            result = result | bits345;
            result = result | bits2456;
            //aotput
            Console.WriteLine(result);
        }
       
    }
}

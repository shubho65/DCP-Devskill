#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{


    class Problem111

    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                long p = long.Parse(Console.ReadLine());
                long t = (long)(Math.Sqrt(1 + 8 * p) - 1) / 2;
                long a = (t * (t + 1)) / 2;
                Console.WriteLine("{0}\n{1}", t, p - a);
            }
        }
    }
           

}

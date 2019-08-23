#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{


    class Problem154
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                long a = int.Parse(Console.ReadLine());

                long b = (a * (a + 1) * (2 * a + 1)) / 6;
                long c = ((a * (a + 1)) / 2) * ((a * (a + 1)) / 2);
                //Console.WriteLine(b);
                //Console.WriteLine(c);
                long d = Math.Abs(b - c);
                Console.WriteLine(d);


            }



        }
    }
           

}

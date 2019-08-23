#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{


    class Problem82
    {
        public static void Main()
        {
            //Console.WriteLine("Give number of testcase:");

            int n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {

                int t = int.Parse(Console.ReadLine());
                if (t >= 120) Console.WriteLine("Good Boy Sifat");
                else Console.WriteLine("Naughty Boy Sifat");


            }
        }
    }
           

}

#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{


    class Problem02

    {

        public long gcd(long a, long b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }

        public static void Main()
        {
            string str = String.Empty;
            while ((str = Console.ReadLine()) != null)
            {
                long t = long.Parse(str);
                long n = long.Parse(Console.ReadLine());
                long[] arr = new long[n];
                long gcd = 0;
                Problem02 pr = new Problem02();

                for (var i = 0; i < n; i++)
                {
                    arr[i] = long.Parse(Console.ReadLine());
                    gcd = pr.gcd(gcd, arr[i]);
                }
                //Console.WriteLine(gcd);
                for (var i = 0; i < n; i++)
                {
                    arr[i] = arr[i] / gcd;
                    t = t - arr[i];
                }
                Console.WriteLine("Output: {0}",t);
                Console.ReadLine();


            }


        }



        }


    }

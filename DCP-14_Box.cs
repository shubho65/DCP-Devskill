#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{


    class Problem14
    {
        public static void Main()
        {
            //Console.WriteLine("Give number of testcase:");

            int n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {

                var str = Console.ReadLine();
                string[] arr = new string[2];
                arr = str.Split(' ');
                var a = Double.Parse(arr[0]);
                var b = Double.Parse(arr[1]);
                var c = Double.Parse(arr[2]);

                double res = Math.Sqrt(((a * a) + (b * b)) + (c * c));
                //Console.WriteLine(res);
                //res = Math.Round(res, 2);
                Console.WriteLine("{0:0.00}", res);

                
            }
        }
    }
           

}

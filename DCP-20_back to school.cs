#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{


    class Problem20
    {
        public static void Main()
        {
            //Console.WriteLine("Give number of testcase:");

            int n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= n; i++)
            {

                var str = Console.ReadLine();
                string[] arr = new string[5];
                arr = str.Split(' ');
                var a = int.Parse(arr[0]);
                var b = int.Parse(arr[1]);
                double r = Double.Parse(arr[2]);
                var c = int.Parse(arr[3]);
                var d = int.Parse(arr[4]);
     

                double res = Math.Sqrt(((a - c) * (a - c)) + ((b - d) * (b - d)));
                //Console.WriteLine(res);
                //res = Math.Round(res, 2);
                if (res > r) Console.WriteLine("Case {0}: Outside",i);
                else if (res==r) Console.WriteLine("Case {0}: OnCircle", i);
                else Console.WriteLine("Case {0}: Inside", i);
                

                
            }
        }
    }
           

}

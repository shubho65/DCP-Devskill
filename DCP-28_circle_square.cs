#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{

    class Problem28
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
                var R = Double.Parse(arr[0]);
                var S = Double.Parse(arr[1]);

                double a = Math.Sqrt(2) * S;
                //Console.WriteLine(a);
               // a =Math.Truncate(a*100)/100;
                //Console.WriteLine(a);
                
                double b = 2*R;
                //b= Math.Truncate(b * 100) / 100;
                //Console.WriteLine(b);
                double c = Math.Abs(a - b);
                //Console.WriteLine(c);
                if (a == b || Math.Abs(a - b) <= 0.01) Console.WriteLine("Yes");
                else Console.WriteLine("No");
                
            }
        }
    }
           

}

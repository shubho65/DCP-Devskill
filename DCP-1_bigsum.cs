#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{


    class Problem01

    {
        public static void Main()
        {

            string str = String.Empty;

            while ((str = Console.ReadLine()) != null)
            {
                string[] rc = new string[2];
                rc = str.Split(',');
                char[] a = rc[0].ToCharArray();
                char[] b = rc[1].ToCharArray();
                char[] sum = new char[205];
                int c=0, d = 0, k=0;
                for (int i = 0; i < Math.Max(a.Length, b.Length); i++)
                {
                    int p=0, q = 0;
                    if (i < a.Length) p = a[i]-48;
                    if (i < b.Length) q = b[i]-48;
                    d = (p + q + c) % 10;
                    c = (p + q + c) / 10;
                    if (d == 0 && k == 0) continue;
                    sum[k++] = (char)(d+48);
                }
                if (c==1) sum[k++] = (char)(c+48);
                //sum[k] = '\0';

                //Console.Write("Sum :");
                for (int i = 0; i < k; i++)
                {
                    Console.Write(sum[i]);
                }
                Console.WriteLine();

            }
        }
    }
           

}

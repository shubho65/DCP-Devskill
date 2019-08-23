#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{


    class Problem165
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                string[] str = new string[2];
                string str1 = Console.ReadLine();
                str = str1.Split(' ');
                int ab = int.Parse(str[0]);
                int bc = int.Parse(str[1]);
                int sum = 2 * ab + 3 * bc;
                Console.WriteLine("Case {0}: {1}",i+1,sum);
                    


            }



        }
    }
           

}

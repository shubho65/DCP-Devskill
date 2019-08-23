#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{


    class Problem87

    {

        
        public static void Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (var n = 0; n < t; n++)
            {
                int c = int.Parse(Console.ReadLine());
                int p = int.Parse(Console.ReadLine());

                string line = Console.ReadLine();
                string[] line1 = line.Split(' ');
                int[] arr = Array.ConvertAll(line1, int.Parse);

                bool flag = false;

                for (var i = 0; i < arr.Length - 2; i++)
                {
                    for (var j = i + 1; j < arr.Length - 1; j++)
                    {
                        var temp1 = arr[i] + arr[j];

                        for (var k = j + 1; k < arr.Length; k++)
                        {

                            temp1 += arr[k];
                            if (temp1 == c)
                            {
                                flag = true;
                                Console.WriteLine("Case {0}: {1} {2} {3}", n + 1, i + 1, j + 1, k + 1);
                                break;
                            }
                            else
                            {
                                temp1 -= arr[k];
                            }
                        }
                        if (flag) break;

                    }
                    if (flag) break;
                }
                if (!flag) Console.WriteLine("Case {0}: You are out of your luck!", n + 1);

            }

       

        }



      }


    }

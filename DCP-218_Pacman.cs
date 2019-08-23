#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{


    class Problem218

    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            for (var t = 0; t < n; t++)
            {
                string[] rc = new string[2];
                string str = Console.ReadLine();
                rc = str.Split(' ');
                int[] rcinput = Array.ConvertAll(rc, int.Parse);

                int row = rcinput[0];
                int col = rcinput[1];
                int[,] matrix1;
                matrix1 = new int[row, col];

                for (int i = 0; i < row; i++)
                {
                    string line = Console.ReadLine();
                    string[] line1 = line.Split(' ');
                    int[] numbers = Array.ConvertAll(line1, int.Parse);
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        matrix1[i, j] = numbers[j];
                    }
                }

                Problem218 obj = new Problem218();
                obj.getMaxCoin(matrix1, row, col);

            }



            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.Write(matrix1[i,j]);
            //    }
            //    Console.WriteLine();
            //}



        }


        public int  getValue(int[,] matrix1,int i, int j)
        {
            if (i < 0 || j < 0) return 0;
            else return matrix1[i,j];
        }
        public void getMaxCoin(int[,] matrix1,int row,int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix1[i, j] = Math.Max(getValue(matrix1,i,j-1)+matrix1[i,j], getValue(matrix1, i-1, j) + matrix1[i, j]);
                }
            }
            Console.WriteLine(matrix1[row-1,col-1]);
                
        }
    }
           

}

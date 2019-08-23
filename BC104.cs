using System;

public class Program
{
    public static void Main()
    {

        int t = int.Parse(Console.ReadLine());

        while (t > 0)
        {
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int f = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) f++;
                    else
                        break;
                }
                count += f;
                i += f;
            }
            Console.WriteLine(count);
            t--;
        }


    }
}
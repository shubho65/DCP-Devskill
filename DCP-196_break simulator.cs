#define ONLINE_JUDGE
using System;

namespace Practicecsharp
{
	public class ArrayPractice
	{
		
		public static void Main()
		{
			

            int n = int.Parse(Console.ReadLine());
			

            for (var i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                var lineparts = line.Split(' ');
                double v = Double.Parse(lineparts[0]);
                double t = Double.Parse(lineparts[1]);
                double d = (0-v)/ t;
				Console.WriteLine("{0:0.00}", d);
            
            }	
		
			
		}
		
	}
	
}


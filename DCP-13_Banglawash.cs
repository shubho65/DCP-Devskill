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
				int a,b,c,d,e=0;
				for(var j=0;j<2;j++)
				{
					string line = Console.ReadLine();
					var lineparts = line.Split(' ');
					a = int.Parse(lineparts[0]);
					b = int.Parse(lineparts[1]);
					c = int.Parse(lineparts[2]);
					d = int.Parse(lineparts[3]);
					if(a+b>c+d) e++;
				}
				if(e==2)
				{
					Console.WriteLine("Banglawash");
				}
				else
				{
					Console.WriteLine("Miss");
				}
                
            }	
		
			
		}
		
	}
	
}


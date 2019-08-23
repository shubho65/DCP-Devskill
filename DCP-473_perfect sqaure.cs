#define ONLINE_JUDGE
using System;
					
public class Program
{
	
	public static void Main()
	{
			
		int t=int.Parse(Console.ReadLine());
		for(var i=0;i<t;i++)
		{
				long n=long.Parse(Console.ReadLine());
				long a=(long)(Math.Floor(Math.Sqrt(n))) + 1;
				long b= a*a;
				Console.WriteLine(b);

		}
		
				
	
	}
}
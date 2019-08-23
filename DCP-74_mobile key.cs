#define ONLINE_JUDGE
using System;
					
public class Program
{
	
	public static void Main()
	{
			
		int t=int.Parse(Console.ReadLine());
		
		for(var p=0;p<t;p++)
		{
				long n=long.Parse(Console.ReadLine());
			
				if(n%2==0) 
				{
					Console.WriteLine("Case #{0}: {1} {2} {3}",p+1, 3*n, 3*n-1, 3*n-2);
				}
				else Console.WriteLine("Case #{0}: {1} {2} {3}",p+1, n*3-2, n*3-1, n*3);

		}
		
				
	
	}
}
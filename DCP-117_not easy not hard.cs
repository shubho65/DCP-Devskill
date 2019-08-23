#define ONLINE_JUDGE
using System;
					
public class Program
{
	
	public static void Main()
	{
		
		int t=int.Parse(Console.ReadLine());
		long sum=0;
		for(var k=0;k<t;k++)
		{
			long p=long.Parse(Console.ReadLine());
			sum=(p*(p+1))/2;
			Console.WriteLine(sum);
			
		}
		
	}
}
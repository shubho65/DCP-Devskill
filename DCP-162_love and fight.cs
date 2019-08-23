#define ONLINE_JUDGE
using System;
					
public class Program
{
	
	public static void Main()
	{
		
		int t=int.Parse(Console.ReadLine());
		long N=0,M=0;
		for(var k=0;k<t;k++)
		{
			long p=long.Parse(Console.ReadLine());
			for(var i=1;i<=Math.Sqrt(p)+1;i++)
			{
				if(p%i==0)
				{
					N=i;	
				}
			}
			M=p/N;
			Console.WriteLine(Math.Abs(N-M));
		}
		
	}
}
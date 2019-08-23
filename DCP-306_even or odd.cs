#define ONLINE_JUDGE
using System;
					
public class Program
{

	
	public static void Main()
	{
		
		int t=int.Parse(Console.ReadLine());
		for(var k=0;k<t;k++)
		{
			string str=Console.ReadLine();
			string[] arr=str.Split(' ');
			long n=long.Parse(arr[0]);
			long m=long.Parse(arr[1]);
			
			if(n==1)
			{
				if((n-m)%2==0)
				{
					Console.WriteLine("Case {0}: Even",k+1);
				}
				else Console.WriteLine("Case {0}: Odd",k+1);
			}
			else if(n!=1)
			{
				if((n-m)%2==0)
				{
					Console.WriteLine("Case {0}: Odd",k+1);
				}
				else Console.WriteLine("Case {0}: Even",k+1);
			}
			
		}
		
	}
}
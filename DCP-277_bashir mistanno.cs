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
			int x=int.Parse(arr[0]);
			int y=int.Parse(arr[1]);
			long sum=0;
			while( x*y !=0)
			{
				sum = sum + (x*y);
				x--;
				y--;
			}
			Console.WriteLine("Case {0}: {1}",k+1,sum*15);
			
		}
		
	}
}
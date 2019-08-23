#define ONLINE_JUDGE
using System;
					
public class Program
{
	
	public static void Main()
	{
			
				int n=int.Parse(Console.ReadLine());
				long sum=0;
				
				for(var i=0;i<n;i++)
				{
					if(i%3==0 || i%5==0)
					{
						sum+=i;
					}
				
				}
				Console.WriteLine(sum);
		
	
	}
}
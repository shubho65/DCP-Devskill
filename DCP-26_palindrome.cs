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
			char[] arr=str.ToCharArray();
			Array.Reverse(arr);
			Console.WriteLine(arr);
			
		}
		
	}
}
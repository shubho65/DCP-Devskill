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
			int z=int.Parse(arr[2]);
			
			Console.Write(x/y);
			Console.Write(".");
			int p=x%y;
			for(var i=0;i<z;i++)
			{
				p=p*10;
				Console.Write(p/y);
				p=p%y;				
			}
			Console.WriteLine();
			
			
		}
		
	}
}
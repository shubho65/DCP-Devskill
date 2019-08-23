#define ONLINE_JUDGE
using System;
					
public class Program
{
	
	public static void Main()
	{
		int n=int.Parse(Console.ReadLine());
		for(var i=0;i<n;i++)
		{
			int a=int.Parse(Console.ReadLine());
			int[] arr=new int[45];
			arr[1]=1;
			arr[2]=3;
			for(var j=3;j<45;j++)
			{
				arr[j]=arr[j-1]+arr[j-2];
			}
			Console.WriteLine("{0}",arr[a]);
			
		}
		
				
	
	}
}
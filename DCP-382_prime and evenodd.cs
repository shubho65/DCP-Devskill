#define ONLINE_JUDGE
using System;
					
public class Program
{
	
	public static void Main()
	{
		string str=String.Empty;
		while((str=Console.ReadLine()) != null)
		{
			string[] arr=new string[2];
			arr=str.Split(' ');
			//Console.WriteLine("{0} {1}",arr[0],arr[1]);
			long N=long.Parse(arr[0]);
			long M=long.Parse(arr[1]);
			
			if(N==M) 
			{
				Console.WriteLine("Even");
			}
			else if (N==1 || M==1) 
			{
				Console.WriteLine("Odd");
			}
			else Console.WriteLine("Even");
		}

		
				
	
	}
}
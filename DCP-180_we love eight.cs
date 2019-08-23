#define ONLINE_JUDGE
using System;
					
public class Program
{
	
	public static void Main()
	{
			
		int t=int.Parse(Console.ReadLine());
		
		for(var p=0;p<t;p++)
		{
				string str=Console.ReadLine();
				char[] arr=str.ToCharArray();
				int sum=0, multi=1;
				for(int i=arr.Length-1;i>=arr.Length-3;i--)
				{
					sum += (arr[i]-48) * multi;
					multi= multi *10;
					//Console.WriteLine(sum);
				}
			
				if(sum%8==0) 
				{
					Console.WriteLine("YES");
					if(arr[0]=='A') Console.WriteLine(1);
					else Console.WriteLine(0);
				}
				else Console.WriteLine("NO");

		}
		
				
	
	}
}
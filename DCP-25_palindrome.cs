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
				str=str.ToUpper();
				char[] arr=str.ToCharArray();
				int end=arr.Length-1;
				int begin=0;
				while(end>begin)
				{
					if(arr[begin++] != arr[end--]) 
					{
						Console.WriteLine("No");
						break;
					}
				}
				//Console.WriteLine("Begin{0} End{1}",begin,end);
				if(end<=begin) Console.WriteLine("Yes");
				

		}
		
				
	
	}
}
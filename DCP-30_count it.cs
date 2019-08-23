#define ONLINE_JUDGE
using System;
					
public class Program
{
	
	public static void Main()
	{
		
		int t=int.Parse(Console.ReadLine());
		
		
		for(var k=0;k<t;k++)
		{
			int[] count=new int[26];
			string str=Console.ReadLine();
			char[] arr=str.ToCharArray();
			int x=0;
			for(int i=0;i<arr.Length;i++)
			{
				x=arr[i]-'a';
				count[x]++;
			}
			Console.WriteLine("Case {0}:",k+1);
			//Console.WriteLine();
			for(int i=0;i<26;i++)
			{
				if(count[i]!=0)
					Console.WriteLine("{0} {1}",(char)(i+'a'),count[i]);
			}
		}
		
	}
}
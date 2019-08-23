#define ONLINE_JUDGE
using System;
					
public class Program
{
	
	public bool isVowel(char a)
	{
		if (a=='a'||a=='e'||a=='i'||a=='o'||a=='u')
		return true;
		else return false;
	}
	
	public static void Main()
	{
		var pr=new Program();
		int t=int.Parse(Console.ReadLine());
		for(var k=0;k<t;k++)
		{
			int n=int.Parse(Console.ReadLine());
			string str=Console.ReadLine();
			char[] arr=str.ToCharArray();
			int count=0,i=0;
			for(i=0;i<n;i++)
			{
				
				if(pr.isVowel(arr[i]))
				{
					count++;
					for(var j=i+1;j<n;j++)
					{
						if(pr.isVowel(arr[i])) i++;
						else break;
					}
				}				
			}
			Console.WriteLine("Case {0}: {1}",k+1,count);
		}
		
		
	}
}
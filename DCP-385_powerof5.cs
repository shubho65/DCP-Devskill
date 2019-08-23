#define ONLINE_JUDGE
using System;
					
public class Program
{

	public bool powerof5(long N)
	{
		bool flag=false;
		long x=1;
		for(var i=0;;i++)
		{
			x=x*5;
			if(x>N) break;
			if(x==N)
			{
				flag=true;
				break;
			}	
		}
		if(N==1) flag=true;
		return flag;
	}
	
	public static void Main()
	{
		
		int t=int.Parse(Console.ReadLine());		
		var pr=new Program();
		
		for(var k=0;k<t;k++)
		{
			long N=long.Parse(Console.ReadLine());	
			bool flag=pr.powerof5(N);
			if(flag==true) Console.WriteLine("YES");
			else Console.WriteLine("NO");
		}
				

		
	}
}
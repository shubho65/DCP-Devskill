#define ONLINE_JUDGE
using System;
using System.Numerics;

namespace Practicecsharp
{
	public class ArrayPractice
	{
		
		public static void Main()
		{
			int n=int.Parse(Console.ReadLine());
		
				for(var i=0;i<n;i++)
				{
					long a=long.Parse(Console.ReadLine());
					if(a%2==0) Console.WriteLine("Case {0}: {1}",i+1,(a/2)*(a/2));
					else Console.WriteLine("Case {0}: {1}",i+1,(a/2)*(a/2 +1));
				}
			
		}
		
		   
		
	}
	
}


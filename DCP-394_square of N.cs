#define ONLINE_JUDGE
using System;
using System.Numerics;

namespace Practicecsharp
{
	public class ArrayPractice
	{
		
		
		
		public static void Main()
		{
			var str=string.Empty;
			while((str = Console.ReadLine())!=null)
			{
				for(var i=0;i<str.Length-1;i++)
				{
					Console.Write("9");
				}
				Console.Write("8");
				
				for(var i=0;i<str.Length-1;i++)
				{
					Console.Write("0");
				}
				Console.Write("1");
				Console.WriteLine();

			}
			
		}
		
		   
		
	}
	
}


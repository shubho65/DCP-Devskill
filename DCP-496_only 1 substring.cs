#define ONLINE_JUDGE
using System;
using System.Collections.Generic;

namespace Practicecsharp
{
	public class ArrayPractice
	{
		
		public static void Main()
		{
			
			var count=0;
			int n=int.Parse(Console.ReadLine());
			
			for(int i=0;i<n;i++)
			{	
				count=0;
				var str=Console.ReadLine();
				char[] array = str.ToCharArray();
				for(int j=0;j<array.Length;j++)
				{
					if(array[j]=='1') 
					{
						count++;
						for(int k=j+1;k<array.Length;k++)
						{
							if(array[k]=='1') count++;
							else break;
						}
					}
					
				}
				
				Console.WriteLine(count);
				
				
			}
			
		
			
		}
		
	}
	
}


#define ONLINE_JUDGE
using System;

namespace Practicecsharp
{
	public class ArrayPractice
	{
		
		public static void Main()
		{
			

            int n = int.Parse(Console.ReadLine());
			

            for (var i = 0; i < n; i++)
            {
				/*string[] arr=new string[3];
				string str=Console.ReadLine();
				arr=str.Split(' ');
				
				double a =double.Parse(arr[0]);
				double b =double.Parse(arr[1]);
				double c =double.Parse(arr[2]);*/
				
				int a = int.Parse(Console.ReadLine());
				//int b= (int)Math.Pow(((double)a*(a+1))/2,2);
				int b= ((a*(a+1))/2) * ((a*(a+1))/2);
				Console.WriteLine("Case {0}: {1}",i+1,b);
				
				
            }	
		
			
		}
		
	}
	
}


#define ONLINE_JUDGE
using System;

namespace Practicecsharp
{
	public class ArrayPractice
	{
		
		public static void Main()
		{
			
			string line=String.Empty;
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
			{
				//string line = Console.ReadLine();
				var lineparts = line.Split(' ');
				int t = int.Parse(lineparts[0]);
				int n = int.Parse(lineparts[1]);
				int total=0;
				for (var i = 0; i < n; i++)
				{
					 int a=int.Parse(Console.ReadLine());
					 total+=a;
				}
				//var res=Math.Ceiling(Convert.ToDouble((double)t/total));
				var res=Math.Ceiling((double)t/total);
				if(res==1)
				Console.WriteLine("Project will finish within 1 day.");
				else
				Console.WriteLine("Project will finish within {0} days.",res);
			}
			
		
			
		}
		
	}
	
}


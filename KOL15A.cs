using System;
					
public class Program
{
	public static void Main()
	{
		
		int t=int.Parse(Console.ReadLine());
			
		while(t>0)
		{
			string str=Console.ReadLine();
			char[] arr=str.ToCharArray();
		
			int sum=0;
			for(int i=0;i<arr.Length;i++)
			{	
				if(Char.IsNumber(arr[i]) == true) sum += arr[i]-48;
				//Console.WriteLine(sum);
			}
			Console.WriteLine(sum);
			t--;
		}
	
		
	}
}
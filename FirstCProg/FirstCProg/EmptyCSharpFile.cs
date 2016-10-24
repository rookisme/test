/*using System;
namespace letstry
{
	class divbyzer
	{
		public static void Main(string[] args)
		{
			int numbr1, numbr2;
			float total;
			Console.Write("Enter the first number: ");
			numbr1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("\nEnter the 2nd number: ");
			numbr2 = Convert.ToInt32(Console.ReadLine());
			try
			{
				numbr2 -= numbr2;
				total = numbr1 / numbr2;
			}
			catch (DivideByZeroException error1)
			{
				Console.WriteLine("While dividing {0} / {1} we reached an invalid conclusion");
			}
		}
	}
}
*/
/*using System;
namespace Cal
{
	class Calculator
	{
		public static void Main(string[] args)
		{
			int opt, numb1, numb2;
			float result;
		label:
			Console.WriteLine("\n\t Menu");
			Console.WriteLine("\nPress 1 for add");
			Console.WriteLine("Press 2 for subtraction");
			Console.WriteLine("Press 3 for multiplication");
			Console.WriteLine("Press 4 for Division");

			Console.Write("\n\nEnter the First number:\t");
			numb1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the 2nd number:\t");
			numb2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("\nEnter your option:\t");
			opt = Convert.ToInt32(Console.ReadLine());
			if (opt == 1)
			{
				result = numb1 + numb2;
				Console.WriteLine("\n {0} + {1} = {2}", numb1, numb2, result);
			}
			else if (opt == 2)
			{
				result = numb1 - numb2;
				Console.WriteLine("\n {0} - {1} = {2}", numb1, numb2, result);
			}
			else if (opt == 3)
			{
				result = numb1 * numb2;
				Console.WriteLine("\n {0} x {1} = {2}", numb1, numb2, result);
			}
			else if (opt == 4)
			{
				result = (float)(numb1 / numb2);
				Console.WriteLine("\n {0} / {1} = {2}", numb1, numb2, result);
			}
			else
			{
				Console.WriteLine("invalid option. Try again");
			}
			goto label;
			Console.ReadLine();
		}
	}
}
*/
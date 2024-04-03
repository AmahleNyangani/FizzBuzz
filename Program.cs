using System;


namespace FizzBuzz
{
	public class Program
	{
		[STAThread]
		public static void Main()
		{
			FizzBuzz();
		}
		//Coding challenge
		public static void FizzBuzz()
		{
			for (int num = 0; num < 14; num++)
			{
				if (num % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if
					(num % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(num);
				}
			}

		}
	}
}


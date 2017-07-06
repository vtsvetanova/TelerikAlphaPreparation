using System;

class MainClass
{
	static void CalculateResult(double digit1, double digit2, double digit3)
	{
		double product = digit1 * digit2;
		double sum = digit1 + digit2;

		if (digit3 == 0) 
		{
			Console.WriteLine("{0:F2}", product);
		} 
		else if (digit3 > 0 && digit3 < 6) 
		{
			Console.WriteLine("{0:F2}", product / digit3);
		} 
		else if (digit3 > 5) 
		{
			Console.WriteLine("{0:F2}", sum * digit3);
		}
	}

	public static void Main()
	{
		string input = Console.ReadLine();

		if (input.Length == 3) 
		{
			//first digit on the left
			double firstDigit = double.Parse(input[0].ToString());
			//digit at the middle
			double secondDigit = double.Parse(input[1].ToString());
			//first digit on the right
			double thirdDigit = double.Parse(input[2].ToString());

			CalculateResult(firstDigit, secondDigit, thirdDigit);
		}
	}
}
//Calculate the average of a set of marks

using System;

public class Average
{
	public static void Main()
	{
		double a = 0, b, counter = 0, average;
		string mark;
		
		Console.Write("Insert a mark: ");
		mark = Console.ReadLine();
			 
		while(mark != "end")
		{
			b = Convert.ToDouble(mark);
			counter++;
			a += b;
			
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}
		
		if(counter != 0)
		{
			average = a / counter;
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
	

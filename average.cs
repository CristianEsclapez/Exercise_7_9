//Calculate the average of a set of marks

using System;

public class Average
{
	public static void Main()
	{
		double firstNote = 0, secondNote, counter = 0, average;
		string mark;
		
		Console.Write("Insert a mark: ");
		mark = Console.ReadLine();
			 
		while(mark != "end")
		{
			secondNote = Convert.ToDouble(s);
			counter++;
			firstNote += secondNote;
			
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}
		
		if(counter != 0)
		{
			average = firstNote / counter;
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
	

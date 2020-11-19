using System;

class digits
{
	
	static void Main()
	{
		int oneDigit = 0, twoDigits = 0, threeDigits = 0, nDigits = 0;
		Console.WriteLine("Insert a number: ");
		
		string close = Console.ReadLine();
		
		while(close != "end")
		{
			int input = Convert.ToInt32(close);
			
			if(input != 0)
			{
				if(input/10 == 0)
					oneDigit++;
				else if (input/100 == 0)
					twoDigits++;
				else if (input/1000 == 0)
					threeDigits ++;
				else
					nDigits ++; 
			}
			close = Console.ReadLine();
		}
		Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
		oneDigit, twoDigits, threeDigits, nDigits); 


	}
}


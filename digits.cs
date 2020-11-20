//The program ends when the user types the user types “end”.
using System;

class digits
{
	
	static void Main()
	{
		int n = 0, n2 = 0, n3 = 0, nx = 0;
		Console.WriteLine("Insert a number: ");
		
		string close = Console.ReadLine();
		
		while(close != "end")
		{
			int input = Convert.ToInt32(close);
			
			if(input != 0)
			{
				if (input/10 == 0)
					n++;
				else if (input/100 == 0)
					n2++;
				else if (input/1000 == 0)
					n3++;
				else
					nx++; 
			}
			close = Console.ReadLine();
		}
		Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
		n, n2, n3, nx); 


	}
}


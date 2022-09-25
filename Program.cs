try
{
    int colums = 0;
    while (colums % 2 == 0)
    {
        Console.WriteLine("Enter number of colums:");
        colums = int.Parse(s: Console.ReadLine());
    }
    
    int rows = colums;
	int centre = Math.Abs((colums + 1) / 2);
	for (int i = 1; i <= colums; i++)
	{
		if (i<=centre)
		{
			for (int j = 1; j <= i-1; j++)
			{
				Console.Write(" ");
			}
			for (int k = 1; k <= colums + 1 - (2 * i - 1); k++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
		else
		{
			for (int j = 1; j <=(colums-centre)-(i-centre); j++)
			{
				Console.Write(" ");
			}
			for (int k = 1; k <= 2*(i-centre)+1; k++)
			{
                Console.Write("*");
            }
			Console.WriteLine();
		}

	}
}
catch (Exception)
{

	Console.WriteLine("Enter only numbers!!!");
}

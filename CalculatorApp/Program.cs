void CalculatorApp()
{


try
{
		Console.WriteLine("Enter the First Number:"); 
		int firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the Second Number:");
		int secondNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the Operation (+, -, *, /)");

		char operation = Convert.ToChar(Console.ReadLine());
		
		int result = 0;
		
		switch (operation)
		{
			case '+':
				result = firstNumber + secondNumber;
				break;
			case '-':
                result = firstNumber - secondNumber;
				break;
			case '*':
				result = firstNumber * secondNumber;
				break;
            case '/':	
				result = firstNumber / secondNumber;
				break;
        }
		Console.WriteLine($"Result: {result}");


    }
catch (Exception ex)
{
		Console.WriteLine($"Error: {ex.Message} Please Enter a valid operation.");
       
}
 }

CalculatorApp();
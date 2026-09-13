static double Calculate(double num1, double num2, char operationType)
{
    switch (operationType)
    {
        case '+':
            return num1 + num2;

        case '-':
            return num1 - num2;

        case '*':
            return num1 * num2;

        case '/':
            return num1 / num2;

        default:
            return 0;
    }
}


static bool IsValidNumber(string input, out double number)
{
    return double.TryParse(input, out number);
}


static bool IsValidOperation(string input, out char operationType)
{
    if (char.TryParse(input, out operationType) &&
        "+-*/".Contains(operationType))
    {
        return true;
    }

    return false;
}


bool calcAgain = true;

while (calcAgain)
{
    Console.Write("Enter first number: ");

    if (!IsValidNumber(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Invalid number.");
        continue;
    }

    Console.Write("Enter an operation type [ + , - , *  ,  / ] : ");

    if (!IsValidOperation(Console.ReadLine(), out char operationType))
    {
        Console.WriteLine("Invalid operation.");
        continue;
    }

    Console.Write("Enter second number: ");

    if (!IsValidNumber(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Invalid number.");
        continue;
    }


    if (operationType == '/' && num2 == 0)
    {
        Console.WriteLine("Cannot divide by zero.");
        continue;
    }



    double result = Calculate(num1, num2, operationType);
    Console.WriteLine($"\n\n_______________Result________________\n");
    Console.WriteLine($" {num1} {operationType} {num2} = {result}");
    Console.WriteLine($"\n______________________________________\n");


    Console.Write("Do you want to perform another Calculation? [y/n]: ");

    char userChoice = Convert.ToChar(Console.ReadLine());

    if (userChoice ==  'y')
    {
        calcAgain = true;
    }
    else
    {
        calcAgain = false;
    }
}
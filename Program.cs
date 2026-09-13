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


Console.Write("Enter first number: ");

double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter an operation type [ + , - , *  ,  / ] : ");

char operationType = Convert.ToChar(Console.ReadLine());

Console.Write("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());



double result = Calculate(num1, num2, operationType);
Console.WriteLine( $"\n\n_______________Result________________\n" );
Console.WriteLine( $" {num1} {operationType} {num2} = {result}");
Console.WriteLine($"\n______________________________________\n");

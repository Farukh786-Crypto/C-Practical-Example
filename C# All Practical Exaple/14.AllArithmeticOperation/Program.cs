//  C# Program to Perform All Arithmetic Operations
int result;
char option;
Console.WriteLine("Enter First Number =");
int a = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Second Number =");
int b = Int32.Parse(Console.ReadLine());

Console.WriteLine("Select Operation");

Console.WriteLine("1. Addition");
Console.WriteLine("2. Substraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
option = Convert.ToChar(Console.ReadLine());

switch (option)
{
    case '1':
        result = a + b;
        Console.WriteLine($"the result of Addition is :{result}");
        break;
    case '2':
        result = a - b;
        Console.WriteLine($"the result of Substraction is :{result}");
        break;
    case '3':
        result = a * b;
        Console.WriteLine($"the result of Multiplication is :{result}");
        break;
    case '4':
        if (b != 0)
        {
            result = a / b;
            Console.WriteLine($"the result of Division is :{result}");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
            return;
        }
        break;
    default:
        Console.WriteLine("Invalid options");
        break;
}


Console.ReadLine();

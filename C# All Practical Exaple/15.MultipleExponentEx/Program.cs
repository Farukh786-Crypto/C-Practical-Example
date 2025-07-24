// C# Program to Perform Multiplication of Exponents of Same Base

int Result = 1;
Console.WriteLine("Enter the Base Number =");
int Base = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter first Exponent =");
int expo1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Second Exponent");
int expo2 = Int32.Parse(Console.ReadLine());

int addExponent = expo1 + expo2;

for (int i = 1; i <= addExponent; i++)
{
    Result = Result * Base;
}
Console.WriteLine($"{Result} is final value");
Console.ReadKey();
// C# Program to Check Whether a Number is Positive or Not

Console.WriteLine("Enter A Number =");
int n = Int32.Parse(Console.ReadLine());

if (n > 0)
{
    Console.WriteLine($"{n} is Positve");
}
else if (n == 0)
{
    Console.WriteLine($"{n} is 0");
}
else if (n < 0)
{
    Console.WriteLine($"{n} is Negative");
}

Console.ReadKey();

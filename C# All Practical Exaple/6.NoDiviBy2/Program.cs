// C# Program to Check if a Number is Divisible by 2

Console.WriteLine("Enter a Number =");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine($"{n} is divisible by 2");
}
else
{
    Console.WriteLine($"{n} is not divisible by 2");
}

Console.ReadKey();

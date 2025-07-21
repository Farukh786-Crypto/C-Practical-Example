// C# Program to Find the Largest of Two Numbers

Console.WriteLine("Enter first Number");
int a= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second Number");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} is larger than {b}");
}
else
{
    Console.WriteLine($"{a} is smaller than {b}");
}

Console.ReadKey();


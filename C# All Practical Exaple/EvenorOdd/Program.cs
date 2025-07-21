using System.Threading.Channels;


Console.WriteLine("Enter a Number =:");
int n = Int32.Parse(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine($"{n} is Even Number");
}
else
{
    Console.WriteLine($"{n} is Odd Number");
}
Console.ReadKey();


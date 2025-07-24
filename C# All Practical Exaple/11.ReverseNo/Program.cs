// C# Program to Reverse a Number

Console.WriteLine("Enter a Number :");
int n = Int32.Parse(Console.ReadLine());
int rev = 0;
while (n != 0)
{
    int lastDigit = n % 10;
    rev = rev * 10 + lastDigit;
    n = n / 10;
}
Console.WriteLine($"Reversed Number ={rev}");
Console.ReadKey();

// Sum of Digits Program in C#

Console.WriteLine("Enter a number =");
int n = Int32.Parse(Console.ReadLine());
int sum = 0;
while (n!=0)
{
    int lastDigit = n % 10;
    sum = sum + lastDigit;
    n = n / 10;
}
Console.WriteLine($"Sum of digit is {sum}");

Console.ReadKey();
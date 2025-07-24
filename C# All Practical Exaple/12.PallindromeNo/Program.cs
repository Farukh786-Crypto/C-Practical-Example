
Console.WriteLine("Enter Number =");
int n = Int32.Parse(Console.ReadLine());
int temp = n;
int rev = 0;
while (n != 0)
{
    int rem = n % 10;
    rev = rev * 10 + rem;
    n = n / 10;
}
if (rev == temp)
{
    Console.WriteLine($"{temp} is pallindrome Number.");
}
else
{
    Console.WriteLine($"{temp} is not pallindrome Number.");
}
Console.ReadKey();

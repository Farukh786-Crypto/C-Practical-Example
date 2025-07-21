// C# Program to Find the Sum of All the Multiples of 3 and 5
int sum = 0;
for (int i = 0; i <= 10; i++)
{
    int a = i % 3;
    int b = i % 5;
    if (a==0 || b==0)
    {
        sum = sum  + i;
    }
}
Console.WriteLine($" Sum is {sum}");
Console.ReadKey();
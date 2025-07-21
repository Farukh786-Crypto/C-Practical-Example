
static int SumOfDigits(int num)
{
    if (num == 0)
    {
        return 0;
    }
    return (num%10) + SumOfDigits(num / 10);
}


Console.WriteLine("Enter Number");
int n= Int32.Parse(Console.ReadLine());

int result  = SumOfDigits(n);

Console.WriteLine($"Sum of digit :{result}");

Console.ReadKey();
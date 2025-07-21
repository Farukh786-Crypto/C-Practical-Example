
Console.WriteLine("Enter the size of an array =");
int n = Int32.Parse(Console.ReadLine());

int[] num = new int[n];

for (int i = 1; i <= n; i++)
{
    int a = i % 17;
    if (a == 0)
    {
        Console.WriteLine(i);
    }
}


Console.ReadKey();
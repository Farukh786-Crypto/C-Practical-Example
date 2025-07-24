Console.WriteLine("Enter Number :");
int n = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write("\n");
    //Console.WriteLine(i);
    for (int j = 1; j <= n; j++)
    {
        Console.Write(j * i+"  ");
    }
    //Console.Write("\n");
}

Console.ReadKey();
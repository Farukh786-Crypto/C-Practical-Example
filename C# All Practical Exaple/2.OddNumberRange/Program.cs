//C# Program to Print Odd Numbers in a Given Range
Console.WriteLine("Enter the size of Number =");
int n = Int32.Parse(Console.ReadLine());
int[] num = new int[n];

// solution 1

//for (int i = 0; i < n; i++)
//{
//    num[i] = i + 1; 
//    //Console.WriteLine($"{num[i]}");
//}
//foreach (int i in num)
//{
//    if (i % 2 != 0)
//    {
//        Console.WriteLine($"{i} is Odd Number");
//    }
//}

for (int i = 0; i < n; i=i+1)
{
    if (i % 2 == 1)
    {
        Console.WriteLine($"{i} is Odd Number");
    }
}

Console.ReadKey();


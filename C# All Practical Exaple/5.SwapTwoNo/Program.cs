// C# Program to Swap Two Numbers

int a, b, temp;
Console.WriteLine("Enter First No :");
a = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Second No :");
b = Int32.Parse(Console.ReadLine());

Console.WriteLine($"before Swap a={a} and b={b}");

temp = a;
a = b;
b = temp;

Console.WriteLine($"After Swap a={a} and b={b}");


Console.ReadKey();

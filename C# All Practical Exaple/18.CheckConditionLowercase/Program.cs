Console.WriteLine("Enter a Character From A to C");
char ch = Convert.ToChar(Console.ReadLine());
Console.WriteLine();

char lowerchar = Char.ToLower(ch);

if (lowerchar == 'a')
{
    Console.WriteLine("You choose Option A");
}
if (lowerchar == 'b')
{
    Console.WriteLine("You choose Option B");
}
if (lowerchar == 'c')
{
    Console.WriteLine("You choose Option C");
}
Console.ReadKey();

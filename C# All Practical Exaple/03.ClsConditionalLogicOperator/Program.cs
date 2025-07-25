// C# Program to Illustrate the use of Conditional Logical Operator

int Age;
Console.WriteLine("Enter the Age =");
Age = Int32.Parse(Console.ReadLine());

bool isAgeValid = (Age > 18) ? true : false;
if (isAgeValid)
{

    Console.WriteLine($"Age is Valid For Vote");
}
else
    Console.WriteLine($"Age is Invalid For Vote");

    Console.ReadKey();
// C# convert decimal to binary

Console.WriteLine("Enter a Number =");
int n = Int32.Parse(Console.ReadLine());
// string binary = Convert.ToString(number, 2);  // build in method
string binary = String.Empty;
while (n > 0)
{
    int rem = n % 2; // here we get 0 or 1
    binary = binary + rem; // prepend the remainder to the binary string
    n = n / 2;  // here we get the quotient
}
Console.WriteLine($"Binary no is {binary}");


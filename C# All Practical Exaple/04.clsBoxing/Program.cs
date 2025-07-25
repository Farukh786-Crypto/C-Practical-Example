// C# Program to Demonstrate Boxing Operations

// Here Boxing is the process of converting a value type to the type object or
// to any interface type implemented by this value type.

int num = 100;
object obj = num; // Boxing: converting int to object

int unBoxingnum = (int)obj; // Unboxing: converting object back to value type

Console.WriteLine("Original Number :"+num);
Console.WriteLine("Boxing Object :"+obj);
Console.WriteLine("UnBoxing Number :"+unBoxingnum);

Console.ReadKey(); // Wait for user input before closing the console window
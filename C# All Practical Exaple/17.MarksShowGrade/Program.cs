// C# Program to Read a Grade and Display the Equivalent Description

Console.WriteLine("Enter the Grade in Uppercase");
char grade = Convert.ToChar(Console.ReadLine());

switch (grade)
{
	case 'S':
		Console.WriteLine("Super");
		break;
	case 'A':
		Console.WriteLine("Very Good");
		break;
	case 'B':
		Console.WriteLine("FAIR");
		break;
	case 'y':
		Console.WriteLine("FAIL");
		break;
	default:
        Console.WriteLine("Error in Grade \n");
		break;
		Console.ReadLine();
}


Console.ReadKey();
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! SOLID EXAMPLES");
Console.WriteLine("--------------------------------------------------------------------------------------");
Console.WriteLine("Select an option: ");
Console.WriteLine("S for S – Single Responsibility Principle (SRP)");
Console.WriteLine("O for O – Open/Closed Principle (OCP)");
Console.WriteLine("L for L – Liskov Substitution Principle (LSP)");
Console.WriteLine("I for I – Interface Segregation Principle (ISP)");
Console.WriteLine("D for D – Dependency Inversion Principle (DIP)");
Console.WriteLine("--------------------------------------------------------------------------------------");
string value = Console.ReadLine();
switch (value)
{
	case "S":
        Console.WriteLine("You have selected S");
		break;
    case "O":
        Console.WriteLine("You have selected O");
        break;
    case "L":
        Console.WriteLine("You have selected L");
        break;
    case "I":
        Console.WriteLine("You have selected I");
        break;
    case "D":
        Console.WriteLine("You have selected D");
        break;
    default:
		break;
}
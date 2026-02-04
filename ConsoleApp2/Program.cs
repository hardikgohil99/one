// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Enter a number between 1 to 5: ");
var num = Console.ReadLine();
if (int.TryParse(num, out int result))
{
    if (result >= 1 && result <= 5)
    {
        Console.WriteLine($"You entered a valid number: {result}");
    }
    else
    {
        Console.WriteLine("The number is out of range. Please enter a number between 1 to 5.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a numeric value.");
}
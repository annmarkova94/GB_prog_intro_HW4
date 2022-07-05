// Write a method that takes 2 numbers (A real, B natural) and print out A^B
// I decided to write 3 separate methods
ApowB();

void ApowB()
{
    Console.WriteLine(Math.Pow(EnterRealNumber(), EnterNaturalNumber()));
}

double EnterRealNumber()
{
    double real_number;
    Console.Write("Enter a real number (for ex. 7,987): ");
    while (!double.TryParse(Console.ReadLine(), out real_number))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("This is not a real number, try again: ");
        Console.ResetColor();
    }
    return real_number;
}

int EnterNaturalNumber()
{
    int natural_number;
    Console.Write("Enter a natural number: ");
    while (!int.TryParse(Console.ReadLine(), out natural_number)
           || natural_number < 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("This is not a natural number, try again: ");
        Console.ResetColor();
    }
    return natural_number;
}
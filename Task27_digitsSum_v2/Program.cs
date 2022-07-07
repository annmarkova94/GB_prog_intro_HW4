// Take a number and return sum of its digits (I use only natural numbers)
// 2st option using an integer

DigitsSum();

void DigitsSum()
{
    int ourNumber = EnterNaturalNumber();
    int ourNumberForHelp = ourNumber;
    int digitsSum = 0;
    while (ourNumberForHelp > 0)
    { 
        digitsSum += ourNumberForHelp % 10;
        ourNumberForHelp /= 10;
    }
    Console.WriteLine($"The number is {ourNumber}, sum of its digits equals {digitsSum}");
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
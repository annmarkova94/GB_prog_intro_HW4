// Take a number and return sum of its digits (I use only natural numbers)
// 1st option using a string
// Not sure that using item.ToString() is the best way

DigitsSum();

void DigitsSum()
{
    string strNumber = Convert.ToString(EnterNaturalNumber());
    int digitsSum = 0;
    foreach (var item in strNumber)
    {
        digitsSum += int.Parse(item.ToString());
    }
    Console.WriteLine($"The number is {strNumber}, sum of its digits equals {digitsSum}");
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
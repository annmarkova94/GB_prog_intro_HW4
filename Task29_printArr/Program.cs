// Take an array and print out each item
// Did it in 3 ways: using foreach loop, for loop and Array.ForEach method

PrintOutArray1WayForeach();
PrintOutArray2WayFor();
PrintOutArray3ArrayForEach();

void PrintOutArray1WayForeach()
{
    int[] array = RandArray();
    Console.Write("[");
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
    Console.Write("\b\b");
    Console.WriteLine("]");
}

void PrintOutArray2WayFor()
{
    int[] array = RandArray();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b");
    Console.WriteLine("]");
}

void PrintOutArray3ArrayForEach()
{
    int[] array = RandArray();
    Console.Write("[");
    Array.ForEach(array, element => Console.Write($"{element}, "));
    Console.Write("\b\b");
    Console.WriteLine("]");
}

int[] RandArray()
{
    Console.Write("Enter the length of an array that you want to be randomly generated: ");
    int array_length = EnterInteger();
    int[] yourArray = new int[array_length];
    for (int i = 0; i < array_length; i++)
    {
        yourArray[i] = new Random().Next(0, 10);
    }
    return yourArray;
}

int EnterInteger()
{
    int number;
    Console.Write("Enter a natural number: ");
    while (!int.TryParse(Console.ReadLine(), out number)
           || number < 1
           || number % 1 > 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("This is not a number, try again: ");
        Console.ResetColor();
    }
    return number;
}

var isValidNumber = false;
do
{
    int number;
    Console.Write("Please enter a valid number: ");
    var castNumber = int.TryParse(Console.ReadLine(), out number);
    if (castNumber && number >= 0)
    {
        Console.WriteLine(CalulateFactorial(number));
    }
} while (!isValidNumber);




static long CalulateFactorial(int number)
{
    if (number == 0 || number == 1)
        return 1;
    return (long)number * CalulateFactorial(number - 1);
}

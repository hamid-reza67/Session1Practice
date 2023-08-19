var isValidNumber = true;
int number = 0;
do
{
    Console.Write("Please enter a valid number: ");
    var castNumber = int.TryParse(Console.ReadLine(), out number);
    if (!castNumber || number < 0)
        isValidNumber = false;
    else
        isValidNumber = true;
} while (!isValidNumber);


Console.WriteLine(CalulateFactorial(number));

static long CalulateFactorial(int number)
{
    if (number == 0 || number == 1)
        return 1;
    return (long)number * CalulateFactorial(number - 1);
}

int[] a = { 15, 2, 51, 36, 75, 125, 65, 45, 20, 24, 85, 100, 254, 61, 73 };
Console.Write("Please Enter a number: ");
var res = int.TryParse(Console.ReadLine(), out int number);
if (!res)
    return;

var findeIndex = Search(a, number);
if (findeIndex == -1)
    Console.WriteLine("The number is not found");
else
    Console.WriteLine($"The entered number is in index {findeIndex}");

static int Search(int[] a, int number)
{
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == number) return i;
    }
    return -1;
}

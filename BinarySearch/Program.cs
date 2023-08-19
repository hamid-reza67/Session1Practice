int[] a = { 15, 2, 51, 36, 75, 125, 65, 45, 20, 24, 85, 100, 254, 61, 73 };
Console.Write("Please Enter a number: ");
var res = int.TryParse(Console.ReadLine(), out int number);
if (!res)
    return;

Array.Sort(a);
Console.WriteLine("Sorted Array...");
foreach (int x in a)
    Console.Write(x + " ");
Console.WriteLine();

var findeIndex = BinarySearch(a, number, 0, a.Length - 1);
if (findeIndex == -1)
    Console.WriteLine("The number is not found");
else
    Console.WriteLine($"The entered number is in index {findeIndex}");



static int BinarySearch(int[] arr, int key, int min, int max)
{
    if (min <= max)
    {
        int mid = min + (max - min) / 2;
        if (arr[mid] == key)
            return mid;

        if (arr[mid] > key)
            return BinarySearch(arr, key, min, mid - 1);

        return BinarySearch(arr, key, mid + 1, max);
    }
    return -1;
}

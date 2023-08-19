

int[] arr = { 37, 23, 0, 17, 12, 72, 31, 46, 100, 88, 54 };

Sort(arr);

for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");


static int[] Sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int j = i - 1;
        int key = array[i];
        int index = BinarySearch(array, 0, j, key);
        while (j >= index)
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = key;
    }
    return array;
}
static int BinarySearch(int[] a, int min, int max, int key)
{
    if (min >= max)
        return (key > a[min]) ? (min + 1) : min;

    int mid = min + (max - min) / 2;
    if (a[mid] == key)
        return mid + 1;

    else if (a[mid] > key)
        return BinarySearch(a, min, mid - 1, key);
    else
        return BinarySearch(a, mid + 1, max, key);

}
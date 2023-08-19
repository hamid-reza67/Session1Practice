
int[] arr = { 35, 28, 0, 17, 83, 72, 31, 46, 5, 88, 54 };

BubbleSort(arr);

for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");


static void BubbleSort(int[] array)
{
    int len = array.Length;

    for (int i = 0; i < len; i++)
    {
        for (int j = 0; j < len - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

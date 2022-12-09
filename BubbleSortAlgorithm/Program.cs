

//int arrLength = 200;
//var random = new Random();
//int[] arr = new int[arrLength];
//for (int i = 0; i < arrLength; i++)
//    arr[i] = random.Next(0, 500);

int[] arr = { 11, 93, 45, 98, 13, 55 };
BubbleSort(arr, arr.Length);
Console.WriteLine("Sorted array...");
PrintArray(arr);
Console.WriteLine();


static void BubbleSort(int[] arr, int n)
{
    // condition for recursion
    if (n == 0 || n == 1)
        return;

    bool flag = false;

    for (int i = 0; i < n - 1; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            Swap(arr, i, i + 1);
            flag = true;
        }
    }
    if (flag)
        BubbleSort(arr, n - 1);
}

static void Swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

static void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; ++i)
        Console.Write(arr[i] + " ");
}
void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

string[] CreateArray(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Input the {i + 1} element of the array: ");
        arr[i] = Console.ReadLine();
    }

    return arr;
}

Console.WriteLine("Input size array: ");
int n = Convert.ToInt32(Console.ReadLine());


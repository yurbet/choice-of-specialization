void ShowArray(string[] arr)
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

int NumberOfValues(string[] arr)
{
    int m = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) m++;
    }

    return m;
}



Console.WriteLine("Input size array: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(n);
ShowArray(myArray);
Console.WriteLine();

if (NumberOfValues(myArray) == 0)
{
    Console.WriteLine("There are no elements in the array with a length less than or equal to three");
}
else
{

}
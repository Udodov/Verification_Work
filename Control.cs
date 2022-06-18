//  Setting the initial one-dimensional array
string[] initialArray = { "1234", "1567", "-2", "computer science" };
//  Declaring a new array with the size of the original array
string[] newArray = new string[initialArray.Length];

Console.WriteLine("Initial array:");
PrintArray(initialArray);

void PrintArray(string[] arr)   // Output an array to the console
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    Console.WriteLine();
}
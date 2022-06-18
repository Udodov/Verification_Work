//  Setting the initial one-dimensional array
string[] initialArray = { "1234", "1567", "-2", "computer science" };
//  Declaring a new array with the size of the original array
string[] newArray = new string[initialArray.Length];

Console.WriteLine("Initial array:");
PrintArray(initialArray);
Console.WriteLine("The resulting array:");
SelectedArray(initialArray);
PrintArray(newArray);

void PrintArray(string[] arr)   // Output an array to the console
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    Console.WriteLine();
}

void SelectedArray(string[] arr)  // Formation of elements of a new array satisfying the condition (length <=3) 
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3)
            newArray[i] = arr[i];
}
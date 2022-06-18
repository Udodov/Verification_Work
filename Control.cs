int n;
//  Entering the array size and checking the input
Console.Write("Enter the number of items you want to enter: ");
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)  // We read a string and convert it to a number. With a check for entering a positive integer
    Console.WriteLine("The number cannot be recognized, enter a positive integer");

string[] initialArray = new string[n]; // Declaration of one-dimensional arrays of strings of size n entered by the user
string[] newArray = new string[n];

FillArray(initialArray);
Console.WriteLine("Initial array:");
PrintArray(initialArray);
Console.WriteLine("The resulting array:");
SelectedArray(initialArray);
PrintArray(newArray);

void FillArray(string[] arr)   // Filling in an array using keyboard input
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Enter the element №{0}: ", i + 1);
        initialArray[i] = Console.ReadLine();
    }
}

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

/*
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
*/

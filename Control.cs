int n;
//  Entering the array size and checking the input
Console.Write("Enter the number of items you want to enter: ");
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)  // We read a string and convert it to a number. With a check for entering a positive integer
    Console.WriteLine("The number cannot be recognized, enter a positive integer");

string[] initialArray = new string[n]; // Declaration of one-dimensional arrays of strings of size n entered by the user
string[] newArray = new string[n];

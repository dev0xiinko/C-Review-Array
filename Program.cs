
// datatype[] identifier;
// string[] names =
// {
//     "Adrian",
//     "William",
//     "Dave"
// };

// datatype[] identifier = new datatype[size];
// int[] _ = new int[5];

// identifier[i] = value;

// numbers = [
//     1,
//     2,
//     3,
//     4,
//     5
// ];

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }


// string[] names = new string[3];

// Console.Write("Enter Name: ");
// names[0] = Console.ReadLine();

// Console.WriteLine($"I am, {names[0]}");

// int[] grades = [
//     90,
//     80,
//     70,
//     60,
//     50
// ];

// for (int i = 0; i < grades.Length; i++)
// {
//     Console.WriteLine(grades[i]);
// }



Console.Clear();
int[] grades = new int[5];
string[] names = new string[5];
int i = 0;


// Check if the name already exists in the array
// returnType MethodName(parameters)
// returnType: bool, int, string, etc. <-- the type of value the method will return
bool NameExists(string[] names, string name, int filledCount)
{
    for (int j = 0; j < filledCount; j++)
    {
        if (names[j] == name)
        {
            return true;
        }
    }
    return false;
}

// Loop until all names and grades are filled
while (i < names.Length)
{
    Console.Write($"{i + 1}.) Enter Name: ");
    string inputName = Console.ReadLine();
    // Check if the name already exists in the array
    if (NameExists(names, inputName, i))
    {
        Console.WriteLine("Name already exists. Please enter a different name.");
        continue;
    }
    // If the name does not exist, add it to the array
    names[i] = inputName;

    Console.Write($"{i + 1}.) Enter Grade: ");
    int.TryParse(Console.ReadLine(), out grades[i]); // TryParse will attempt to convert the input to an integer. If it fails, it will set grades[i] to 0.
    
    i++; // Increment the index to move to the next position in the arrays

    Console.Clear();
}

// Display the names and grades
for (int j = 0; j < names.Length; j++)
    {
        Console.WriteLine($"{j + 1}.) {names[j]} - {grades[j]}");
    }

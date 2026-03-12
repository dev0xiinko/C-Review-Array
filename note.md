# Names & Grades Program - Duplicate Name Check

## Overview

This program collects names and grades from the user, ensuring that no duplicate names are entered. It demonstrates the use of:

* Arrays (`string[]` for names, `int[]` for grades)
* Loops (`while` for input, `for` for iteration)
* Methods (`bool NameExists` for validation)
* Conditional statements (`if`)
* Console input/output (`Console.ReadLine()`, `Console.WriteLine()`)

---

## Program Workflow

### 1. Method: `NameExists`

```csharp
bool NameExists(string[] names, string name, int filledCount)
```

* **Purpose:** Checks if a given `name` already exists in the `names` array.
* **Parameters:**

  * `names` - the array of names collected so far
  * `name` - the new name to check for duplicates
  * `filledCount` - number of entries already filled in the array
* **Returns:** `true` if the name exists, `false` otherwise

**Workflow:**

1. Loop from 0 to `filledCount - 1`.
2. Compare each existing name with the new name.
3. Return `true` if a match is found.
4. Return `false` if no match is found.

### 2. Input Loop

```csharp
while (i < names.Length)
{
    // ask for name
    // check duplicates using NameExists
    // store if not duplicate
    // increment i
}
```

* Prompts the user to enter a name.
* Uses `NameExists` to validate the input.
* If duplicate, shows a warning and asks again.
* If not duplicate, stores the name and asks for the grade.
* Repeats until all names are collected.

### 3. Grade Input

* Uses `int.TryParse` to safely parse grades.
* Stores each grade in `grades[i]`.

### 4. Display Output

* After all entries are collected, the program prints all names with their corresponding grades.

```csharp
for (int j = 0; j < names.Length; j++)
{
    Console.WriteLine($"{j + 1}.) {names[j]} - {grades[j]}");
}
```

---

## Key Points / Notes

* `NameExists` ensures **no duplicates**.
* `filledCount` ensures we only check **already entered names**.
* `int.TryParse` prevents program crash if user enters non-numeric input.
* `continue` in the `while` loop allows the program to **retry name input** without incrementing the counter.
* `Console.Clear()` is optional for cleaner console output.

---

## Example Run

```
1.) Enter Name: Adrian
1.) Enter Grade: 90
2.) Enter Name: Iinko
2.) Enter Grade: 85
3.) Enter Name: Adrian
Name already exists. Please enter a different name.
3.) Enter Name: John
3.) Enter Grade: 70

Names & Grades:
1.) Adrian - 90
2.) Iinko - 85
3.) John - 70
```

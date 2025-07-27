# Exception Handling Demo in C\#

## Overview

This is a simple console application written in C# that demonstrates basic **exception handling** concepts. 
It allows a user to input two numbers and attempts to divide the first by the second. The program handles various 
exceptions gracefully and educates users on best practices when working with runtime errors.

## Features

* User input for two floating-point numbers.
* Safe division operation.
* Handles:

  * `FormatException` for invalid input types.
  * `DivideByZeroException` for division by zero.
  * General `Exception` catch block for any other runtime issues.
* Demonstrates use of `try`, `catch`, and comments on optional `finally`.

## Code Structure

### `Program.cs`

```csharp
class Program
{
    static void Main(string[] args)
    {
        Solution Solution = new Solution();
    }
}
```

* Entry point of the application.
* Instantiates the `Solution` class which contains the business logic.

### `Solution.cs`

```csharp
class Solution
{
    public Solution()
    {
        try
        {
            // Read and convert user input
            // Perform division
        }
        catch (FormatException)
        {
            // Handles invalid number input
        }
        catch (DivideByZeroException)
        {
            // Handles division by zero
        }
        catch (Exception)
        {
            // Handles all other exceptions
        }
    }
}
```

* Contains the logic for reading input, performing the division, and handling exceptions.
* Teaches how to catch and respond to different exception types.

## How to Run

1. Clone the repository:

   ```bash
   git clone https://github.com/Naoyuki-Christopher-H/exception-handling-demo-cs.git
   ```

2. Open the solution in **Visual Studio** or use the **.NET CLI**.

3. Build and run the project:

   ```bash
   dotnet build
   dotnet run
   ```

4. Follow the prompts in the console to input two numbers.

## Purpose

This demo is ideal for beginners learning:

* C# basics
* Exception handling patterns
* Defensive programming techniques

## DISCLAIMER  

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY IN 
THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES OF 
THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE PROJECT 
DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED ACCORDINGLY 
TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO THE APPLICATION 
(FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES THAT 
MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. IF YOU 
ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM SILENTLY 
OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST OR OPEN AN ISSUE 
ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN BE ADDRESSED APPROPRIATELY 
BY THE MAINTAINERS OR CONTRIBUTORS.

---

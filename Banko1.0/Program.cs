using System;
using System.Collections.Generic;
using System.Linq;

// Dictionary<string, string[]> plate = new Dictionary<string, string[]>
// {
//     { "Row1", new string[] { "20", "30", "43", "55", "70" } },
//     { "Row2", new string[] { "4", "14", "33", "44", "67" } },
//     { "Row3", new string[] { "29", "49", "68", "78", "87" } }
// };

Dictionary<string, Dictionary<string, int[]>> bankoPlates = new Dictionary<string, Dictionary<string, int[]>>();

void CreateBankoPlates()
{

    Dictionary<string, int[]> Mathias1 = new Dictionary<string, int[]>
        {
            { "Row1", new int[] { 0, 0, 20, 32, 42, 0, 67, 74, 0 } },
            { "Row2", new int[] { 8, 17, 23, 0, 0, 55, 0, 0, 86 } },
            { "Row3", new int[] { 9, 19, 0, 0, 47, 56, 0, 78, 0 } }
        };

    Dictionary<string, int[]> Mathias2 = new Dictionary<string, int[]>
        {
            { "Row1", new int[] { 1, 12, 0, 31, 0, 0, 60, 0, 81 } },
            { "Row2", new int[] { 5, 0, 0, 35, 45, 54, 63, 0, 0 } },
            { "Row3", new int[] { 0, 0, 25, 37, 0, 56, 0, 78, 90 } }
        };

    Dictionary<string, int[]> Mathias3 = new Dictionary<string, int[]>
        {
            { "Row1", new int[] { 0, 13, 23, 30, 42, 0, 0, 0, 85 } },
            { "Row2", new int[] { 0, 0, 0, 31, 0, 58, 62, 73, 87 } },
            { "Row3", new int[] { 5, 19, 28, 0, 49, 0, 0, 0, 88 } }
        };

    Dictionary<string, int[]> Mathias4 = new Dictionary<string, int[]>
        {
            { "Row1", new int[] {0, 0, 0, 30, 46, 50, 60, 70, 0 } },
            { "Row2", new int[] {0, 12, 23, 33,48, 0, 0, 76, 0 } },
            { "Row3", new int[] {9, 0, 26, 0, 0, 56, 0, 79, 89 } }
        };

    Dictionary<string, int[]> Mathias5 = new Dictionary<string, int[]>
        {
            { "Row1", new int[] { 1, 11, 0, 36, 0, 0, 60, 71, 0 } },
            { "Row2", new int[] { 2, 0, 0,0, 46, 0, 64, 73, 85 } },
            { "Row3", new int[] { 0, 0, 28, 0, 39, 48, 59, 0, 0, 88 } }
        };

    bankoPlates.Add("Mathias1", Mathias1);
    bankoPlates.Add("Mathias2", Mathias2);
    bankoPlates.Add("Mathias3", Mathias3);
    bankoPlates.Add("Mathias4", Mathias4);
    bankoPlates.Add("Mathias5", Mathias5);
}


bool continueGame = true;
int CheckRows(Dictionary<string, int[]> plate)
{
    int correctRows = 0;

    foreach (var row in plate)
    {
        if (row.Value.All(val => val == 0)) // Changed from "X" to 0
        {
            correctRows++;
        }
    }

    return correctRows;
}

CreateBankoPlates();

while (continueGame)
{

    void PrintPlates()
    {
        foreach (var plate in bankoPlates)
        {
            Console.WriteLine($"Plate: {plate.Key}");
            foreach (var row in plate.Value)
            {
                var formattedRow = row.Value.Select(val => val == 0 ? " " : val.ToString());
                Console.WriteLine($"{row.Key}: {string.Join(" | ", formattedRow)}");
            }
            Console.WriteLine();
        }
    }

    PrintPlates();

    while (continueGame)
    {
        // Check player input
        Console.WriteLine("Enter a number (or 'quit' to stop):");
        string playerInput = Console.ReadLine() ?? "";

        if (playerInput.ToLower() == "quit")
        {
            continueGame = false;
            break;
        }

        bool numberFound = false;
        foreach (var outerPlate in bankoPlates)
        {
            foreach (var row in outerPlate.Value)
            {
                for (int i = 0; i < row.Value.Length; i++)
                {
                    if (row.Value[i] == int.Parse(playerInput)) // Parse playerInput to int
                    {
                        row.Value[i] = 0; // Mark the found number with 0
                        numberFound = true;
                        Console.WriteLine($"Number found and marked in {outerPlate.Key} on {row.Key}");
                        break;
                    }
                }

                if (numberFound)
                {
                    break;
                }
            }

            if (numberFound)
            {
                break;
            }
        }

        if (!numberFound)
        {
            Console.WriteLine("Number not found in any row.");
        }

        // Call the CheckRows function here, after processing the player's input
        foreach (var outerPlate in bankoPlates)
        {
            int correctRows = CheckRows(outerPlate.Value);
            if (correctRows == 1)
            {
                Console.WriteLine($"1 row correct in {outerPlate.Key}!");
            }
            else if (correctRows == 2)
            {
                Console.WriteLine($"2 rows correct in {outerPlate.Key}!");
            }
            else if (correctRows == 3)
            {
                Console.WriteLine($"Banko! All rows are correct in {outerPlate.Key}!");
                continueGame = false; // End the game if all rows are correct
                break;
            }
        }

        PrintPlates(); // Print the plates after each round
    }
}
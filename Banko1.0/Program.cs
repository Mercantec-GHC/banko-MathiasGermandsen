// Declare dictionaries to store the current and original state of the banko plates
Dictionary<string, Dictionary<string, string[]>> bankoPlates = new Dictionary<string, Dictionary<string, string[]>>();
Dictionary<string, Dictionary<string, string[]>> originalBankoPlates = new Dictionary<string, Dictionary<string, string[]>>();

//method to initialize banko plates
void CreateBankoPlates()
{
    Dictionary<string, string[]> Mathias1 = new Dictionary<string, string[]>
    {
        { "Row1", new string[] { "0", "0", "20", "32", "42", "0", "67", "74", "0" } },
        { "Row2", new string[] { "8", "17", "23", "0", "0", "55", "0", "0", "86" } },
        { "Row3", new string[] { "9", "19", "0", "0", "47", "56", "0", "78", "0" } }
    };

    Dictionary<string, string[]> Mathias2 = new Dictionary<string, string[]>
    {
        { "Row1", new string[] { "1", "12", "0", "31", "0", "0", "60", "0", "81" } },
        { "Row2", new string[] { "5", "0", "0", "35", "45", "54", "63", "0", "0" } },
        { "Row3", new string[] { "0", "0", "25", "37", "0", "56", "0", "78", "90" } }
    };

    Dictionary<string, string[]> Mathias3 = new Dictionary<string, string[]>
    {
        { "Row1", new string[] { "0", "13", "23", "30", "42", "0", "0", "0", "85" } },
        { "Row2", new string[] { "0", "0", "0", "31", "0", "58", "62", "73", "87" } },
        { "Row3", new string[] { "5", "19", "28", "0", "49", "0", "0", "0", "88" } }
    };

    Dictionary<string, string[]> Mathias4 = new Dictionary<string, string[]>
    {
        { "Row1", new string[] { "0", "0", "0", "30", "46", "50", "60", "70", "0" } },
        { "Row2", new string[] { "0", "12", "23", "33", "48", "0", "0", "76", "0" } },
        { "Row3", new string[] { "9", "0", "26", "0", "0", "56", "0", "79", "89" } }
    };

    Dictionary<string, string[]> Mathias5 = new Dictionary<string, string[]>
    {
        { "Row1", new string[] { "1", "11", "0", "36", "0", "0", "60", "71", "0" } },
        { "Row2", new string[] { "2", "0", "0", "0", "46", "0", "64", "73", "85" } },
        { "Row3", new string[] { "0", "0", "28", "0", "39", "48", "59", "0", "0", "88" } }
    };

    bankoPlates.Add("Mathias1", Mathias1);
    bankoPlates.Add("Mathias2", Mathias2);
    bankoPlates.Add("Mathias3", Mathias3);
    bankoPlates.Add("Mathias4", Mathias4);
    bankoPlates.Add("Mathias5", Mathias5);

    foreach (var plate in bankoPlates)
    {
        originalBankoPlates[plate.Key] = new Dictionary<string, string[]>();
        foreach (var row in plate.Value)
        {
            originalBankoPlates[plate.Key][row.Key] = (string[])row.Value.Clone();
        }
    }
}



bool continueGame = true;

List<string> CheckRows(Dictionary<string, string[]> plate)
{
    List<string> correctRows = new List<string>();

    foreach (var row in plate)
    {
        if (row.Value.All(val => val == "X"))
        {
            correctRows.Add(row.Key);
        }
    }

    return correctRows;
}

foreach (var plate in bankoPlates)
{
    originalBankoPlates[plate.Key] = new Dictionary<string, string[]>();
    foreach (var row in plate.Value)
    {
        originalBankoPlates[plate.Key][row.Key] = (string[])row.Value.Clone();
    }
}
//method to run the game
void PlayGame()
{
    CreateBankoPlates();

    while (continueGame)
    {
        Console.WriteLine("Enter a number (or 'quit' to stop):");
        string playerInput = Console.ReadLine() ?? "";

        if (playerInput.ToLower() == "quit")
        {
            continueGame = false;
            break;
        }

        foreach (var plate in bankoPlates)
        {
            foreach (var row in plate.Value)
            {
                for (int i = 0; i < row.Value.Length; i++)
                {
                    if (row.Value[i] == playerInput)
                    {
                        row.Value[i] = "X";
                        Console.WriteLine($"Number found and marked in {plate.Key} on {row.Key}");
                    }
                }

                // If the row is correct after marking the number, print it
                if (row.Value.All(val => val == "X"))
                {
                    string[] originalRow = originalBankoPlates[plate.Key][row.Key];
                    string originalNumbers = string.Join(", ", originalRow.Where(val => val != "0"));
                    Console.WriteLine($"{plate.Key} {row.Key} is correct with the following numbers: {originalNumbers}");
                }
            }

            // If all numbers on a plate are marked, print the original numbers
            if (plate.Value.Values.All(row => row.All(val => val == "X")))
            {
                var originalPlate = originalBankoPlates[plate.Key];
                Console.WriteLine($"All numbers on {plate.Key} are correct:");
                foreach (var row in originalPlate)
                {
                    string originalNumbers = string.Join(" | ", row.Value.Where(val => val != "0"));
                    Console.WriteLine($"{row.Key}: {originalNumbers}");
                }
            }
        }
    }
}

//start game
PlayGame();
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
        { "Row3", new string[] { "0", "0", "28", "39", "48", "59", "0", "0", "88" } }
    };
    Dictionary<string, string[]> Mathias6 = new Dictionary<string, string[]>
    {
        { "Row1", new string[] { "1", "12", "22", "0", "0", "51", "0", "70", "0" } },
        { "Row2", new string[] { "7", "0", "0", "35", "0", "57", "0", "73", "84" } },
        { "Row3", new string[] { "0", "16", "0", "37", "47", "59", "68", "0", "0" } }
    };

    Dictionary<string, string[]> Mathias7 = new Dictionary<string, string[]>
    {
        { "Row1", new string[] { "0", "0", "20", "32", "0", "55", "0", "73", "83" } },
        { "Row2", new string[] { "0", "18", "27", "36", "0", "0", "68", "0", "87" } },
        { "Row3", new string[] { "4", "0", "27", "37", "47", "0", "0", "0", "89" } }
    };

    Dictionary<string, string[]> Mathias8 = new Dictionary<string, string[]>
    {
        { "Row1", new string[] { "3", "13", "22", "0", "41", "0", "60", "0", "0" } },
        { "Row2", new string[] { "4", "17", "0", "35", "0", "0", "0", "78", "88" } },
        { "Row3", new string[] { "5", "0", "28", "39", "0", "58", "0", "79", "0" } }
    };

    Dictionary<string, string[]> Mathias9 = new Dictionary<string, string[]>
    {
        { "Row1", new string[] { "5", "10", "20", "30", "0", "0", "0", "70", "0" } },
        { "Row2", new string[] { "0", "0", "24", "31", "0", "0", "65", "76", "88" } },
        { "Row3", new string[] { "9", "0", "0", "0", "48", "53", "0", "77", "89" } }
    };

    Dictionary<string, string[]> Mathias10 = new Dictionary<string, string[]>
{
   { "Row1", new string[] { "10", "43", "54", "70", "81" } },
   { "Row2", new string[] { "2", "11", "34", "64", "89" } },
   { "Row3", new string[] { "9", "25", "68", "78", "90" } }
};
    Dictionary<string, string[]> Mathias11 = new Dictionary<string, string[]>
{
    { "Row1", new string[] { "4", "22", "42", "60", "72" } },
    { "Row2", new string[] { "5", "35", "45", "64", "78" } },
    { "Row3", new string[] { "18", "25", "55", "66", "87" } }
};
    Dictionary<string, string[]> Mathias12 = new Dictionary<string, string[]>
{
    { "Row1", new string[] { "24", "43", "64", "75", "82" } },
    { "Row2", new string[] { "16", "25", "35", "55", "78" } },
    { "Row3", new string[] { "9", "18", "26", "67", "88" } }
};

    Dictionary<string, string[]> Mathias13 = new Dictionary<string, string[]>
{
    { "Row1", new string[] { "12", "20", "46", "60", "81" } },
    { "Row2", new string[] { "17", "37", "54", "76", "82" } },
    { "Row3", new string[] { "5", "19", "27", "39", "59" } }
};

    bankoPlates.Add("Mathias1", Mathias1);
    bankoPlates.Add("Mathias2", Mathias2);
    bankoPlates.Add("Mathias3", Mathias3);
    bankoPlates.Add("Mathias4", Mathias4);
    bankoPlates.Add("Mathias5", Mathias5);
    bankoPlates.Add("Mathias6", Mathias6);
    bankoPlates.Add("Mathias7", Mathias7);
    bankoPlates.Add("Mathias8", Mathias8);
    bankoPlates.Add("Mathias9", Mathias9);
    bankoPlates.Add("Mathias10", Mathias10);
    bankoPlates.Add("Mathias11", Mathias11);
    bankoPlates.Add("Mathias12", Mathias12);
    bankoPlates.Add("Mathias13", Mathias13);
    bankoPlates.Add("Mathias14", Mathias14);
    bankoPlates.Add("Mathias15", Mathias15);
    bankoPlates.Add("Mathias16", Mathias16);
    bankoPlates.Add("Mathias17", Mathias17);
    bankoPlates.Add("Mathias18", Mathias18);
    bankoPlates.Add("Mathias19", Mathias19);
    bankoPlates.Add("Mathias20", Mathias20);
    bankoPlates.Add("Mathias21", Mathias21);
    bankoPlates.Add("Mathias22", Mathias22);
    bankoPlates.Add("Mathias23", Mathias23);
    bankoPlates.Add("Mathias24", Mathias24);
    bankoPlates.Add("Mathias25", Mathias25);
    bankoPlates.Add("Mathias26", Mathias26);
    bankoPlates.Add("Mathias27", Mathias27);
    bankoPlates.Add("Mathias28", Mathias28);
    bankoPlates.Add("Mathias29", Mathias29);
    bankoPlates.Add("Mathias30", Mathias30);
    bankoPlates.Add("Mathias31", Mathias31);
    bankoPlates.Add("Mathias32", Mathias32);
    bankoPlates.Add("Mathias33", Mathias33);
    bankoPlates.Add("Mathias34", Mathias34);
    bankoPlates.Add("Mathias35", Mathias35);
    bankoPlates.Add("Mathias36", Mathias36);



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
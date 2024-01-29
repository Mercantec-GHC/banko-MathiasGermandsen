var game = new BankoGame();
game.AddPlate(new BankoPlate("Mathias1", new Dictionary<string, string[]>
{
    { "Row1", new string[] { "20", "32", "42", "67", "74" } },
    { "Row2", new string[] { "8", "17", "23", "55", "86" } },
    { "Row3", new string[] { "9", "19", "47", "56", "78" } }
}));

// Usage

game.PlayGame();
// Add more plates...
class BankoPlate
{
    public string Name { get; set; }
    public Dictionary<string, string[]> Rows { get; set; }

    public BankoPlate(string name, Dictionary<string, string[]> rows)
    {
        Name = name;
        Rows = rows;
    }
}

class BankoGame
{
    private List<BankoPlate> Plates { get; set; }
    private bool ContinueGame { get; set; }

    public BankoGame()
    {
        Plates = new List<BankoPlate>();
        ContinueGame = true;
    }

    public void AddPlate(BankoPlate plate)
    {
        Plates.Add(plate);
    }

    public void PlayGame()
    {
        while (ContinueGame)
        {
            Console.WriteLine("Enter a number (or 'quit'):");
            string playerInput = Console.ReadLine() ?? "";

            if (playerInput.ToLower() == "quit")
            {
                ContinueGame = false;
                break;
            }

            foreach (var plate in Plates)
            {
                foreach (var row in plate.Rows)
                {
                    for (int i = 0; i < row.Value.Length; i++)
                    {
                        if (row.Value[i] == playerInput)
                        {
                            row.Value[i] = "X";
                            Console.WriteLine($"Number found and marked in {plate.Name} on {row.Key}");
                        }
                    }

                    // If the row is correct after marking the number, print it
                    if (row.Value.All(val => val == "X"))
                    {
                        string originalNumbers = string.Join(", ", row.Value.Where(val => val != "0"));
                        Console.WriteLine($"{plate.Name} {row.Key} is correct with the following numbers: {originalNumbers}");
                    }
                }

                // If all numbers on a plate are marked, print the original numbers
                if (plate.Rows.Values.All(row => row.All(val => val == "X")))
                {
                    Console.WriteLine($"All numbers on {plate.Name} are correct:");
                    foreach (var row in plate.Rows)
                    {
                        string originalNumbers = string.Join(" | ", row.Value.Where(val => val != "0"));
                        Console.WriteLine($"{row.Key}: {originalNumbers}");
                    }
                }
            }
        }
    }
}


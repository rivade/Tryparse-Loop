List<int> numbers = new();

Console.WriteLine("Hur många nummer vill du hitta ett genomsnitt av? ");
string antalStr = Console.ReadLine();
bool success = int.TryParse(antalStr, out int antalInt);

while (!success || antalInt < 1)
{
    Console.WriteLine("Du måste skriva en siffra (heltal)");
    Console.WriteLine("Hur många nummer vill du hitta ett genomsnitt av? ");
    antalStr = Console.ReadLine();
    success = int.TryParse(antalStr, out antalInt);
}

for (var i = 0; i < antalInt; i++)
{
    Console.WriteLine($"Nummer {i + 1}: ");
    string listAddString = Console.ReadLine();
    bool listAddSuccess = int.TryParse(listAddString, out int listAddInt);
    while (!listAddSuccess)
    {
        Console.WriteLine("Du måste skriva en siffra (heltal)");
        Console.WriteLine($"Nummer {i + 1}: ");
        listAddString = Console.ReadLine();
        listAddSuccess = int.TryParse(listAddString, out listAddInt);
    }
    numbers.Add(listAddInt);
}

Console.WriteLine($"Genomsnittet av dina siffror är {numbers.Average()}");
Console.ReadLine();
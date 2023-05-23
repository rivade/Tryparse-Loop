List<float> numbers = new();

Console.WriteLine("Hur många nummer vill du hitta ett genomsnitt av? ");
string antalStr = Console.ReadLine();
bool success = int.TryParse(antalStr, out int antalInt);

while (!success || antalInt < 1)
{
    Console.WriteLine("Du måste skriva en siffra (heltal) som är större än 0");
    Console.WriteLine("Hur många nummer vill du hitta ett genomsnitt av? ");
    antalStr = Console.ReadLine();
    success = int.TryParse(antalStr, out antalInt);
}

for (var i = 0; i < antalInt; i++)
{
    Console.WriteLine($"Nummer {i + 1}: ");
    string listAddString = Console.ReadLine();
    bool listAddSuccess = float.TryParse(listAddString, out float listAddFloat);
    while (!listAddSuccess)
    {
        Console.WriteLine("Du måste skriva en siffra (vid decimaltal, formatera såhär: 7,5)");
        Console.WriteLine($"Nummer {i + 1}: ");
        listAddString = Console.ReadLine();
        listAddSuccess = float.TryParse(listAddString, out listAddFloat);
    }
    numbers.Add(listAddFloat);
}

Console.WriteLine($"Genomsnittet av dina siffror är {numbers.Average()}");
Console.ReadLine();


List<string> firstNames = new List<string>();
firstNames.Add("Héctor");
firstNames.Add("Manuel");
firstNames.Add("Ricardo");
firstNames.Add("Nicolás");
foreach (string name in firstNames)
{
    Console.WriteLine($"Hola {name}");
}

Dictionary<int, string> importantYears = new Dictionary<int, string>();

importantYears.Add(1492, "Columbus arrives in Central America.");
importantYears.Add(1969, "Man walks on the Moon.");
importantYears.Add(1975, "Héctor is Born.");

foreach (var year in importantYears)
{
    Console.WriteLine($"{year.Key}: {year.Value}");
}

List<string> nombres = new List<string>();
string continua = "";
do
{
    Console.Write("Name: ");
    nombres.Add(Console.ReadLine());
    Console.Write("Continúa S/N: ");
    continua = Console.ReadLine();
} while (continua.ToLower() != "n");

foreach (string nombre in nombres)
{
    Console.WriteLine($"Hola {nombre}");
}
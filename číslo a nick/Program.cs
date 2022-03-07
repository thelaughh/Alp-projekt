// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Dictionary<string, string> slovník = new Dictionary<string, string>();

for (int i=0;i<4; i++)
{
    Console.WriteLine("Zadej jméno uživatele");
    string Jmeno = Console.ReadLine();
    Console.WriteLine("Zadej cislo uživatele");
    Console.WriteLine("Číslo musí být dlouhé jen 9 znaků");
    string Cislo = Console.ReadLine();
    slovník.Add(Jmeno, Cislo);
}
foreach (var radekSlovniku in slovník)
{
    Console.WriteLine($"Jméno:{radekSlovniku.Key}, Tel.Číslo: {radekSlovniku.Value}");

}

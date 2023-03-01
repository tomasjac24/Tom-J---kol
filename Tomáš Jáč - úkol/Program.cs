//Vypíše od 1 do 100 kromě 40 a 60
for (int i = 1; i <= 100; i++)
{
    if (i == 40) continue;
    if (i == 60) continue;
    Console.WriteLine(i);
}

//Obdelník z * který je velký 15x10
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 15; j++) Console.Write("* "); 
    Console.Write("\n");
}

//Vypíše počet zadaných čísel
Console.Write("Zadej čísla: ");
string input = Console.ReadLine();
string[] cisla = input.Split(',');
if (cisla[0] == "")
{
    Console.WriteLine("Počet čísel je: 0");
}
else
{
Console.WriteLine($"\nPočet čísel je: {cisla.Length}");
Console.ResetColor();
}
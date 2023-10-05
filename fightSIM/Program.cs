using System;

int aHp = 100;
int bHp = 100;

string k1Name = "a";
string k2Name = "b";

Random generator = new Random();

while (aHp > 0 && bHp > 0)
{
    Console.WriteLine("\n-----===== NY RUNDA =====-----");
    Console.WriteLine($"{k1Name}: {aHp}  {k2Name}: {bHp}\n");



int aDamage = generator.Next(20);
bHp -= aDamage;
bHp = Math.Max(0, bHp);
Console.WriteLine($"{k1Name} gör {aDamage} skada på {k2Name}");

int bDamage = generator.Next(20);
aHp -= bDamage;
aHp = Math.Max(0, bHp);
Console.WriteLine($"{k2Name} gör {bDamage} skada på {k1Name}");

Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
  Console.ReadKey();

}

Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");

if (aHp == 0 && bHp == 0)
{
  Console.WriteLine("OAVGJORT");
}
else if (aHp == 0)
{
  Console.WriteLine($"{k2Name} vann!");
}
else
{
  Console.WriteLine($"{k1Name} vann!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();





using System;

string[] names = { "King Kochar", "Sarah Bowling", "John Smith", "Roger Lee", "James Lee" };

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine();

// Cuidado para evitar o erro de "IndexOutOfRangeException"
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

Console.ReadKey();
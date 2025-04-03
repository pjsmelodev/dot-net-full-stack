using System;
using System.Text;

string str1 = "Hello World";
string str2 = "C# Programming";

Console.WriteLine(str1);
Console.WriteLine(str1.Length);
Console.WriteLine(str1.Concat(str2));
Console.WriteLine(str1.Equals(str2));

// Immutable String

string s1 = "C++ Programming";
string s2 = "Java Programming";

// Mutable String

StringBuilder stringBuilder = new StringBuilder();

stringBuilder.Append("C++ Programming");
stringBuilder.Append("Java Programming");

Console.WriteLine(stringBuilder.ToString());

Console.ReadKey();
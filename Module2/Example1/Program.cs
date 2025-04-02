using System;

float baseSalary = 50000;
float hra = 0.3F;

float netSalary = (baseSalary - (baseSalary * hra));

Console.WriteLine("Base salary: " + baseSalary);
Console.WriteLine("Net salary: " + netSalary);

Console.Write("Enter the temperature: ");
int temperature = int.Parse(Console.ReadLine());

if (temperature <= 20)
{
    Console.WriteLine("It's cold outside.");
}
else
{
    Console.WriteLine("It's moderate outside.");
}

bool isLoogedIn = true;
bool isEmailVerified = true;
bool cardInfo = true;

if (isLoogedIn && isEmailVerified && cardInfo)
{
    Console.WriteLine("Allowed to make a purchase.");
}
else
{
    Console.WriteLine("Stop purchase.");
}

Console.ReadKey();
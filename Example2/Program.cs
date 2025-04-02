using System;
using System.Diagnostics;

bool isAuthenticated = true;

if (isAuthenticated)
{
    Console.WriteLine("You are logged in.");
}
else
{
    Console.WriteLine("You are not logged in.");
}

string result = isAuthenticated ? "You are logged in." : "You are not logged in.";
Console.WriteLine(result);

int temperature = 50;
if (temperature < 20)
{
    Console.WriteLine("It's very cold outside.");
}
else if (temperature >= 20 && temperature <= 50)
{
    Console.WriteLine("It's moderate outside.");
}
else
{
    Console.WriteLine("It's too hot outside.");
}

string userType = "admin";

switch(userType)
{
    case "admin":
        Console.WriteLine("You have full access.");
        break;
    case "subadmin":
        Console.WriteLine("You partial access.");
        break;
    case "user":
        Console.WriteLine("You can access courses.");
        break;
    default:
        Console.WriteLine("You do not have access.");
        break;
}

Console.ReadKey();

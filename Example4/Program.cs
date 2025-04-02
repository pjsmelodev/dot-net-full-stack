using System;

//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//    {
//        break;
//    }

//    Console.WriteLine("Hello, World! " + i);
//}

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        continue;
    }

    Console.WriteLine("Hello, World! " + i);
}

Console.WriteLine();

string userType = "admin";

switch (userType)
{
    case "admin":
        Console.WriteLine("You are an admin.");
        goto case "user";
    case "subadmin":
        Console.WriteLine("You are a subadmin.");
        break;
    case "user":
        Console.WriteLine("You are a user.");
        break;
    default:
        Console.WriteLine("Invalid user type.");
        break;
}

Console.ReadKey();
using System;

int[] marks = new int[5];
marks[0] = 25;
marks[1] = 50;
marks[2] = 55;
marks[3] = 60;
marks[4] = 40;

foreach (int mark in marks)
{
    Console.WriteLine(mark);
}

int[,] multiArray = new int[3, 4] { {1, 2, 3, 4 }, {1, 2, 3, 4 }, {1, 2, 3, 4 } };

Console.ReadKey();
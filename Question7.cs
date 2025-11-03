using System;
using System.Collections.Generic;
using System.Globalization;

public class Question7
{
    List<(int, int, int)> ariTime = new List<(int, int, int)>();
    public void Run()
    {
        for (int h = 0; h <= 23; h++)
        {
            for (int m = 0; m <= 59; m++)
            {
                for (int s = 0; s <= 59; s++)
                {
                    if ((m - h) == (s - m))
                    {
                        Console.WriteLine(h + ":" + m + ":" + s);
                        ariTime.Add((h, m, s));
                    }
                }
            }
        }

        Console.WriteLine(ariTime.Count());

        

    }
}

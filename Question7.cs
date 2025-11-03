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
                    if (((m - h) == (s - m)) && ((m - h) != 0) && ((s - m) != 0))
                    {
                        Console.WriteLine(h + ":" + m + ":" + s);
                        ariTime.Add((h, m, s));
                    }
                }
            }
        }

        //ariTime.RemoveAt(0);
        Console.WriteLine(ariTime.Count());

        double minangle = 10000000000000;

        foreach ((int, int, int) time in ariTime)
        {
            double barS = ((double)time.Item3 / 60) * 360; 
            double barM = (((double)time.Item2 / 60) * 360) + ((barS / 360) * 6); // 6 degree per min

            double barH = ((double)time.Item1 / 12) * 360 + ((barM / 360) * 30); // 30 degree per hour
            if (time.Item1 >= 12)
            {
                barH = (((double)time.Item1 - 12) / 12) * 360 + ((barM / 360) * 30);
            }

            double alpha = Math.Abs(barH - barM);
            double beta = Math.Abs(barM - barS);
            double gamma = Math.Abs(barS - barH);

            if (alpha > 180)
            {
                alpha = 360 - alpha;
            }

            if (beta > 180)
            {
                beta = 360 - beta;
            }

            if (gamma > 180)
            {
                gamma = 360 - gamma;
            }

            if ((alpha + beta + gamma) < minangle)
            {
                minangle = alpha + beta + gamma;
                Console.WriteLine(time.Item1 + ":" + time.Item2 + ":" + time.Item3);
                Console.WriteLine(minangle);
            }

        }

        Console.WriteLine("minimum value: " + minangle);

    }
}

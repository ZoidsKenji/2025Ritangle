using System;
using System.Collections.Generic;
using System.Globalization;

public class Week3
{
    public List<float> dice = new List<float>();
    public float count = 0;
    public void run()
    {

        for (int i = 11111; i < 666666; i++)
        {
            if (!i.ToString().Contains("0"))
            {
                count += 1;
            }
            if (i % 25 == 0 && !i.ToString().Contains("0"))
            {
                dice.Add(i);
            }
        }

        Console.WriteLine(dice.Count / count);
    }
}
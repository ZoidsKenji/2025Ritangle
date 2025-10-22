using System;
using System.Collections.Generic;
using System.Globalization;

public class Week3
{
    public List<int> dice = new List<int>();
    public float count = 0;

    public bool compareList(List<int> list1, List<int> list2)
    {
        if (list1.Count != list2.Count)
        {
            return false;
        }
        else
        {
            list1.Sort();
            list2.Sort();
            if (list1 != list2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    public void run()
    {

        for (int i = 11111; i <= 66666; i++)
        {
            if (!(i.ToString().Contains("0") || i.ToString().Contains("7") || i.ToString().Contains("8") || i.ToString().Contains("9")))
            {
                count += 1;

                if (i.ToString().Contains("2") && i.ToString().Contains("5"))
                {
                    dice.Add(i);
                }
            }

        }

        Console.WriteLine(dice.Count / count);


    }
}
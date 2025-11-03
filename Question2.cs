using System;
using System.Collections.Generic;
using System.Globalization;

public class Question2
{
    public char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    public List<string> combo = new List<string>();
    public string text = "RITANGLE";
    public List<string> textcomb = new List<string>();

    public void run()
    {
        Random random = new Random();

        while (combo.Count > (8 * 7 * 6 * 5 * 4 * 3 * 2))
        {
            char[] newtext;
            char[] texttemp = text.ToCharArray();
            while (texttemp.Count() > 0)
            {
                int rand = random.Next(0, texttemp.Count() - 1);
                char addtext = texttemp[rand];
                //newtext.Concat(new[] { newtext }).ToArray();
            }

        }
    }
}
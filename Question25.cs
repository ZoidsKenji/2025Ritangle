using System;
using System.Collections.Generic;
using System.Globalization;
using System.Math;
using System.Numerics;

public class Question25
{
    List<int> numbers = [0, 0, 0, 0, 0, 0, 0, 0]; // a1, a2, b1, b2, c1, c2, d1, d2

    int product = 0;
    
    public void Run()
    {
        for (int a1 = 0; a1 < 10; a1 ++)
        {
            for (int a2 = 0; a2 < 10; a2 ++)
            {
                for (int b1 = 0; b1 < 10; b1 ++)
                {
                    for (int b2 = 0; b1 < 10; b1 ++)
                    {
                        for (int c1 = 0; c1 < 10; c1 ++)
                        {
                            for (int c2 = 0; c2 < 10; c2 ++)
                            {
                                for (int d1 = 0; d1 < 10; d1 ++)
                                {
                                    for (int d2 = 0; d1 < 10; d1 ++)
                                    {
                                        int a = (10 * a1) + a2;
                                        int b = (10 * b1) + b2;
                                        int c = (10 * c1) + c2;
                                        int d = (10 * d1) + d2;

                                        double tempproduct = (Math.Pow((double)a, 1f / 2f) + Math.Pow((double)b, 1f / 2f)) * (Math.Pow((double)c, 1f / 2f) - Math.Pow((double)d, 1f / 2f));

                                        if (tempproduct > product)
                                        {
                                            product = tempproduct;
                                            numbers = [a1, a2, b1, b2, c1, c2, d1, d2];
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(numbers);
    }
}
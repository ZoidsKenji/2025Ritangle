using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

public class Question25
{
    List<int> numbers = [0, 0, 0, 0, 0, 0, 0, 0]; // a1, a2, b1, b2, c1, c2, d1, d2

    double product = 0;
    
    public void Run()
    {
        for (int a1 = 0; a1 < 10; a1 ++)
        {
            for (int a2 = 0; a2 < 10; a2 ++)
            {
                for (int b1 = 0; b1 < 10; b1 ++)
                {
                    for (int b2 = 0; b2 < 10; b2 ++)
                    {
                        for (int c1 = 0; c1 < 10; c1 ++)
                        {
                            for (int c2 = 0; c2 < 10; c2 ++)
                            {
                                for (int d1 = 0; d1 < 10; d1 ++)
                                {
                                    for (int d2 = 0; d2 < 10; d2 ++)
                                    {
                                        int a = (10 * a1) + a2;
                                        int b = (10 * b1) + b2;
                                        int c = (10 * c1) + c2;
                                        int d = (10 * d1) + d2;

                                        double tempproduct = (Math.Pow((double)a, 1f / 2f) + Math.Pow((double)b, 1f / 2f)) * (Math.Pow((double)c, 1f / 2f) - Math.Pow((double)d, 1f / 2f));

                                        bool a1different = (a1 != a2) && (a1 != b1) && (a1 != b2) && (a1 != c1) && (a1 != c2) && (a1 != d1) && (a1 != d2);
                                        bool a2different = (a2 != b1) && (a2 != b2) && (a2 != c1) && (a2 != c2) && (a2 != d1) && (a2 != d2);
                                        bool b1different = (b1 != b2) && (b1 != c1) && (b1 != c2) && (b1 != d1) && (b1 != d2);
                                        bool b2different = (b2 != c1) && (b2 != c2) && (b2 != d1) && (b2 != d2);
                                        bool c1different = (c1 != c2) && (c1 != d1) && (c1 != d2);
                                        bool c2different = (c2 != d1) && (c2 != d2);
                                        bool d1different = d1 != d2;

                                        bool alldiff = a1different && a2different && b1different && b2different && c1different && c2different && d1different;
                                        //Console.WriteLine(alldiff);

                                        if ((tempproduct > product) && alldiff)
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

        Console.WriteLine(product);
        Console.WriteLine(numbers[0] + " " + numbers[1]+ " " + numbers[2]+ " " + numbers[3]+ " " + numbers[4]+ " " + numbers[5]+ " " + numbers[6]+ " " + numbers[7]);
    }
}
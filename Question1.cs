using System;
using System.Collections.Generic;
using System.Globalization;

public class Question1
{
    public List<int> cogL = new List<int>();
    public List<int> cogM = new List<int>();
    public List<int> cogR = new List<int>();
    public List<int> numberS = new List<int>();
    public List<int> numberT = new List<int>();

    public double difAngleL;
    public double difAngleM;
    public double difAngleR;

    public (double, double, double) gearRatio = (1.375, 1.0, 1.2222);

    public void Run()
    {
        for (int i = 1; i <= 8; i++) cogL.Add(i);
        for (int i = 10; i <= 20; i++) cogM.Add(i);
        for (int i = 1; i <= 9; i++) cogR.Add(i);

        difAngleL = 360.0 / cogL.Count;
        difAngleM = 360.0 / cogM.Count;
        difAngleR = 360.0 / cogR.Count;

        int leftIndex = 0, midIndex = 0, rightIndex = 0;
        double angleL = 0, angleM = 0, angleR = 0;
        double step = 1.0; // how much the middle gear rotates per tick

        while (numberS.Count < 792)
        {
            angleM += step;
            angleL += gearRatio.Item1 * step;
            angleR += gearRatio.Item3 * step;

            if (angleL >= difAngleL)
            {
                angleL -= difAngleL;
                leftIndex = (leftIndex + 1) % cogL.Count;
            }
            if (angleM >= difAngleM)
            {
                angleM -= difAngleM;
                midIndex = (midIndex + 1) % cogM.Count;
            }
            if (angleR >= difAngleR)
            {
                angleR -= difAngleR;
                rightIndex = (rightIndex + 1) % cogR.Count;
            }

            int combo = int.Parse($"{cogL[leftIndex]}{cogM[midIndex]}{cogR[rightIndex]}");
            int tnum = cogL[leftIndex] * cogR[rightIndex] * cogM[midIndex];

            if (!numberS.Contains(combo))
            {
                numberS.Add(combo);
                numberT.Add(tnum);
                Console.WriteLine(combo);
            }
        }

        Console.WriteLine("Number count: " + numberS.Count);

        float numS = 0;
        foreach (float num in numberS)
        {
            numS += num;
        }
        Console.WriteLine("Number sum: " + numS);

        float numT = 0;
        foreach (float num in numberT)
        {
            numT += num;
        }
        Console.WriteLine("Number T: " + numT);

        Console.WriteLine("S/T: " + (numS / numT));



    }
}

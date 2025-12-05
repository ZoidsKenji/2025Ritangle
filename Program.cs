using System;

class Program
{
    static void Main(string[] args)
    {
        Question1 q1 = new Question1();
        Question2 q2 = new Question2();
        Question3 q3 = new Question3();
        Question7 q7 = new Question7();
        Question25 q25 = new Question25();
        Console.Write("Pick qustion: ");
        int input = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        while (true)
        {
            if (input == 0)
            {
                Console.WriteLine("Error: question not found");
            }
            else if (input == 1)
            {
                q1.Run();
            }
            else if (input == 2)
            {
                Console.WriteLine("Warning: solution not finished");
                q2.run();

            }
            else if (input == 3)
            {
                q3.run();

            }
            else if (input == 7)
            {
                q7.Run();

            }
            else if (input == 25)
            {
                q25.Run();
            }
            else if (input < 7 && input > 3)
            {
                Console.WriteLine("didnt code it");

            }
            else
            {
                Console.WriteLine("Error: question not found");
            }
            
            Console.WriteLine();
            Console.Write("Pick qustion: ");
            input = int.TryParse(Console.ReadLine(), out result) ? result : 0;
        }

    }
}

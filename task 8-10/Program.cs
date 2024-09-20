using System;
using System.Drawing;
using task_8_10;

class Task
{
    static void Main()
    {
        Console.WriteLine("If you want see task from 8 - 10 just enter 8");
        Console.Write("Enter a task = ");
        int task = int.Parse(Console.ReadLine());
        Console.Write("Press enter to continue ...");

        Console.ReadKey();
        Console.Clear();

        switch (task)
        {
            case 4:
                Console.Write("Enter amount of strings = ");
                int size = int.Parse(Console.ReadLine());
                Line();

                Box<string> taskFour = new Box<string>();

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter {i + 1} string = ");
                    string sentence = Console.ReadLine();

                    taskFour.Add(sentence);

                }
                Console.Write("Enter first index = ");
                int firtsIndex = int.Parse(Console.ReadLine());
                Console.Write("Enter second index = ");
                int secondIndex = int.Parse(Console.ReadLine());

                taskFour.Swap(firtsIndex, secondIndex);
                Line();

                taskFour.Print();
                break;

            case 5:
                Console.Write("Enter amount of number = ");
                size = int.Parse(Console.ReadLine());
                Line();

                Box<int> taskFive = new Box<int>();

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter {i + 1} string = ");
                    int number = int.Parse(Console.ReadLine());

                    taskFive.Add(number);

                }
                Console.Write("Enter first index = ");
                firtsIndex = int.Parse(Console.ReadLine());
                Console.Write("Enter second index = ");
                secondIndex = int.Parse(Console.ReadLine());

                taskFive.Swap(firtsIndex, secondIndex);

                Line();
                taskFive.Print();
                break;

            case 6:
                Console.Write("Enter amount of sentences = ");
                size = int.Parse(Console.ReadLine());
                Line();

                Box<string> taskSix = new Box<string>();

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter {i + 1} string = ");
                    string sentence = Console.ReadLine();
                    taskSix.Add(sentence);
                }
                Console.Write("Enter with what we will compare = ");
                string value = Console.ReadLine();

                Line();
                Console.WriteLine($"Result = {taskSix.CountGreaterThen(value)}");
                break;

            case 7:
                Console.Write("Enter amount of numbers = ");
                size = int.Parse(Console.ReadLine());
                Line();
                Box<double> taskSeven = new Box<double>();

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter {i + 1} number = ");
                    double sentence = double.Parse(Console.ReadLine());
                    taskSeven.Add(sentence);
                }
                Console.Write("Enter with what we will compare = ");
                double element = double.Parse(Console.ReadLine());

                Line();
                Console.WriteLine($"Result = {taskSeven.CountGreaterThen(element)}");
                break;

            case 8:

                break;
        }
    }

    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}
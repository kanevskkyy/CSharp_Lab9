using System;
using task_1;

class Task
{
    static void Main()
    {
        Console.Write("Enter a task = ");
        int task = int.Parse(Console.ReadLine());
        Console.Write("Press enter to continue ...");
        
        Console.ReadKey();
        Console.Clear();

        switch (task)
        {
            case 1:
                Box<int> first = new Box<int>(123123);
                Console.WriteLine(first);

                Box<string> second = new Box<string>("life is good");
                Console.WriteLine(second);
                break;

            case 2:
                Console.Write("Enter amount of strings = ");
                int size = int.Parse(Console.ReadLine());
                Line();

                List<Box<string>> strings = new List<Box<string>>();

                for(int i = 0; i < size; i++)
                {
                    Console.Write($"Enter {i + 1} string = ");
                    string sentence = Console.ReadLine();

                    Box<string> box = new Box<string>(sentence);
                    strings.Add(box);
                }
                Line();

                for(int i = 0; i < strings.Count; i++)
                {
                    Console.WriteLine(strings[i]);
                }

                break;

            case 3:
                Console.Write("Enter amount of numbers = ");
                size = int.Parse(Console.ReadLine());
                Line();

                List<Box<int>> integer = new List<Box<int>>();

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter {i + 1} number = ");
                    int number = int.Parse(Console.ReadLine());

                    Box<int> box = new Box<int>(number);
                    integer.Add(box);
                }
                Line();

                for (int i = 0; i < integer.Count; i++)
                {
                    Console.WriteLine(integer[i]);
                }

                break;

            case 4:
                Console.Write("Enter amount of strings = ");
                size = int.Parse(Console.ReadLine());
                Line();

                Box<List<string>> taskFour = new Box<List<string>>(new List<string> { });

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter {i + 1} string = ");
                    string sentence = Console.ReadLine();

                    taskFour.Value.Add(sentence);

                }
                Console.Write("Enter first index = ");
                int firtsIndex = int.Parse(Console.ReadLine());
                Console.Write("Enter second index = ");
                int secondIndex = int.Parse(Console.ReadLine());

                taskFour.SwapElements(firtsIndex, secondIndex);
                Line();

                for (int i = 0; i < taskFour.Value.Count; i++)
                {
                    Console.WriteLine(taskFour.Value[i]);
                }
                break;

            case 5:
                Console.Write("Enter amount of number = ");
                size = int.Parse(Console.ReadLine());
                Line();

                Box<List<int>> taskFive = new Box<List<int>>(new List<int> { });

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter {i + 1} string = ");
                    int number = int.Parse(Console.ReadLine());

                    taskFive.Value.Add(number);

                }
                Console.Write("Enter first index = ");
                firtsIndex = int.Parse(Console.ReadLine());
                Console.Write("Enter second index = ");
                secondIndex = int.Parse(Console.ReadLine());

                taskFive.SwapElements(firtsIndex, secondIndex);

                Line();

                for (int i = 0; i < taskFive.Value.Count; i++)
                {
                    Console.WriteLine(taskFive.Value[i].ToString());
                }
                break;

            case 6:
                Console.Write("Enter amount of sentences = ");
                size = int.Parse(Console.ReadLine());
                Line();

                Box<List<string>> taskSix = new Box<List<string>>(new List<string> { });

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter {i + 1} string = ");
                    string sentence = Console.ReadLine();
                    taskSix.Value.Add(sentence);
                }
                Console.Write("Enter with what we will compare = ");
                string value = Console.ReadLine();

                Line();
                Console.WriteLine($"Result = {taskSix.CompareElements(value)}");
                break;

            case 7:
                Console.Write("Enter amount of numbers = ");
                size = int.Parse(Console.ReadLine());
                Line();

                Box<List<double>> taskSeven = new Box<List<double>>(new List<double> { });

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter {i + 1} number = ");
                    double sentence = double.Parse(Console.ReadLine());
                    taskSeven.Value.Add(sentence);
                }
                Console.Write("Enter with what we will compare = ");
                double element = double.Parse(Console.ReadLine());

                Line();
                Console.WriteLine($"Result = {taskSeven.CompareElements(element)}");
                break;
        }
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}
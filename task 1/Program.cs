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
                    Console.WriteLine(strings[i].ToString());
                }

                break;
        }

    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}
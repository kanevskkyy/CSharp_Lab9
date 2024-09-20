using System;
using task_1;

class Task
{
    static void Main()
    {
        Box<int> first = new Box<int>(123123);
        Console.WriteLine(first);

        Box<string> second = new Box<string>("life is good");
        Console.WriteLine(second);

    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}
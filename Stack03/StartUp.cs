﻿namespace Stack03
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToArray();

            Stack<string> stack = new Stack<string>();

            foreach (var item in data)
            {
                 stack.Push(item);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                switch (input)
                {
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    default:
                        string element = input.Split()[1];
                        stack.Push(element);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, stack));
            Console.WriteLine(string.Join(Environment.NewLine, stack));
        }
    }
}

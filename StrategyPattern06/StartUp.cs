namespace StrategyPattern06
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<Person> peopleByName = new SortedSet<Person>(new PersonByName());
            SortedSet<Person> peopleByAge = new SortedSet<Person>(new PersonByAge());

            while (n-- > 0)
            {
                string[] inputArgs = Console.ReadLine().Split();

                Person person = new Person(inputArgs[0], int.Parse(inputArgs[1]));

                peopleByName.Add(person);
                peopleByAge.Add(person);
            }

            Console.WriteLine(string.Join(Environment.NewLine, peopleByName));
            Console.WriteLine(string.Join(Environment.NewLine, peopleByAge));

        }
    }
}

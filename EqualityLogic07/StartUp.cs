namespace EqualityLogic07
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            HashSet<Person> peopleByHash = new HashSet<Person>();

            while (n-- > 0)
            {
                string[] inputArgs = Console.ReadLine().Split();

                Person person = new Person(inputArgs[0], int.Parse(inputArgs[1]));

                sortedPeople.Add(person);
                peopleByHash.Add(person);
            }

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(peopleByHash.Count);

        }
    }
}

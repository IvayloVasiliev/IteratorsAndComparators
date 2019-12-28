namespace StrategyPattern06
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    public class PersonByAge : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            return first.Age.CompareTo(second.Age);

        }
    }
}

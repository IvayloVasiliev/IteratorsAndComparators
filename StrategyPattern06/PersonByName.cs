﻿namespace StrategyPattern06
{
    using System.Collections.Generic;

    public class PersonByName : IComparer<Person>
    {
        public int Compare( Person first, Person second)
        {
            int result = first.Name.Length.CompareTo(second.Name.Length);

            if (result == 0)
            {
                char firstPersonLetter = char.ToLower(first.Name[0]);
                char secondPersonLetter = char.ToLower(second.Name[0]);

                result = firstPersonLetter.CompareTo(secondPersonLetter);
            }

            return result;
        }
    }
}

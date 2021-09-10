using System;
using System.Collections.Generic;

namespace Assignment1
{
    public static class Iterators
    {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            foreach (IEnumerable<T> item in items)
            {
                foreach (T i in item)
                {
                    yield return i;
                }

            }
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            throw new NotImplementedException();
        }
    }
}

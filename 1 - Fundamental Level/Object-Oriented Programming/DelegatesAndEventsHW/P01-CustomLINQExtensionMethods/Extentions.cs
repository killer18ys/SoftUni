using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_CustomLINQExtensionMethods
{
    public static class Extentions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Predicate<T> predicate )
        {
            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    yield return element;
                }
            }
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection,
           Func<TSource, TSelector> func) where TSelector : IComparable
        {
            if (collection == null)
            {
                throw new InvalidOperationException("Collection is empty!");
            }

            TSelector max = func(collection.First());

            foreach (var element in collection)
            {
                if (max.CompareTo(func(element)) < 0)
                {
                    max = func(element);
                }
            }

            return max;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ch06_PackLibrary
{
    public static class MyExtensions
    {
        public static bool IsValidEmail(this string input)
        {
            //use simple regular expression to check
            // that the input string is a valid email
            return Regex.IsMatch(input, @"[a-zA-Z0-9.-_]+@[a-zA-Z0-9.-_]+");
        }

        public static int ToInt32Extension(this string s)
        {
            return Int32.Parse(s);
        }

        public static int ToInt32ExtensionAddInteger(this string s, int value) {
            return Int32.Parse(s) + value;
        }

        public static int GetMinVal<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            int smallest  = int.MinValue;
            foreach (var item in source)
            {
                int nextItem = selector(item);
                if (smallest == int.MinValue)
                {
                    smallest = nextItem;
                }else if (nextItem < smallest)
                {
                    smallest = nextItem;
                }
            }
            return smallest;
        }

        public static IEnumerable<T> MyOwnWhere<T>(this IEnumerable<T> source, Func<T,bool> predicate) where T:class
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}

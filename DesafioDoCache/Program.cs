using System;
using System.Collections.Generic;

using DesafioDoCache.Entities;

namespace DesafioDoCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Cache<string> cache = new Cache<string>(5);

            //Console.WriteLine(cache.getMaxLength());


            Dictionary<int, Tuple<int, int>> b = new Dictionary<int, Tuple<int, int>>();

            b.Add(2, new Tuple<int, int>(2, 3));
            b.Add(3, new Tuple<int, int>(4, 2));
            b.Add(3, new Tuple<int, int>(4, 2));
            b.Add(3, new Tuple<int, int>(4, 2));
            b.Add(3, new Tuple<int, int>(4, 2));

            // Console.WriteLine(b.ContainsKey(2));
            // var c = b[3];

            // Console.WriteLine(c);

        }
    }
}

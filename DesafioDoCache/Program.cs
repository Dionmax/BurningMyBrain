using System;

using DesafioDoCache.Entities;

namespace DesafioDoCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Cache cache = new Cache(5);

            Console.WriteLine(cache.getTamanhoMaximo());
        }
    }
}

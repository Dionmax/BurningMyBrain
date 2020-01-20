using System;
using System.Collections.Generic;
//using System.Linq;

namespace DesafioDoCache.Entities
{
    public class Cache<T>
    {
        private int _maxLength = 0;

        //private List<Tuple<int, int, T>> _obj = new List<Tuple<int, int, T>>();

        HashSet<Tuple<int, int, T>> _obj = new HashSet<Tuple<int, int, T>>();

        public Cache() { }

        public Cache(int maxLength)
        {
            _maxLength = maxLength;
        }

        public int getMaxLength()
            => _maxLength;

        public void Add(int value)
        {
            
        }

        // public int Get(){}

        //public int Delete(){}
    }
}
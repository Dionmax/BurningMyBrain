using System;

namespace Aula204_generics_part1
{
    class PrintServiceProgram <T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
                throw new InvalidOperationException("PrintService is full");

            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
                throw new InvalidOperationException("PrintService is empty");

            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");

            //for (int i = 0; i < _count; i++)
            //{
            //    Console.Write(_values[i] + ((_count != _count - 1) ? ", " : ""));
            //}

            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }

            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }

            Console.Write("]");
            Console.WriteLine("");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_18
{
    class List
    {

        private int _count = 0;
        private readonly string[] _array;

        public List(int maxLength)
        {
            _array = new string[maxLength];
        }

        public int Count()
        {
            return _count;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _array.Length;
        }
        public bool Insert(string value)
        {
            if (IsFull())
            {
                return false;
            }

            _array[_count] = value;
            _count++;
            return true;
        }

        //public int Count()
        //{
        //    return _count;
        //}
        public bool RemoveAt(int index)
        {
            for (int i = index; i < _count; i++)
            {
                _array[i] = _array[i + 1];
            }
            if (index > _count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void PrintReverse()
        {
            for (int i = _array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(_array[i]);
            }
        }
        public bool InsertAt(int index, object o)
        {
            var value = o.ToString();
            
            if (index > _count)
            {
                return false;
            }
            else
            {
                _array[index] = value;
                _count++;
                foreach (var item in _array)
                {
                    Console.WriteLine(item);
                }
                return true;
            }
        }
    }
}

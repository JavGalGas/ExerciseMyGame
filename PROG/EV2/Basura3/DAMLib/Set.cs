using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMLib
{

    public class Set<T>
    {
        private T[] _set = new T[0];
        private int _count = 0;    

        public override bool Equals(object? obj)
        {
            if (this == obj)
                return true;
            if (obj is not Set<T>)
                return false;
            Set<T> s = (Set<T>)obj;
            return s._set == _set && s._count == _count;
        }
        public int Count
        {
            get => _count;
        }

        public int IndexOf(T element)
        {
            for(int i = 0; i < _set.Length; i++)
            {
                if (_set[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Clear()
        {
            _count = 0;
        }
        public void Add(T element)
        {

            if (Count < _set.Length)
            {
                _set[_count++] = element;
            }
            else
            {
                T[] NewSet = new T[Count + 1];
                for (int i = 0; i < Count - 1; i++)
                {
                    NewSet[i] = _set[i];
                }
                NewSet[Count - 1] = element;
                _set = NewSet;
            }
        }
        public void Remove(T element)
        {
            int aux = IndexOf(element);
            if (aux == -1)
                return;
            T[] NewSet = new T[Count - 1];
            
            for (int i = 0; i < Count - 1; i++)
            {
                if (i == aux)
                    continue;
                NewSet[i] = _set[i];
            }
            _set = NewSet;
        }

        public bool Cointains(T element)
        {
            //if (IndexOf(element) == -1)
            //    return false;
            //return true;

            for (int i = 0; i < Count; i++)
            {
                if (_set[i].Equals(element))
                    return true;
            }
            return false;
        }

        
    }
}

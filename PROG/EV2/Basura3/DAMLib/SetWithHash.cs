using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMLib
{
    public class SetWithHash<T>
    {
        private T[] _set = new T[0];
        private int[] _hash = new int[0];
        private int _count = 0;



        public override bool Equals(object? obj)
        {
            if (this == obj)
                return true;
            if (obj is not SetWithHash<T>)
                return false;
            SetWithHash<T> s = (SetWithHash<T>)obj;
            return s._set == _set && s._count == _count;
        }

        public override int GetHashCode()
        {
            return _hash.GetHashCode() * _set.GetHashCode() - Count * (_count.GetHashCode() / 77) + Count;
        }
        public int Count
        {
            get => _count;
        }

        public int IndexOf(T element)// implementar hash
        {
            for (int i = 0; i < _set.Length; i++)
            {
#nullable disable
                if (_set[i].Equals(element))
#nullable enable
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
        public void Add(T element) //implementar hash
        {

            if (Count < _set.Length)
            {
                _set[_count++] = element;
                _hash[Count] = GetHashCode();
            }
            else
            {
                T[] NewSet = new T[Count + 1];
                int[] NewHash = new int[Count - 1];
                for (int i = 0; i < Count; i++)
                {
                    NewSet[i] = _set[i];
                    NewHash[i] = _hash[i];
                }
                NewSet[Count - 1] = element;
                NewHash[Count-1] = GetHashCode();
                _set = NewSet;
                _hash = NewHash;
            }
        }
        public void Remove(T element) //implementar hash
        {
            int aux = IndexOf(element);
            if (aux == -1)
                return;
            T[] NewSet = new T[Count - 1];
            int[] NewHash = new int[Count - 1];
            //for (int i = 0; i < Count - 1; i++)
            //{
            //    if (i == aux)
            //        continue;
            //    NewSet[i] = _set[i];
            //}

            for (int i = 0; i < aux; i++)
            {
                NewSet[i] = _set[i];
                NewHash[i] = _hash[i];
            }    
            for (int i = aux + 1; i < NewSet.Length; i++)
            {
                NewSet[i - 1] = _set[i];
                NewHash[i] = _hash[i];
            }
               

            _set = NewSet;
        }

        public bool Cointains(T element) //implementar hash
        {
            //if (IndexOf(element) == -1)
            //    return false;
            //return true;

            for (int i = 0; i < Count; i++)
            {
#nullable disable
                if (_set[i].Equals(element))
#nullable enable
                    return true;
            }
            return false;
        }

    }
}

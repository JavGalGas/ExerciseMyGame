using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAMLib
{
    public class ItemSet<T>
    {
        private class Item
        {
#nullable disable
            public T _element;
#nullable enable
            public int _hash;

        }
        private Item[] _items= new Item[0];

        private int _count = 0;

        public override bool Equals(object? obj)
        {
            if (this == obj)
                return true;
            if (obj is not ItemSet<T>)
                return false;
            ItemSet<T> s = (ItemSet<T>)obj;
            return s._items == _items && s._count == _count;
        }

        public override int GetHashCode()
        {
            return _items.GetHashCode() * _items.GetHashCode() - Count * (_count.GetHashCode() / 77) + Count;
        }


        public int Count
        {
            get => _count;
        }

        public int IndexOf(T element)// implementar hash
        {
#nullable disable
            int h = element.GetHashCode();
#nullable enable
            for (int i = 0; i < _items.Length; i++)
            {

                if (h == _items[i]._hash)
                {
#nullable disable
                    if (_items[i].Equals(element))
#nullable enable
                    {
                        return i;
                    }
                }
#nullable disable
                if (_items[i].Equals(element))
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

            if (Count < _items.Length)
            {
                _items[_count++]._element = element;
#nullable disable
                _items[Count]._hash = element.GetHashCode();
#nullable enable
            }
            else
            {
                Item[] NewArray = new Item[Count + 1];
                for (int i = 0; i < Count; i++)
                {
                    NewArray[i]._element = _items[i]._element;
                    NewArray[i]._hash = _items[i].GetHashCode();
                }
                NewArray[Count - 1]._element = element;
#nullable disable
                NewArray[Count - 1]._hash = element.GetHashCode();
#nullable enable
                _items = NewArray;
            }
        }
        public void Remove(T element) //implementar hash
        {
            int aux = IndexOf(element);
            if (aux == -1)
                return;
            Item[] NewArray = new Item[Count - 1];
            //for (int i = 0; i < Count - 1; i++)
            //{
            //    if (i == aux)
            //        continue;
            //    NewSet[i] = _set[i];
            //}

            for (int i = 0; i < aux; i++)
            {
                NewArray[i]._element = _items[i]._element;
                NewArray[i]._hash = _items[i]._hash;
            }
            for (int i = aux + 1; i < NewArray.Length; i++)
            {
                NewArray[i - 1]._element = _items[i]._element;
                NewArray[i]._hash = _items[i]._hash;
            }
            _items = NewArray;
        }

        public bool Cointains(T element) //implementar hash
        {
            //if (IndexOf(element) == -1)
            //    return false;
            //return true;
            for (int i = 0; i < Count - 1; i++)
            {
                for (int j = 1; j < Count; j++)
                {
                    if (_items[i]._hash == _items[j]._hash)
                        return true;
                }
            }
            for (int i = 0; i < Count; i++)
            {
#nullable disable
                if (_items[i].Equals(element))
#nullable enable
                    return true;
            }
            return false;
        }
    }
}

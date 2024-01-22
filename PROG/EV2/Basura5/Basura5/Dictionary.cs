using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basura5
{
    delegate bool DictionaryFilterDelegate<K, V>(K key, V value);

    public class Dictionary<K, V>
    {


        private class Item
        {
            public K key;
            public V value;
        }

        private Item[] _items = new Item[0];
        public int Count => 0;
        public bool IsEmpty => true;

        public void Clear()
        {

        }

        public void Add(K key, V value)
        {

        }
        public bool Contains(K key)
        {
            return false;
        }

        public void Remove(K key)
        {

        }

        public V GetValueWithKey(K key)
        {

        }

        public bool TryGetValue(K key, out V value)
        {

        }

        //una lambda cambia el parámetro que normalmente pasamos por una función
        public Dictionary<K, V> Filter(DictionaryFilterDelegate<K, V> where)
        {
            var ret = new Dictionary<K, V>();
            for (int i = 0; _items.Length; i++)
            {
                Item item = _items[i];
                bool addToNewDictionary = where(item.key, item.value);

            }

            return ret;
        }

    }

        //igual que Remove(), pero varios key a la vez
    public void Remove()
    {

    }
}

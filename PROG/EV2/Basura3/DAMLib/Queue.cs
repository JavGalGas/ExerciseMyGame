using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMLib
{
    public class Queue<T>
    {
        private T[] _queue = new T[0];

        public void Enqueue(T element)
        {
            T[] NewQueue = new T[Count + 1];
            for (int i = 1; i < _queue.Length - 1; i++)
            {
                NewQueue[i] = _queue[i];
            }
            NewQueue[0] = element;
            _queue = NewQueue;
        }
        public T Dequeue()
        {
            if (Empty)
                return default(T);
            T element = First;
            T[] NewQueue = new T[Count - 1];
            for (int i = 0; i < _queue.Length - 2; i++)
            {
                NewQueue[i] = _queue[i];
            }
            _queue = NewQueue;
            return element;
        }
        public int Count
        {
            get=> _queue.Length;
        }
        public T First
        {
            get
            {
                if (Empty)
                    return default(T);
                return _queue[Count - 1];
            }
        }
        public T Last
        {
            get
            {
                if (Empty)
                    return default(T);
                return _queue[0];
            }     
        }
        public void Clear()
        {
            T[] NewQueue = new T[0];
            _queue = NewQueue;
        }
        public bool Empty
        {
            get => Count == 0;
        }
         
    }
}

using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace DAMLib
{
    public class Stack<T>
    {
        private T [] _stack = new T[0];
        public void Push(T element)
        {
            T[] NewStack = new T[GetCount()+1];
            for(int i = 0; i < _stack.Length-1; i++)
            {
                NewStack[i] = _stack[i];
            }
            NewStack[NewStack.Length-1] = element;
            _stack = NewStack;
        }
        public T Pop()
        {
            T element = GetTop();
            T[] NewStack = new T[GetCount() - 1];
            for (int i = 0; i < _stack.Length-2; i++)
            {
                NewStack[i] = _stack[i];
            }
            _stack = NewStack;
            return element;
        }
        public T GetTop()
        {
            return _stack[_stack.Length - 1];
        }
        //Pop y GetTop pueden dar problemas con el null, hay que buscar sobre el default(T);
        public bool IsEmpty()
        {
            if (GetCount() == 0)
                return true; 
            return false;
        }
        public int GetCount()
        {
            return _stack.Length;
        }
        //Libreria
        // DAMLibTest
        //      DAMLibTest
        //      DAMLib (biblioteca de clases)
    }
}
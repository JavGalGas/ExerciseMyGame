using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace DAMLib
{
    public class Stack<T>
    {
        private T [] _stack = new T[0];
        public void Push(T element)
        {
            T[] aux = new T[_stack.Length+1];
            for(int i = 0; i < _stack.Length; i++)
            {
                aux[i] = _stack[i];
            }
            aux[GetCount()-1] = element;
            _stack = aux;
        }
        public T Pop(T element)
        {
            //for()
            //return _stack[_stack.Length - 1];
        }
        public T GetTop()
        {
            return _stack[_stack.Length - 1];
        }
        //Pop y GetTop pueden dar problemas con el null, hay que buscar sobre el default(T);
        public bool IsEmpty()
        {
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
using DAMLib;
using System.Collections;
namespace Basura3
{
    internal class Program
    {
        public class Prueba
        {
            public string[] _hash = new string[6];

        }
        static void Main(string[] args)
        {
            //DAMLib.Stack stack = new();
            //stack.Start();
            //stack.Push("a");
            //stack.Push("b");
            //stack.Push("c");
            //stack.Push("d");
            //stack.Push("e");
            //stack.Push("f");
            //stack.GetTop();
            //stack.Pop();
            //stack.End();
            //DAMLib.Set set = new();
            //DAMLib.Queue queue = new();

            Prueba s = new Prueba();
            s._hash[0] = "hola";
            Console.WriteLine(s._hash[0].GetHashCode());

        }
    }
}
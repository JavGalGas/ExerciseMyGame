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
            //DAMLib.Stack<string> stack = new();
            //stack.Push("a");
            //stack.Push("b");
            //stack.Push("c");
            //stack.Push("d");
            //stack.Push("e");
            //stack.Push("f");
            //Console.WriteLine(stack.GetTop().ToString());
            //Console.WriteLine(stack.IsEmpty());
            //Console.WriteLine(stack.GetCount());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.GetTop().ToString());
            //Console.WriteLine(stack.IsEmpty());
            //Console.WriteLine(stack.GetCount());


            //Set<string> set = new();
            //DAMLib.Queue<string> queue = new();

            SetWithHash<string> s = new();
            s.Add("hola");
            s.Add("ho");
            s.Add("hola");
            s.Add("as");
            s.Add("brd");
            s.Add("ngh");
            s.Add("vrtd");
            s.Add("nyt");
            s.Add("vdfvg");
            s.Add("ho");
            s.Add("bdr");
            s.Add("ngh");
            s.Add("nyt");
            s.Add("bdgn");
            s.Add("nty");
            s.Add("as");
            s.Add("brd");
            Console.WriteLine();

        }
    }
}
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


            Set<string> set = new();
            set.Add("a");
            set.Add("b");
            set.Add("c");
            set.Add("d");
            set.Add("e");
            Console.WriteLine(set.Cointains("c"));
            Console.WriteLine(set.Equals(set));
            set.Remove("c");
            Console.WriteLine(set.Cointains("c"));



            //DAMLib.Queue<string> queue = new();

            //SetWithHash<string> s = new();
            //s.Add("hola");
            //s.Add("ho");
            //s.Add("hola");
            //s.Add("as");
            //s.Add("brd");
            //s.Add("negh");
            //s.Add("vrtd");
            //s.Add("nyt");
            //s.Add("vdfvg");
            //s.Add("ho");
            //s.Add("bdr");
            //s.Add("negh");
            //s.Add("nyt");
            //s.Add("bdgn");
            //s.Add("nty");
            //s.Add("as");
            //s.Add("brd");
            //Console.WriteLine(s.Cointains("ho"));
            //Console.WriteLine(s.Equals(s));
            //Console.WriteLine();

            //ItemSet<string> itemSet = new ItemSet<string>();
            //itemSet.Add("hola");
            //itemSet.Add("hola2");
            //itemSet.Add("hola3");
            //itemSet.Add("hola4");
            //itemSet.Add("hola5");
            //itemSet[1].Equals("hola2");










        }
    }
}
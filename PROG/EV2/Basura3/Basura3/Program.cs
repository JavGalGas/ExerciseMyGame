using DAMLib;
using System.Collections;
namespace Basura3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DAMLib.Stack stack = new();
            stack.Start();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");
            stack.Push("e");
            stack.Push("f");
            stack.GetTop();
            stack.Pop();
            stack.End();
            DAMLib.Set set = new();
            DAMLib.Queue queue = new();

        }
    }
}
namespace Basura_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<string> root = new Node<string>("T");
            Node<string> child1 = new Node<string>("A", root);
            Node<string> child2 = new Node<string>("B");
            root.AddChild(child2);

        }
    }
}
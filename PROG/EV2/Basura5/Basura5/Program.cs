namespace Basura5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            var result = d.Filter((key, value) =>
            {
                return true; // return false; // return key.Contains("a") || key.Contains("A"); // return key.Contains("a") && value >3;
            });

            Console.WriteLine(result);
        }
    }
}
namespace EXAM1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Runner runner = new Runner("Juan",50);
            double result = runner.getVelocity();
            Console.WriteLine(result);
        }
    }
}
namespace BigNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            BigNumber n1 = new BigNumber("56");
            BigNumber n2 = new BigNumber("65");
            BigNumber n3 = BigNumber.Multiply(n1, n2);
            string result = n3.ConvertToString();
            Console.WriteLine(result);
        }
    }
}
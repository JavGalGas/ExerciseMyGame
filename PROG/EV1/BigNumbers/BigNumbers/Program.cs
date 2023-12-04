namespace BigNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            BigNumber n1 = new BigNumber(5);
            BigNumber n2 = new BigNumber(-545);
            BigNumber n3 = BigNumber.Multiply(n1, n2);
            string result = n3.ConvertToString();
            Console.WriteLine(result);
        }
    }
}
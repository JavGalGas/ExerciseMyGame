namespace BigNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            BigNumber n1 = new BigNumber("89");
            //BigNumber n2 = new BigNumber("111");
            //BigNumber n3 = BigNumber.Add(n1, n2);
            string result = n1.ConvertToString();
            Console.WriteLine(result);
        }
    }
}
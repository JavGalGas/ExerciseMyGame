namespace BigNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            BigNumber n1 = new BigNumber(-7-1);
            //BigNumber n2 = new BigNumber("");
            //BigNumber n3 = BigNumber.Add(n1, n2);
            string result = n1.ConvertToString();
            Console.WriteLine(result);
        }
    }
}
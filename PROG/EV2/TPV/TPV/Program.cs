using TPVLib;

namespace TPV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITPV tpv = ITPV.CreateNewTPV();
            Product product = new Product(1, "Coca-Cola", "Bebida azucarada gaseosa", 1.99, 100, 21.0);
            Product product2 = new Product(1, "Pepsi", "Bebida azucarada gaseosa", 1.89, 50, 21.0);
            Console.WriteLine(tpv.AddProduct(product));
            Console.WriteLine(tpv.AddProduct(product2));
            Product product3 = new Product(-1, "Fanta", "Bebida azucarada gaseosa", 1.69, 75, 21.0);
            Console.WriteLine(tpv.AddProduct(product3));
        }
    }
}
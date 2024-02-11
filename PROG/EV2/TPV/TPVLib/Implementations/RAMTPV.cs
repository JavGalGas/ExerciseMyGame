namespace TPVLib
{
    public class RAMTPV : ITPV
    {
        private List<Product> _products= new();
        public int ProductCount => _products.Count;

        public long AddProduct(Product product)
        {
            long id = product.Id;
            try
            {
                if (id < 0)
                    throw new Exception();
                for (int i = 0; i < _products.Count; i++)
                {
                    if(id == _products[i].Id)
                        throw new Exception();
                }
            }
            catch (Exception)
            {
                id = long.MinValue;
                Console.WriteLine("The Id is incorrect or is already been used.");
                return id;
            }

            _products.Add(product);
            return id;
        }

    }
}
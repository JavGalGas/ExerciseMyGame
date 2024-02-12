namespace TPVLib
{
    public interface ITPV
    {
        int ProductCount { get; }

        static ITPV CreateNewTPV()
        {
            return new RAMTPV();
        }

        long AddProduct(Product product);
        void RemoveProduct(long id);
        Product? GetProductWithId(long id);
        void UpdateProductWithId(long id, Product product);
        public void RemoveProduct(Product product)
        {
            if(product != null)
                RemoveProduct(product.Id);
        }
        List<Product> GetProducts(int offset, int limit);
    }
}

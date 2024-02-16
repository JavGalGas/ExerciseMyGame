namespace TPVLib
{
    internal interface IDatabase
    {
        long AddProduct(Product product);
        void RemoveProduct(long id);
        Product? GetProductWithId(long id);
        void UpdateProductWithId(long id, Product product);
        public void RemoveProduct(Product product)
        {
            if (product != null)
                RemoveProduct(product.Id);
        }
        List<Product> GetProducts(int offset, int limit);

        public void AddTicketHeader();
        //todas las funciones ADD
    }
}

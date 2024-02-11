namespace TPVLib
{
    public interface ITPV
    {
        int ProductCount {  get; }

        static ITPV CreateNewTPV()
        {
            return new RAMTPV();
        }

        public abstract long AddProduct(Product product);//debe añadir el producto que le pasen, y si falla realiza un Try...Catch. Además, devuelve el id del producto por si necesitas modificar el producto
        public void RemoveProduct(long id)
        {
            try 
            {
                
            }
            catch
            {

            }
            finally
            {

            }
        }

        public Product? GetProduct(long id)
        {
            return null;
        }

        public void UpdateProductWithId(long id, Product product)
        {
            try
            {

            }
            catch
            {

            }
            finally
            {

            }
        }

        public void RemoveProduct(Product product)
        {
            if(product != null)
                RemoveProduct(product.Id);
        }

        public List<Product> GetProducts(int offset, int limit)
        {
            return new List<Product>();
        }
    }
}

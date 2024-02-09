namespace TPVLib
{
    public interface ITPV
    {
        static ITPV CreateNewTPV()
        {
            return new RAMTPV();
        }

        public long AddProduct(Product product)//debe añadir el producto que le pasen, y si falla realiza un Try...Catch. Además, devuelve el id del producto por si necesitas modificar el producto
        {
            
        }
    }
}

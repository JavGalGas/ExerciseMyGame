namespace TPVLib
{
    public class RAMTPV : ITPV
    {
        private Dictionary<long, Product> _products = new();
        public int ProductCount => _products.Count;
        private long _currentGeneratingId = 1;

        public long AddProduct(Product product)//modificar
        {
            var cloneP = product.Clone();
            cloneP.Id = _currentGeneratingId++;
            _products.Add(cloneP.Id,cloneP);
            return cloneP.Id;
        }

        public void RemoveProduct(long id)//hacer
        {
            
        }

        public Product? GetProductWithId(long id)//hacer
        {
            throw new NotImplementedException();
        }

        public void UpdateProductWithId(long id, Product product)//hacer
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts(int offset, int limit)//hacer
        {
            throw new NotImplementedException();
        }

        public bool Contains(Product product)
        {

            foreach(var p in _products)
            {
                if(p.Key == product.Id) return true;
            }
            return false;
        }
    }
}
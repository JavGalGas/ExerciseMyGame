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
            _products.Add(cloneP.Id, cloneP);
            return cloneP.Id;
        }

        public void RemoveProduct(long id)
        {
            if (id <= 0)
                throw new Exception("The id doesn't exist.");
            _products.Remove(id);
        }

        public Product? GetProductWithId(long id)
        {
            foreach(var entry in _products)
            {
                long entryId = entry.Key;
                Product entryProduct = entry.Value;
                if (entryId == id)
                {
                    return entryProduct.Clone();
                }
            }
            return null;
        }

        public void UpdateProductWithId(long id, Product product)
        {
            foreach (var entry in _products)
            {
                long entryId = entry.Key;
                Product entryProduct = entry.Value;
                if (entryId == id)
                {
                    _products[entryId] = entryProduct;
                }
            }
        }

        public List<Product> GetProducts(int offset, int limit)
        {
            int startPos = offset - 1;
            int endPos = Math.Min(startPos + limit, ProductCount);

            if(offset < 0 || limit < 0|| startPos > endPos)
                return new List<Product>();

            var products = new List<Product>();
            while(startPos<endPos)
            {
                startPos++;
                products.Add(_products[startPos]);
                //foreach (var p in _products)
                //{
                //    if (p.Value.Id == offset)
                //    {
                //        Product product = p.Value;
                //        products.Add(product);
                //    }
                //}
            }
            return products;
        }

        public bool Contains(Product product)
        {
            if(product == null)
                return false;
            foreach(var p in _products)
            {
                if(p.Value.Id == product.Id) return true;
            }
            return false;
        }

        public int IndexOf(Product product)
        {
            for(int i=0; i< _products.Count; i++) 
            {
                if (_products[i].Id == product.Id)
                    return i;
            }
            return -1;
        }
    }
}
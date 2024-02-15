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

        public void RemoveProduct(long id)//hacer
        {
            Product? result = GetProductWithId(id);
            if (result != null)
            {
                _products.Remove(id);
            }
        }

        public Product? GetProductWithId(long id)//hacer
        {
            foreach(var entry in _products)
            {
                long entryId = entry.Key;
                Product entryProduct = entry.Value;
                if (entryId == id)
                {
                    Product result = entryProduct.Clone();
                    return result;
                }
            }
            return null;
        }

        public void UpdateProductWithId(long id, Product product)//hacer
        {
            foreach (var entry in _products)
            {
                long entryId = entry.Key;
                Product entryProduct = entry.Value;
                if (entryId == id)
                {
                    _products[entry.Key] = entryProduct;
                }
            }
        }

        public List<Product> GetProducts(int offset, int limit)//hacer
        {
            int startPos = offset - 1;
            int endPos = Math.Min(startPos + ProductCount, ProductCount);

        List<Product> products = new List<Product>();
            while(offset<limit)
            {
                Product? product1 = GetProductWithId(offset);
                if (product1 != null)
                    products.Add(product1);
                //foreach (var p in _products)
                //{
                //    if (p.Value.Id == offset)
                //    {
                //        Product product = p.Value;
                //        products.Add(product);
                //    }
                //}
                offset++;
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
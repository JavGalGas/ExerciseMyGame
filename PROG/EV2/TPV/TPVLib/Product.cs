namespace TPVLib
{
    public class Product
    {
        public long Id { get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        //public var Image { get; set;}
        public double IVA { get; set; }

        public Product Clone()
        {
            Product clonedProduct = new Product();
            clonedProduct.Id = Id;
            clonedProduct.Name = Name;
            clonedProduct.Description = Description;
            clonedProduct.Price = Price;
            clonedProduct.Stock = Stock;
            //clonedProduct.Image = Image;
            return clonedProduct;
        }


    }
}

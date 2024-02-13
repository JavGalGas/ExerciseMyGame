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
        //public enum TaxesType { get; set; }

        public Product Clone()
        {
            return new Product()
            {
                Id = Id,
                Name = Name,
                Description = Description,
                Price = Price,
                Stock = Stock,
                //clonedProduct.Image = Image,
                //TaxesType = TaxesType
            };
        }


    }
}

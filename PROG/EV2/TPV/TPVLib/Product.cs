namespace TPVLib
{
    public enum TaxesType
    {
        IVA,
        NO_IVA,
        REDUCED_IVA
    }
    public class Product
    {//Se trabaja con properties en c# y se respeta que las clases sean lo más POJO posible porque cuando se hace una consulta solo devuelve un objeto con las properties
     //si tiene variables que no se devuelven.
        public long Id { get; set;}
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        //public var Image { get; set;}
        public double IVA { get; set; }
        public TaxesType Type{ get; set; }

        public Product Clone()
        {
            return new Product()
            {
                Id = Id,
                Name = Name,
                Description = Description,
                Price = Price,
                Stock = Stock,
                //Image = Image,
                IVA = IVA,
                Type = Type
            };
        }

 
    }
}

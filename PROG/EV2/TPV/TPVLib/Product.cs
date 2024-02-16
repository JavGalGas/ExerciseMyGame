namespace TPVLib
{
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
                //Image = Image,
                //TaxesType = TaxesType
            };
        }

        //public class Ticket
        //{
        //    public TicketHeader Header { get; set; }
        //    public TicketBody Body { get; set; }
        //    public double TotalPrice { get; set; }
        //}

        //public class TicketHeader
        //{
        //    public int Id { get; set; }
        //    public string BarCode { get; set; }
        //}

        //public class TicketBody
        //{
                
        //}

        //public class TicketLine
        //{
        //    public string Details { get; set; }
        //    public double Quantity {get; set;}
        //      public Product Product { get; set; }
        //}Se podría hacer con long ProductId, pero tendrías que hacer un query por cada producto
    }
}

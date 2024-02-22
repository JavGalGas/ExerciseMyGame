using TPVLib.Implementations;

namespace TPVLib
{
    public class RAMTPV : ITPV
    {
        
        private IDatabase _db;

        private Dictionary<long, Product> _products = new();
        private Dictionary<long, Ticket> _tickets = new();
        private long _currentGeneratingId = 1;
        public int ProductCount => _products.Count;


        //Inyección de dependencias (Buscar)
        public RAMTPV(IDatabase database)
        {
            _db = database;
        }

        /**public long AddProduct(Product product) => _db.AddProduct(product);
         * ...
         */
        public long AddProduct(Product product)//modificar
        {
            return _db.AddProduct(product);
        }

        public void RemoveProductWithId(long id)//Ver si se puede cambiar el key y el id del diccionario
        {
            _db.RemoveProductWithId(id);
        }

        public Product? GetProductWithId(long id)
        {
            return _db.GetProductWithId(id);
        }

        public void UpdateProductWithId(long id, Product product)
        {
            _db.UpdateProductWithId(id, product);
        }

        public List<Product> GetProducts(int offset, int limit)
        {
            return _db.GetProducts(offset, limit);
        }

        public bool Contains(Product product)
        {
            if (product == null)
                return false;
            foreach (var p in _products)
            {
                if (p.Value.Id == product.Id) return true;
            }
            return false;
        }

        public int IndexOf(Product product)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Id == product.Id)
                    return i;
            }
            return -1;
        }

        public void SaveTickets()
        {

        }

        public void SaveProducts()
        {

        }

        //public void AddTicket(Ticket ticket)
        //{
        //    try
        //    {
        //        _database!.BeginTransaction();

        //        long id = _database.AddTicket(ticket.Header!);
        //        foreach (var line in ticket.Body!.lines!)
        //        {
        //            _database.AddTicketLine(id, line);
        //        }

        //        _database.Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        _database!.Rollback();
        //        throw new Exception(ex.Message);
        //    }
        //}

        //public long AddTicket(Header header)
        //{
        //    try
        //    {
        //        _database.BeginTransaction();

            //        long id = _database.AddTicket(Ticket.Header);
            //        foreach (var line in Ticket.Body.Lines)
            //        {
            //            _database.AddTicketLine(id, line);
            //        }

            //        _database.Commit();
            //    }
            //    catch (Exception ex)
            //    {
            //        _database.Rollback();
            //        throw new Exception(ex.Message);
            //    }
            //}
            /**public static void SaveTickets(Ticket[] tickets, ITPV tpv)
             * {
             *      try
             *      {
             *      _database.BeginTransaction();
             *       foreach(var line in Ticket.Body.Lines)
            //      {
            //         tpv.AddTicketLine(id, line);
            //      }   
             * 
             * 
             * 
             * }
             */
    }
}
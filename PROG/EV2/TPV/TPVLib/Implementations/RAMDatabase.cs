using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVLib.Implementations
{
    public class RAMDatabase : IDatabase
    {
        private Dictionary<long, Product> _products = new();
        private Dictionary<long, Ticket> _tickets = new();
        private long _currentGeneratingId = 1;
        public void AddLineToTicketWithId(long id, TicketLine ticketLine)
        {
            
        }

        public long AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public long AddTicket(Header ticket)
        {
            throw new NotImplementedException();
        }

        public void AddTicketBody(Body body)
        {
            throw new NotImplementedException();
        }

        public void AddTicketLine(long ticketId, TicketLine ticketLine)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts(int offset, int limit)
        {
            throw new NotImplementedException();
        }

        public Product? GetProductWithId(long id)
        {
            throw new NotImplementedException();
        }

        public TicketLine[] GetTicketLinesWithId(long ticketId)
        {
            throw new NotImplementedException();
        }

        public void RemoveProductWithId(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductWithId(long id, Product product)
        {
            throw new NotImplementedException();
        }

        //public void BeginTransaction()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Rollback()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

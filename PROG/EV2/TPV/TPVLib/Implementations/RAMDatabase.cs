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

        public int ProductCount => _products.Count;
        //public void AddLineToTicketWithId(long id, TicketLine ticketLine)
        //{

        //}

        public long AddTicket(Header ticket)
        {
            Ticket  newTicket = new Ticket();
            ticket.Id = (int)_currentGeneratingId++;
            int id = ticket.Id;
            newTicket.Header = ticket;
            _tickets.Add(id, newTicket);
            return id;
        }

        public void AddTicketBody/*AddBodyToTicketWithId*/(long ticketId, Body body)
        {
           foreach (var ticket in _tickets)
           {
                if(ticket.Key == ticketId)
                {
                    ticket.Value.Body = body;
                    break;
                }
           }
        }

        public void AddTicketLine/*AddLineToTicketWithId*/(long ticketId, TicketLine ticketLine)
        {
            foreach (var ticket in _tickets)
            {
                if (ticket.Key == ticketId)
                {
                    ticket.Value.Body!.AddLine(ticketLine);
                    break;
                }
            }
        }

        public TicketLine[] GetTicketLinesWithId(long ticketId)
        {//hacer un Contains
            TicketLine[] lines = new TicketLine[0];
            foreach (var ticket in _tickets)
            {
                if (ticket.Key == ticketId)
                {
                    Ticket aux = ticket.Value;
                    int length = aux.Body!.Lines!.Length;
                    lines = new TicketLine[length];
                    for (int i = 0; i<length; i++)
                    {
                        lines[i] = aux.Body!.Lines![i];
                    }
                    break;
                }
            }
           return lines;
        }

        public long AddProduct(Product product)//modificar
        {
            var cloneP = product.GetClone();
            cloneP.Id = _currentGeneratingId++;
            _products.Add(cloneP.Id, cloneP);
            return cloneP.Id;
        }

        public void RemoveProductWithId(long id)
        {
            if (id <= 0)
                throw new Exception("The id doesn't exist.");
            _products.Remove(id);
        }

        public Product? GetProductWithId(long id)
        {
            foreach (var entry in _products)
            {
                long entryId = entry.Key;
                Product entryProduct = entry.Value;
                if (entryId == id)
                {
                    return entryProduct.GetClone();
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

            if (offset < 0 || limit < 0 || startPos > endPos)
                return new List<Product>();

            var products = new List<Product>();
            while (startPos < endPos)
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

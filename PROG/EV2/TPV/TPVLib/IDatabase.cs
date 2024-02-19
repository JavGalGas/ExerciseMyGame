namespace TPVLib
{
    internal interface IDatabase
    {
        //Tan cercana a la BD como sea posible
        //void BeginTransaction();
        /**void Comit();
         * void 
         */
        long AddProduct(Product product);
        void RemoveProductWithId(long id);
        Product? GetProductWithId(long id);
        void UpdateProductWithId(long id, Product product);
        public void RemoveProduct(Product product)
        {
            if (product != null)
                RemoveProductWithId(product.Id);
        }
        List<Product> GetProducts(int offset, int limit);

        public long AddTicket(Header ticket);
        public void AddTicketLine(long ticketId, TicketLine ticketLine);
        public void AddTicketBody(Body body);
        TicketLine[] GetTicketLinesWithId(long ticketId);
        //todas las funciones ADD
    }
}

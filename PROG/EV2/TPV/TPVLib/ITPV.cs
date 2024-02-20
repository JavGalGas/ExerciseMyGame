namespace TPVLib
{
    public interface ITPV
    {
        IDatabase database { get; set; }
        int ProductCount { get; }

        static ITPV CreateNewTPV()
        {
            return new RAMTPV();
        }

        long AddProduct(Product product);
        void RemoveProduct(long id);
        Product? GetProductWithId(long id);
        void UpdateProductWithId(long id, Product product);
        public void RemoveProduct(Product product)
        {
            if(product != null)
                RemoveProduct(product.Id);
        }
        List<Product> GetProducts(int offset, int limit);

        public void AddTicket(Ticket ticket);

        // Modelo de Negocios            Modelo de Datos
        //      ITPV                        IDatabase
        //  AddTicket(Ticket)               AddProduct(product)
        //                                  ...
        //                                  AddTicketHeader(...)
        //                                  AddTicketLine(...)
        //                                  ...

        //CRUD - Tickets
        //No es infinita
        //Mostrar todo


    }
}

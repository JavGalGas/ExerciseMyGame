namespace TPVLib
{
    public class Product
    {
        private long _id;
        private string _name;
        private string _description;
        private double _price;
        private int _stock;
        //private var _image;
        private bool IsAvailable => _stock > 0;
        private double _IVA;

        public long Id => _id;
        public string Name => _name;
        public string Description => _description;
        public double Price => _price;
        public int Stock => _stock;
        //public var Image =>image;
        public Product()//no estoy seguro que necesite un constructor vacío
        {
            _name = string.Empty;
            _description = string.Empty;
        }
        public Product(long id, string name, string description, double price, int stock, /*var image, */ double IVA)
        {
            _id = id;
            _name = name;
            _description = description;
            _price = price;
            _stock = stock;
            //_image = image;
            _IVA = IVA;
        }


    }
}

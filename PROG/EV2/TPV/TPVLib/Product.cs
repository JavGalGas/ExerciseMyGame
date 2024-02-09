namespace TPVLib
{
    public class Product
    {
        private long _id;
        private string _name;
        private double _price;
        private int _stock;
        //private var _image;
        private bool IsAvailable => _stock > 0;
        private double _IVA;

        public string Name { get;}
        public string Description { get;}
        public double Price { get;}

        public Product() 
        {

        }
    }
}

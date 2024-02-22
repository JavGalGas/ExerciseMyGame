using System.Diagnostics;
using System.Xml.Linq;

namespace TPVLib
{
    public class Ticket
    {
        //Product[] _products = new Product[0];
        public Header? Header { get; set; }
        public Body? Body { get; set; }
        public double TotalPrice { get; set; }
    }
}

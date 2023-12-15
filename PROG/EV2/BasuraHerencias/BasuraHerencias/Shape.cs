using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public abstract class Shape : IShape
    {
        protected Point2D _position;
        private string _name = "";

        string IShape.GetName()
        {
            return _name;
        }
    }
}

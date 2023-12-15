using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class Circle2D : ShapeWithArea
    {
        private double _radius;
        public double GetRadius()
        {
            return _radius;
        }
        public void GetRadius(double radius)
        {
            _radius = radius;
        }
        public override double GetArea()
        { 
            return Math.Pow(_radius,2)*Math.PI;
        }
    }
}

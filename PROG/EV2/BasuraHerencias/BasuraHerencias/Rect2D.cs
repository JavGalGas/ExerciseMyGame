using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class Rect2D : ShapeWithArea
    {
        private Point2D _min, _max;

        public Rect2D(ShapeType type) : base(type)
        {

        }

        public override double GetArea()//base * altura
        {
            return (_min.x + _max.x) * (_min.y + _max.y);
        }

        public void SetMin(Point2D point)
        {

        }
        public void SetMax(Point2D point)
        {

        }
        public void GetMin(Point2D point)
        {

        }
        public void GetMax(Point2D point)
        {

        }
        public double GetHeight()
        {
            double height = 0;
            return height;
        }
        public double GetWidth()
        {
            double width = 0;
            return width;
        }

        public override ShapeType GetShapeType()
        {
            return ShapeType.RECT2D;
        }
    }
}

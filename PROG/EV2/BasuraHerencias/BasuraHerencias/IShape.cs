using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public enum ShapeType
    {
        POLYLINE2D,
        RECT2D,
        POINTSHAPE2D,
        CIRCLE2D,
        POINT2D,
        SEGMENT2D
    }
    public interface IShape
    {

        string GetName();

        public Point2D GetPosition()
        {
            return 
        }
        public void SetPosition(Point2D point)
        {

        }
        public virtual double GetArea()
        {
            return 0;
        }
        public bool HasArea()
        {
            return false;
        }
        public ShapeType GetShapeType()
        {
            return ShapeType.POLYLINE2D;
        }

    }
}

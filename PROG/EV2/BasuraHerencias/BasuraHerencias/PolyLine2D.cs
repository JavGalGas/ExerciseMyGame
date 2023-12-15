using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class PolyLine2D : ShapeWithArea
    {
        private List<Point2D> _points;
        public void AddPoint(Point2D point)
        {

        }
        public int GetPointCount()
        {
            return 0;
        }
        public Point2D GetPointAt(int index)
        {
            return _points[index];
        }
        public void SetPointAt()
        {

        }
        public void RemovePointAt()//puede que Point2D
        {
            
        }
    }
}

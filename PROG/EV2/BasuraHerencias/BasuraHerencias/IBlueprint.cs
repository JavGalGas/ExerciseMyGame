using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public interface IBlueprint
    {
        public void AddShape(IShape shape)
        {
            _shapes.Add(shape);
        }
        public int GetShapeCount()
        {
            return 0;
        }
        public void GetShapeAt(int index)
        {

        }
        public void RemoveShapeAt(int index)
        {

        }
        public double GetArea()
        {
            return 0;
        }
    }
}

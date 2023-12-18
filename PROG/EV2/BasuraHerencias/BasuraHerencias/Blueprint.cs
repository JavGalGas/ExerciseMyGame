using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class Blueprint : IBlueprint
    {
        private List<IShape> _shapes = new List<IShape>();

        public void AddShape(IShape shape)
        {
            _shapes.Add(shape);
        }

        public double GetArea(double area) //area de todas las figuras : recorrer la lista
        {
            if(_shapes.Count <= 0)
                return -1;
            for(int i = 0; i<_shapes.Count; i++)
            {
                if(area == _shapes[i].GetArea())
                {
                    return area;
                }
            }
            return -1;
        }

        public int GetShapeCount()
        {
            return _shapes.Count;
        }


        //lista de Shapes
    }
}

using System;

namespace FigurativtArv
{
    public abstract class Shape
    {
        public bool Is3D
        {
            get => ((int)ShapeType == 1) ? false : true;
        }
        public ShapeType ShapeType {get; private set;}

        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }

        public abstract string ToString(string format)
        {
            throw new NotImplementedException();
        }
    }
}
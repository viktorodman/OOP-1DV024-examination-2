using System;

namespace FigurativtArv
{
    public class Sphere : Shape3D
    {
        public double Diameter { 
            get => _baseShape.Length;
            set => _baseShape.Length = value;
        }

        public override double MantelArea
        {
            get => _baseShape.Area * 4;
        }

        public override double TotalSurfaceArea
        {
            get => MantelArea;
        }

        public override double Volume
        {
            get => (4 / 3) * _baseShape.Area * (Diameter / 2);
        }

        public Sphere(double diameter)
            :base(ShapeType.Sphere, new Ellipse(diameter), diameter)
        {
            // empty
        }
    }
}
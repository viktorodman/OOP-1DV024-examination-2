using System;
namespace FigurativtArv
{
    public class Ellipse : Shape2D
    {
        public override double Area
        {
            get
            {
                return (Math.PI) * (Length / 2) * (Width / 2);
            }
        }

        public override double Perimeter
        {
            get
            {
                return (Math.PI) * (Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2)));
            }
        }

        public Ellipse(double diameter)
            :base(ShapeType.Ellipse, diameter, diameter)
        {
            // empty
        }
        public Ellipse(double hdiameter, double vdiameter)
            :base(ShapeType.Ellipse, hdiameter, vdiameter)
        {
            // empty
        }
    }
}
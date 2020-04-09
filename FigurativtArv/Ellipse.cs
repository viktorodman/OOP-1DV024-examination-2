using System;
namespace FigurativtArv
{
    /// <summary>
    /// Represents an Ellipse
    /// </summary>
    public class Ellipse : Shape2D
    {
        /// <summary>
        /// Gets the area of the ellipse
        /// </summary>
        public override double Area
        {
            get
            {
                return (Math.PI) * (Length / 2) * (Width / 2);
            }
        }

        /// <summary>
        /// Gets the perimeter of the ellipse
        /// </summary>
        public override double Perimeter
        {
            get
            {
                return (Math.PI) * (Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2)));
            }
        }

        /// <summary>
        /// Initializes a new instance of an Ellipse
        /// </summary>
        /// <param name="diameter">The diameter of the ellpise</param>
        public Ellipse(double diameter)
            :base(ShapeType.Ellipse, diameter, diameter)
        {
            // empty
        }

        /// <summary>
        /// Initializes a new instance of an Ellipse
        /// </summary>
        /// <param name="hdiameter">The height of the ellipse</param>
        /// <param name="vdiameter">The width of the ellipse</param>
        public Ellipse(double hdiameter, double vdiameter)
            :base(ShapeType.Ellipse, hdiameter, vdiameter)
        {
            // empty
        }
    }
}
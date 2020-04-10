using System;

namespace FigurativtArv
{
    /// <summary>
    /// Represents a rectangle
    /// </summary>
    public class Rectangle: Shape2D
    {
         /// <summary>
        /// Gets the area of the rectangle
        /// </summary>
        public override double Area
        {
            get
            {
                return Length * Width;
            }
        }

        /// <summary>
        /// Gets the perimeter of the rectangle
        /// </summary>
        public override double Perimeter
        {
            get
            {
                return (2 * Length) + (2 * Width);
            }
        }

        /// <summary>
        /// Initializes a new instance of a rectangle
        /// </summary>
        /// <param name="length">The length of the rectangle</param>
        /// <param name="width">The width of the rectangle</param>
        public Rectangle(double length, double width)
            :base(ShapeType.Rectangle, length, width)
        {
            // Empty
        }
    }
}
using System;

namespace FigurativtArv
{
    /// <summary>
    /// Represents a 2D Shape
    /// </summary>
    public abstract class Shape2D : Shape
    {
        /// <summary>
        /// The length of the shape
        /// </summary>
        private double _length;

        /// <summary>
        /// The Width of the shape
        /// </summary>
        private double _width;

        /// <summary>
        /// Gets the area of the shape
        /// </summary>
        public abstract double Area { get;}
        
        /// <summary>
        /// Gets the perimeter of the shape
        /// </summary>
        public abstract double Perimeter { get;}

        /// <summary>
        /// Gets and sets the length of the shape
        /// </summary>
        /// <value></value>
        public double Length
        {
            get => _length;

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be greater than 0");
                }
                _length = value;
            }
        }

        /// <summary>
        /// Gets and sets the width of the shape
        /// </summary>
        /// <value></value>
         public double Width
        {
            get => _width;

            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be greater than 0");
                }
                _width = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of 2DShape
        /// </summary>
        /// <param name="shapeType">The shape type of the 2dShape</param>
        /// <param name="length">The length of the shape</param>
        /// <param name="width">The width of the shape</param>
        protected Shape2D(ShapeType shapeType, double length, double width)
            :base(shapeType)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Returns the 2DShape as a string
        /// </summary>
        /// <param name="format">The format of the returned string</param>
        /// <returns>A string representing the 2d shape</returns>
        public override string ToString(string format)
        {
            string str;

            if(format == "G" || string.IsNullOrEmpty(format))
            {
                str = $"Längd : {_length:F1}\nBredd : {_width:F1}\nOmkrets : {Perimeter:F1}\nArea : {Area:F1}";
            } else if (format == "R")
            {
                str = $"{ShapeType, -10}{_length, 10:F1} {_width, 10:F1} {Perimeter,10:F1} {Area,10:F1}";
            } else {
                throw new FormatException("No a correct format");
            }
            return str;
        }

        /// <summary>
        /// Returns the 2DShape as a string
        /// </summary>
        /// <returns>A string representing the 2d shape</returns>
        public override string ToString() => ToString("G");
    }
}
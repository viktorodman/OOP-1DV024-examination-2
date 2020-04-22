using System;
namespace FigurativtArv
{
    /// <summary>
    /// Represents a 3D Shape
    /// </summary>
    public abstract class Shape3D: Shape
    {
        /// <summary>
        /// The 3d shapes 2d base shape
        /// </summary>
        protected Shape2D _baseShape;
        
        /// <summary>
        /// The height of the shape
        /// </summary>
        private double _height;

        /// <summary>
        /// Gets and Sets the Height of the shape
        /// </summary>
        /// <value></value>
        public double Height 
        {
            get => _height;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be greater than 0");
                }
                
                _height = value;
            }
        }

        /// <summary>
        /// Gets the Mantel Area of the shape 
        /// </summary>
        /// <value></value>
        public virtual double MantelArea
        {
            get => _baseShape.Perimeter * _height;
        }

        /// <summary>
        /// Gets the Total Surface Area of the shape.
        /// </summary>
        /// <value></value>
        public virtual double TotalSurfaceArea
        {
            get => MantelArea +  (2 * _baseShape.Area);
        }

        /// <summary>
        /// Gets the Volume of the shape
        /// </summary>
        /// <value></value>
        public virtual double Volume
        {
            get => _baseShape.Area * _height;
        }

        /// <summary>
        /// Initializes a new instance of 3DShape
        /// </summary>
        /// <param name="shapeType">The shape type of the 3d shape</param>
        /// <param name="baseShape">The 2d base shape of the 3d shape</param>
        /// <param name="height">The height of the shape</param>
        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height)
            :base(shapeType)
        {
            _baseShape = baseShape;
            Height = height;
        }

        /// <summary>
        /// Returns the 3DShape as a string
        /// </summary>
        /// <param name="format">The format of the returned string</param>
        /// <returns>A string representing the 3d shape</returns>
        public override string ToString(string format)
        {
            string str;

            if(format == "G" || string.IsNullOrEmpty(format))
            {
                str = $"Längd : {_baseShape.Length:F1}\nBredd : {_baseShape.Width:F1}\n" + 
                        $"Höjd : {_height:F1}\nMantelarea : {MantelArea:F1}\n" + 
                        $"Begränsningsarea : {TotalSurfaceArea:F1}\nVolym : {Volume:F1}";
            } else if (format == "R")
            {
                str = $"{ShapeType, -15}{_baseShape.Length, 15:F1}{_baseShape.Width, 15:F1}{_height, 15:F1}{MantelArea, 15:F1}{TotalSurfaceArea, 15:F1}{Volume, 15:F1}";
            } else {
                throw new FormatException("Format must be: 'R' 'G' null or empty");
            }
            return str;
        }

        /// <summary>
        /// Returns the 3DShape as a string
        /// </summary>
        /// <returns>A string representing the 3d shape</returns>
        public override string ToString() => ToString("G");
    }
}
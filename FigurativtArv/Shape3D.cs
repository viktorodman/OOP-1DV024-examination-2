using System;
namespace FigurativtArv
{
    public abstract class Shape3D: Shape
    {
        protected Shape2D _baseShape;
        
        private double _height;

        public double Height 
        {
            get => _height;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be greater than 0");
                }
                
                _height = value;
            }
        }

        public virtual double MantelArea
        {
            get => _baseShape.Perimeter * _height;
        }

        public virtual double TotalSurfaceArea
        {
            get => MantelArea +  (2 * _baseShape.Area);
        }

        public virtual double Volume
        {
            get => _baseShape.Area * _height;
        }

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
                str = $"{ShapeType, -10} {_baseShape.Length, 10:F1} {_baseShape.Width, 10:F1} {_height, 10:F1} {MantelArea, 10:F1} {TotalSurfaceArea, 10:F1} {Volume, 10:F1}";
            } else {
                throw new FormatException("No a correct format");
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
using System;

namespace FigurativtArv
{
    public abstract class Shape2D : Shape
    {
        private double _length;
        private double _width;

        public abstract double Area { get;}
        
        public abstract double Perimeter { get;}
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

        protected Shape2D(ShapeType shapeType, double length, double width)
            :base(shapeType)
        {
            Length = length;
            Width = width;
        }

        public override string ToString(string format)
        {
            string str;

            if(format == "G" || string.IsNullOrEmpty(format))
            {
                str = $"Längd : {_length}\nBredd : {_width}\nOmkrets : {Perimeter}\nArea : {Area}\n";
            } else if (format == "R")
            {
                str = $"{ShapeType} {_length} {_width} {Perimeter} {Area}";
            } else {
                throw new FormatException("No a correct format");
            }
            return str;
        }

        public override string ToString() => $"{ShapeType} {_length} {_width} {Perimeter} {Area}";
    }
}
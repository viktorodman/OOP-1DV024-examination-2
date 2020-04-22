using System;

namespace FigurativtArv
{
    /// <summary>
    /// Represents a Sphere
    /// </summary>
    public class Sphere : Shape3D
    {
        /// <summary>
        /// Gets and sets the Diameter of the Sphere
        /// </summary>
        /// <value></value>
        public double Diameter { 
            get => _baseShape.Length;
            set => _baseShape.Length = value;
        }

        /// <summary>
        /// Gets the Mantel Area of the Sphere
        /// </summary>
        /// <value></value>
        public override double MantelArea
        {
            get => _baseShape.Area * 4;
        }
        
        /// <summary>
        /// Gets the Total Surface Area of the Sphere
        /// </summary>
        /// <value></value>
        public override double TotalSurfaceArea
        {
            get => MantelArea;
        }

        /// <summary>
        /// Gets the Volume of the Sphere
        /// </summary>
        /// <value></value>
        public override double Volume
        {
            get => (4 / 3) * _baseShape.Area * (Diameter / 2);
        }
        
        /// <summary>
        /// Initializes a new instance of Sphere
        /// </summary>
        /// <param name="diameter">The diameter of the Sphere</param>
        public Sphere(double diameter)
            :base(ShapeType.Sphere, new Ellipse(diameter, diameter), diameter)
        {
            // empty
        }
    }
}
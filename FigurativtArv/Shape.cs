using System;

namespace FigurativtArv
{
    /// <summary>
    /// Represents a shape
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Returns true if the shape is a 3d shape
        /// </summary>
        /// <value></value>
        public bool Is3D
        {
            get => ((int)ShapeType > 2) ? false : true;
        }
        /// <summary>
        /// Gets and sets the Shape Type.
        /// </summary>
        /// <value></value>
        public ShapeType ShapeType {get; private set;}
        /// <summary>
        /// Initializes a new instance of Shape
        /// </summary>
        /// <param name="shapeType">The shapes shape type</param>        
        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }

        /// <summary>
        /// Returns the shape as a string
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public abstract string ToString(string format);
    }
}
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
            get => ((int)ShapeType == 1) ? false : true;
        }
        /// <summary>
        /// Gets and sets the Shape Type.
        /// </summary>
        /// <value></value>
        public ShapeType ShapeType {get; private set;}
        /// <summary>
        /// Initial
        /// </summary>
        /// <param name="shapeType"></param>        
        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }

        public virtual string ToString(string format) => $"ShapeType: {ShapeType} Is3D: {Is3D}";
        
    }
}
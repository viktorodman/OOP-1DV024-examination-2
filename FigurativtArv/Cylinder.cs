namespace FigurativtArv
{
    /// <summary>
    /// Represents a Cylinder
    /// </summary>
    public class Cylinder : Shape3D
    {
        /// <summary>
        /// Initializes a new instance of Cylinder
        /// </summary>
        /// <param name="hdiameter">The horizontal diameter of the Cylinder</param>
        /// <param name="vdiameter">The vertical diamater of the Cylinder</param>
        /// <param name="height">The height of the Cylinder</param>
        public Cylinder(double hdiameter, double vdiameter, double height)
            :base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), height)
        {
            // empty
        }
    }
}
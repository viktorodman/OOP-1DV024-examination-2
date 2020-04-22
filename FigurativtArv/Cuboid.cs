namespace FigurativtArv
{
    /// <summary>
    /// Represents a Cuboid
    /// </summary>
    public class Cuboid : Shape3D
    {
        /// <summary>
        /// Initializes a new instance of Cuboid
        /// </summary>
        /// <param name="length">The length of the Cuboid</param>
        /// <param name="width">The width of the Cuboid</param>
        /// <param name="height">The height of the Cuboid</param>
        public Cuboid(double length, double width, double height)
            :base(ShapeType.Cuboid, new Rectangle(length, width), height)
        {
            // Empty
        }
    }
}
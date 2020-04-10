namespace FigurativtArv
{
    public class Cuboid : Shape3D
    {
        public Cuboid(double hdiameter, double vdiameter, double height)
            :base(ShapeType.Cuboid, new Rectangle(hdiameter, vdiameter), height)
        {
            // Empty
        }
    }
}
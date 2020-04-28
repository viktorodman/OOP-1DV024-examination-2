using System;
using System.Collections.Generic;
using RandomExtension;
using System.Linq;
namespace FigurativtArv
{
    /// <summary>
    /// Represents a Shape Randomizer
    /// </summary>
    public static class ShapeRandomizer
    {
        /// <summary>
        /// The minimum random double
        /// </summary>
        private static double minDouble = 0.01;

        /// <summary>
        /// The maximum random number
        /// </summary>
        private static double maxDouble = 100.00;

        /// <summary>
        /// Instantiate random number generator
        /// </summary>
        /// <returns></returns>
        private static Random rand = new Random();

        /// <summary>
        /// Return a list of random shapes.
        /// </summary>
        /// <param name="numberOfShapes">The number of shapes to create</param>
        /// <param name="shapeType">2d shapes or 3d shapes</param>
        /// <returns>A list of shapes</returns>
        public static List<Shape> GetRandomShapes(int numberOfShapes, string shapeType) 
        {
            if (numberOfShapes < 1) {
                throw new ArgumentOutOfRangeException("Number of shapes must be greater than 0");
            }

            List<Shape> shapes = new List<Shape>();
            
            switch (shapeType)
            {
                case "2d":
                    shapes.AddRange(Enumerable
                    .Repeat(0, numberOfShapes)
                    .Select(x => GetRandomShape((ShapeType)rand.Next((int)ShapeType.Rectangle, (int)ShapeType.Ellipse + 1))));
                    break;
                case "3d":
                    shapes.AddRange(Enumerable
                    .Repeat(0, numberOfShapes)
                    .Select(x => GetRandomShape((ShapeType)rand.Next((int)ShapeType.Cuboid, (int)ShapeType.Sphere + 1))));
                    break;
                default:
                    throw new FormatException("shapeType must be 2d or 3d");
                
            }

            return shapes;
        }

        /// <summary>
        /// Takes a number range and returns a random shape
        /// </summary>
        /// <param name="shapeTypes">A number range representing shapes</param>
        /// <returns>A random Shape</returns>
        public static Shape  GetRandomShape(ShapeType shapeType)
        {
            Shape shape;
            switch(shapeType)
                {
                    case ShapeType.Rectangle : 
                        shape = new Rectangle(rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble));
                        break;
                    case ShapeType.Ellipse : 
                        shape = new Ellipse(rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble));
                        break;
                    case ShapeType.Cuboid:
                        shape = new Cuboid(rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble));
                        break;
                    case ShapeType.Cylinder:
                        shape = new Cylinder(rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble));
                        break;
                    case ShapeType.Sphere:
                        shape = new Sphere(rand.RandomDouble(minDouble, maxDouble));
                        break;
                    default:
                        shape = new Rectangle(1, 1);
                        break;
                }
            return shape;
        }


    }
}
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
        /// Takes a number range and returns a random shape
        /// </summary>
        /// <param name="shapeTypes">A number range representing shapes</param>
        /// <returns>A random Shape</returns>
        public static Shape  GetRandomShape(int[] shapeTypes)
        {
            Shape shape;
            switch(rand.Next(shapeTypes.Min(), shapeTypes.Max() + 1))
                {
                    case 1 : 
                        shape = new Rectangle(rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble));
                        break;
                    case 2 : 
                        shape = new Ellipse(rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble));
                        break;
                    case 3:
                        shape = new Cuboid(rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble));
                        break;
                    case 4:
                        shape = new Cylinder(rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble), rand.RandomDouble(minDouble, maxDouble));
                        break;
                    case 5:
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
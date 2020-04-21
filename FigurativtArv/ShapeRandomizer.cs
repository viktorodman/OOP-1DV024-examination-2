using System;
using System.Collections.Generic;
using RandomExtension;
using System.Linq;
namespace FigurativtArv
{
    public static class ShapeRandomizer
    {
        private static double minDouble = 0.01;
        private static double maxDouble = 100.00;

        private static Random rand = new Random();

        public static Shape  GetRandomShape(int[] shapeTypes)
        {
            Shape shape;
            switch(rand.Next(shapeTypes.Min(), shapeTypes.Max() + 1))
                {
                    case 1 : 
                        shape = new Rectangle(rand.RandomNumber(minDouble, maxDouble), rand.RandomNumber(minDouble, maxDouble));
                        break;
                    case 2 : 
                        shape = new Ellipse(rand.RandomNumber(minDouble, maxDouble));
                        break;
                    case 3:
                        shape = new Cuboid(rand.RandomNumber(minDouble, maxDouble), rand.RandomNumber(minDouble, maxDouble), rand.RandomNumber(minDouble, maxDouble));
                        break;
                    case 4:
                        shape = new Cylinder(rand.RandomNumber(minDouble, maxDouble), rand.RandomNumber(minDouble, maxDouble), rand.RandomNumber(minDouble, maxDouble));
                        break;
                    case 5:
                        shape = new Sphere(rand.RandomNumber(minDouble, maxDouble));
                        break;
                    default:
                        shape = new Rectangle(1, 1);
                        break;
                }
            return shape;
        } 


    }
}
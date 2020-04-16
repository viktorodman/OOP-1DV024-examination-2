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

        /* public static List<Shape> GetRandomShapes(int numberOfShapes, string shapeType)
        {
            List<Shape> shapes = new List<Shape>();

            Random rand = new Random();
            

            if(shapeType == "2d")
            {
                shapes.Add(Enumerable.)
            } */

            /* for (int i = 0; i < numberOfShapes; i++)
            {
                switch(rand.Next(1,3))
                {
                    case 1 : 
                        shapes.Add(new Rectangle(rand.RandomNumber(minDouble, maxDouble), rand.RandomNumber(minDouble, maxDouble)));
                        System.Console.WriteLine("FROM RECTANGLE");
                        break;
                    case 2 : 
                        shapes.Add(new Ellipse(rand.RandomNumber(minDouble, maxDouble)));
                        System.Console.WriteLine("FROM Ellipse");
                        break;
                }
            }

            return shapes;  */
        /* }  */
        public static Shape2D  GetRandom2dShape()
        {
            Shape2D shape;
            switch(rand.Next(1,3))
                {
                    case 1 : 
                        shape = new Rectangle(rand.RandomNumber(minDouble, maxDouble), rand.RandomNumber(minDouble, maxDouble));
                        break;
                    case 2 : 
                        shape = new Ellipse(rand.RandomNumber(minDouble, maxDouble));
                        break;
                    default:
                        shape = new Ellipse(1,1);
                        break;
                }

            return shape;
        } 
        /* public static Shape3D  GetRandom3dShape(Random rand)
        {
            
            return shapes; 
        }  */


    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace FigurativtArv
{
    public class Application
    {
        /// <summary>
        /// An array of the values of the 2d shape types
        /// </summary>
        /// <returns></returns>
        private static int[] shapes2d = { (int)ShapeType.Rectangle, (int)ShapeType.Ellipse };

        /// <summary>
        /// An array of the values of the 2d shape types
        /// </summary>
        /// <returns></returns>
        private static int[] shapes3d = { (int)ShapeType.Cuboid, (int)ShapeType.Sphere, (int)ShapeType.Cylinder };
        /// <summary>
        /// Runs the program
        /// </summary>
        public void Run()
        {
            try
            {
                int numberOfShapes = Input.ReadNumberOfShapes();
                string shapeType = Input.ReadShapeType();

                List<Shape> shapes = new List<Shape>();
            
                shapes = ShapeRandomizer.GetRandomShapes(numberOfShapes, shapeType);

                shapes = ShapeSorter.SortShapes(shapeType, shapes);

                ShapeView.DisplayShapes(shapes, shapeType);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
            
        }

    }
}
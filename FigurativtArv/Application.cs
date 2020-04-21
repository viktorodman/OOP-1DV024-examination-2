using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FigurativtArv
{
    public class Application
    {
        private static int[] shapes2d = { (int)ShapeType.Rectangle, (int)ShapeType.Ellipse };
        private static int[] shapes3d = { (int)ShapeType.Cuboid, (int)ShapeType.Sphere, (int)ShapeType.Cylinder };
        public void Run()
        {
            int numberOfShapes = Input.ReadNumberOfShapes();
            string shapeType = Input.ReadShapeType();

            List<Shape> shapes = new List<Shape>();
           
            shapes.AddRange(Enumerable.Repeat(0, numberOfShapes).Select(x => ShapeRandomizer.GetRandomShape((shapeType == "2d") ? shapes2d : shapes3d)));

            shapes = ShapeSorter.SortShapes(shapeType, shapes);

            ShapeView.DisplayShapes(shapes);
        }

    }
}
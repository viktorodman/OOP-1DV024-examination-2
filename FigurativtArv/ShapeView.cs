using System;
using System.Collections.Generic;
namespace FigurativtArv
{
    public class ShapeView
    {
        public static void DisplayShapes(List<Shape2D> shapes)
        {
            foreach (Shape2D shape in shapes)
            {
                System.Console.WriteLine(shape.ToString("R"));
            }
        }
        public static void DisplayShapes(List<Shape3D> shapes)
        {
             foreach (Shape3D shape in shapes)
            {
                System.Console.WriteLine(shape.ToString("R"));
            }
        }
    }
}
using System;
using System.Collections.Generic;
namespace FigurativtArv
{
    public class ShapeView
    {
      
        public static void DisplayShapes(List<Shape> shapes)
        {
             foreach (Shape shape in shapes)
            {
                System.Console.WriteLine("======================");
                System.Console.WriteLine(shape.ToString("R"));
                System.Console.WriteLine("======================");

            }
        }
    }
}
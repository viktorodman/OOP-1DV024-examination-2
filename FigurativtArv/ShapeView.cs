using System;
using System.Collections.Generic;
namespace FigurativtArv
{
    /// <summary>
    /// Represents the presentation of shapes
    /// </summary>
    public static class ShapeView
    {
        /// <summary>
        /// Displays a list of shapes
        /// </summary>
        /// <param name="shapes">A list of the type shape</param>
        /// <param name="shapeType">String: 2d or 3d</param>
        public static void DisplayShapes(List<Shape> shapes, string shapeType)
        {
            string shapesString = "";

            if (shapeType =="2d")
            {
                int lineWidth = CreateTableHeader2D().Length;
                shapesString += CreateTableHeaderLine(lineWidth);
                shapesString += CreateTableHeader2D();
                shapesString += CreateTableHeaderLine(lineWidth);
            } else if(shapeType =="3d")
            {
                int lineWidth = CreateTableHeader3D().Length;
                shapesString += CreateTableHeaderLine(lineWidth);
                shapesString += CreateTableHeader3D();
                shapesString += CreateTableHeaderLine(lineWidth);
            }

            shapes.ForEach(shape => shapesString += shape.ToString("R") + "\n");
            
            System.Console.WriteLine(shapesString);
        }

        /// <summary>
        /// Creates a table header for a 2d shape
        /// </summary>
        /// <returns>A string representing a table header for a 2d shape</returns>
        public static string CreateTableHeader2D() => $"{"Shape", -15}{"Length", 15}{"Width", 15}{"Perimeter", 15}{"Area", 15}\n";

        /// <summary>
        /// Creates a table header for a 2d shape
        /// </summary>
        /// <returns>A string representing a table header for a 2d shape</returns>
        public static string CreateTableHeader3D() => $"{"Shape", -15}{"Length", 15}{"Width", 15}{"Heigth", 15}{"MantelArea", 15}{"Total S.Area", 15}{"Volume", 15}\n";
        
        /// <summary>
        /// Creates a horizontal line.
        /// </summary>
        /// <param name="lineWidth">The length of the line</param>
        /// <returns>A string x number of containing dashes</returns>
        public static string CreateTableHeaderLine(int lineWidth) => new string('-', lineWidth) +  "-\n";
    }
}
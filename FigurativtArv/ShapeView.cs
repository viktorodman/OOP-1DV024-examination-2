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
                shapesString += CreateTableHeader2D();
            } else if(shapeType =="3d")
            {
                shapesString += CreateTableHeader3D();
            } else 
            {
                throw new FormatException("shapeType must be '2d' or '3d'");
            }

            shapes.ForEach(shape => shapesString += shape.ToString("R") + "\n");
            
            System.Console.WriteLine(shapesString);
        }

        /// <summary>
        /// Creates a table header for a 2d shape
        /// </summary>
        /// <returns>A string representing a table header for a 2d shape</returns>
        public static string CreateTableHeader2D() 
        {
            string tableHeaders = $"{"Shape", -15}{"Length", 15}{"Width", 15}{"Perimeter", 15}{"Area", 15}\n";
            string headerLine = CreateTableHeaderLine(tableHeaders.Length);

            return headerLine + tableHeaders + headerLine;
        }  

        /// <summary>
        /// Creates a table header for a 2d shape
        /// </summary>
        /// <returns>A string representing a table header for a 2d shape</returns>
        public static string CreateTableHeader3D() 
        {
            string tableHeaders = $"{"Shape", -15}{"Length", 15}{"Width", 15}{"Heigth", 15}{"MantelArea", 15}{"Total S.Area", 15}{"Volume", 15}\n";
            string headerLine = CreateTableHeaderLine(tableHeaders.Length);

            return headerLine + tableHeaders + headerLine;
        } 
        
        /// <summary>
        /// Creates a horizontal line.
        /// </summary>
        /// <param name="lineWidth">The length of the line</param>
        /// <returns>A string x number of containing dashes</returns>
        public static string CreateTableHeaderLine(int lineWidth) => new string('-', lineWidth) +  "-\n";
    }
}
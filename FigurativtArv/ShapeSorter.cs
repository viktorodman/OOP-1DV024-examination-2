using System;
using System.Linq;
using System.Collections.Generic;
namespace FigurativtArv
{   
    /// <summary>
    /// Handles sorting of shapes
    /// </summary>
    public static class ShapeSorter
    {
        /// <summary>
        /// Takes a list of shapes and returns a sorted version of that list.
        /// If shapes Sorts by shape type name and then by 
        /// </summary>
        /// <param name="shapeType">String: What type of shape, 2d or 3d</param>
        /// <param name="shapes">A list of the type Shape containing the shapes to sort</param>
        /// <returns>A new list of shapes</returns>
        public static List<Shape> SortShapes(string shapeType, List<Shape> shapes)
        {
            List<Shape> sortedShapes = new List<Shape>();
            if (shapeType == "2d")
            {
                List<Shape2D> temp2DShapes = shapes.OfType<Shape2D>()
                                                .OrderBy(shape => shape.ShapeType.ToString())
                                                .ThenBy(shape => shape.Area)
                                                .ToList();
                
                temp2DShapes.ForEach(shape => sortedShapes.Add(shape));
            } else if (shapeType == "3d")
            {
                List<Shape3D> temp3DShapes = shapes.OfType<Shape3D>()
                                                .OrderBy(shape => shape.ShapeType.ToString())
                                                .ThenBy(shape => shape.Volume)
                                                .ToList();
                
                temp3DShapes.ForEach(shape => sortedShapes.Add(shape));
            } else
            {
                throw new FormatException("shapeType must be '2d' or '3d'");
            }

            return sortedShapes;
        }
    }
}
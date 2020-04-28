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
        /// </summary>
        /// <param name="shapes">A list of the type Shape containing the shapes to sort</param>
        /// <returns>A new list of shapes</returns>
        public static List<Shape> SortShapes(List<Shape> shapes)
        {
            if (shapes == null || shapes.Count < 1)
            {
                throw new InvalidOperationException("Cant sort an empty list");
            } 

            List<Shape> sortedShapes = new List<Shape>();

            if (shapes[0].Is3D)
            {
                List<Shape3D> temp3DShapes = shapes.OfType<Shape3D>()
                                                .OrderBy(shape => shape.ShapeType.ToString())
                                                .ThenBy(shape => shape.Volume)
                                                .ToList();
                
                sortedShapes.AddRange(temp3DShapes);
            } else
            {
                List<Shape2D> temp2DShapes = shapes.OfType<Shape2D>()
                                                .OrderBy(shape => shape.ShapeType.ToString())
                                                .ThenBy(shape => shape.Area)
                                                .ToList();
                
                sortedShapes.AddRange(temp2DShapes);
            } 
            return sortedShapes;
        }
    }
}
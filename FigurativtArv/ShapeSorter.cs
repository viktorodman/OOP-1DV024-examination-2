using System;
using System.Linq;
using System.Collections.Generic;
namespace FigurativtArv
{
    public static class ShapeSorter
    {
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
                List<Shape3D> temp2DShapes = shapes.OfType<Shape3D>()
                                                .OrderBy(shape => shape.ShapeType.ToString())
                                                .ThenBy(shape => shape.Volume)
                                                .ToList();
                
                temp2DShapes.ForEach(shape => sortedShapes.Add(shape));
            }
            return sortedShapes;
        }
    }
}
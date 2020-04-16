using System;
using System.Linq;
using System.Collections.Generic;

namespace FigurativtArv
{
    public class Application
    {
        /* private List<Shape> shapes = new List<Shape>() { new Rectangle(5, 5)}; */
        public void Run()
        {

           
           int numberOfShapes = Input.ReadNumberOfShapes();
           string shapeType = Input.ReadShapeType();
           
           

           if (shapeType == "2d")
            {
                
                List<Shape2D> shapes = new List<Shape2D>();
                shapes.AddRange(Enumerable.Repeat(0, numberOfShapes).Select(x => ShapeRandomizer.GetRandom2dShape()));
                ShapeView.DisplayShapes(shapes);
            }

            if (shapeType == "3d")
            {
                List<Shape3D> shapes = new List<Shape3D>();
                shapes.AddRange(Enumerable.Repeat(0, numberOfShapes).Select(x => ShapeRandomizer.GetRandom3dShape()));
                ShapeView.DisplayShapes(shapes);
            }


        }

    }
}
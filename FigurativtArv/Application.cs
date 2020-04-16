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

           List<Shape> shapes = new List<Shape>() ;
           shapes.AddRange(Enumerable.Repeat(0, 10).Select(x => ShapeRandomizer.GetRandom2dShape()));
           
            foreach (Shape2D shape in shapes)
            {
                System.Console.WriteLine(shape.Length);
            }
        }


    }
}
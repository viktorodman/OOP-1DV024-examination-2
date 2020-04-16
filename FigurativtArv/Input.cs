using System;


namespace FigurativtArv
{
    public class Input
    {
        public static string ReadShapeType() 
        {
            bool shapeTypeEntered = false;
            string shapeType = "";
            System.Console.WriteLine("Enter 2d to create 2d shapes or 3d to create 3d shapes");
            while(!shapeTypeEntered)
            {
                System.Console.Write("Shape type: ");
                shapeType = Console.ReadLine();
                if (shapeType != "2d" && shapeType != "3d")
                {
                    System.Console.WriteLine("Please enter 2d or 3d!");
                } else {
                    shapeTypeEntered = true;
                }
            }
            return shapeType;   
        }

        public static int ReadNumberOfShapes()
        {
            int numberOfShapes;
            System.Console.WriteLine("Enter the number of shapes");
            System.Console.Write("Number of shapes: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out numberOfShapes);

            while(!correctNumber || numberOfShapes <= 0)
            {
                System.Console.WriteLine("Please enter a number greater than 0");
                System.Console.Write("Number of shapes: ");
                correctNumber = int.TryParse(Console.ReadLine(), out numberOfShapes);
            }
            return numberOfShapes;
        }
    }
}
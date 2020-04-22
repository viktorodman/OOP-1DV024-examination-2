using System;


namespace FigurativtArv
{

    /// <summary>
    /// Represents user input
    /// </summary>
    public class Input
    {
        /// <summary>
        /// Prompts the user to enter a shape type
        /// The shape type can be "2d" or "3d"
        /// </summary>
        /// <returns>The entered shape type</returns>
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

        /// <summary>
        /// Prompts the user to enter the number of shapes to create
        /// The number must be greater than 0
        /// </summary>
        /// <returns>The entered number of shapes</returns>
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
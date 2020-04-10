using System;

namespace FigurativtArv
{
    public class Application
    {
        public void Run()
        {
            Cuboid c = new Cuboid(10, 10, 10);

            System.Console.WriteLine(c.ToString("G")); 
        }
    }
}
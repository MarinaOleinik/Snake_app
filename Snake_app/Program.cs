using System;

namespace Snake_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Snake";
            Point p = new Point(4, 5, '*', false);
            p.Draw(p.x,p.y,p.sym);
            
            Console.ReadLine();
        }
        
    }
}

using System;
using System.Collections.Generic;

namespace Snake_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Snake";
            Point p = new Point(4, 5, '*', false);
            p.Draw();
            List<int> numlist = new List<int>();


            Console.ReadLine();
        }
        
    }
}

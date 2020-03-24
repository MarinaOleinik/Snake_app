using System;
using System.Collections.Generic;

namespace Snake_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Snake";
            Console.SetWindowSize(101, 26);
            Point p = new Point(4, 5, '*');
            p.Draw();
            HorizontalLIne upline = new HorizontalLIne(0, 100, 0, '+');
            HorizontalLIne downline = new HorizontalLIne(0, 100, 25, '+');
            VerticalLine leftline = new VerticalLine(1, 25, 0, '+');
            VerticalLine rightline = new VerticalLine(1, 25, 100, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

            Console.ReadLine();
        }
        
        
    }
}

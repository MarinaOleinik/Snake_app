using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_app
{
    class VerticalLine: Figure
    {
       
        public VerticalLine(int yLeft, int yReight, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yLeft; y <= yReight; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        
    }
}

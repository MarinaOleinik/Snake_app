using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_app
{
    class FoodCreator//класс для создания еды
    {
        int mapW;
        int mapH;
        char sym;
        Random rand = new Random();
        public FoodCreator(int mapW, int mapH, char sym)
        {
            this.mapW = mapW;
            this.mapH = mapH;
            this.sym = sym;
        }
        public Point CreateFood()
        {
            int x = rand.Next(2, mapH - 2);
            int y = rand.Next(2, mapH - 2);
            return new Point(x, y, sym);
        }
    }
}

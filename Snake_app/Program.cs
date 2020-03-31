using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake_app
{
    class Program
    {
        
        static void Main(string[] args)
        {   
            
            Console.Title = "Snake";
            Console.SetWindowSize(101, 26);
           
            HorizontalLIne upline = new HorizontalLIne(0, 100, 0, '+');
            HorizontalLIne downline = new HorizontalLIne(0, 100, 25, '+');
            VerticalLine leftline = new VerticalLine(1, 25, 0, '+');
            VerticalLine rightline = new VerticalLine(1, 25, 100, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

            Point p = new Point(4, 5, '*');
            
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(101, 26, '¤');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                
                
            }
                    
            //Console.ReadLine();
        }
        
        
    }
}

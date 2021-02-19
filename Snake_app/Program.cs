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
            Parametrs settings = new Parametrs();
            Sounds sound = new Sounds(settings.GetResourceFolder());
            sound.Play("stardust.mp3");

            Point p = new Point(4, 5, '*');         
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(101, 26, '¤');
            Point food = foodCreator.CreateFood();
            food.Draw();
            Score score = new Score(0,1);//score =0, level=1
            score.ScoreWrite();           
            while (true)
            {
                if (snake.Eat(food))
                {
                    score.ScoreUp();
                    score.ScoreWrite();
                    food = foodCreator.CreateFood();
                    food.Draw();
                    sound.Stop("stardust.mp3");
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(400);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
                
                
            }
                    
            //Console.ReadLine();
        }
        
        
    }
}

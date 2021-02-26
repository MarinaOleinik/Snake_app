using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_app
{
    public class Start
    {
        public ConsoleKeyInfo key;
        public Start()
        {           
        }
        int valik = 0;
        public int choice()
        {
            
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("------------------");
            Console.WriteLine("Start game - S\nStop game - Q");
            Console.WriteLine("------------------");
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.S)
            {
                valik = 1;
            }
            else if (key.Key == ConsoleKey.Q)
            {
                valik = 2;
            }
            return valik;
        }

        public void Game_stop()
        {
            Console.Clear();
            Console.WriteLine("Exit");
            Console.Beep();

        }
    }
}

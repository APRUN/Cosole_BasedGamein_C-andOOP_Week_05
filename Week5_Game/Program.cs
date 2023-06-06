using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_Game.GL;
using Week5_Game.UI;

namespace Week5_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Maze();
            Player_function.Print_player();
            while(true)
            {
                if (Enemy_function.Enemy_health > 0)
                {
                    Enemy_function.print_enemy();
                    Bullets.player_bulletdetection(Player_function.p);
                }
                if(EZInput.Keyboard.IsKeyPressed(EZInput.Key.Space))
                {
                    Player_function.Generate_bullet();
                }

                if(EZInput.Keyboard.IsKeyPressed(EZInput.Key.UpArrow))
            {
                Player_function.Move_Up();
                    Thread.Sleep(50);
            }

                if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.DownArrow))
                {
                    Player_function.Move_Down();
                    Thread.Sleep(50);
                }

                if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.RightArrow))
                {
                    Player_function.Move_Right();
                    Thread.Sleep(50);
                }

                if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.LeftArrow))
                {
                    Player_function.Move_Left();
                    Thread.Sleep(50);
                }
                Bullets.Move_bullet();
                Bullets.Bullet_Collision();
                Bullets.Check_enemyHealth();
            }
        }
        static void Maze()
        {
            Print_Maze.Print();
        }
    
    }
}



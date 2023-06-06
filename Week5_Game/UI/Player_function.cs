using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_Game.GL;

namespace Week5_Game.UI
{
    class Player_function
    {
        public static int health=10;
        public static int Score=0;
        public static Player_Axis p=new Player_Axis();

        public static void Print_player()
        {
            char[,] player = { {' ','O',' '},
                               {'-','|','-'},
                               {'_',' ','_'}
            };
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(p.player_X, p.player_Y+i);
                for (int u = 0; u < 3; u++)
                {
                    Console.Write(player[i, u]);
                }
            }
        }
        public static void Erase_Player()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(p.player_X, p.player_Y+i);
                for (int u = 0; u < 3; u++)
                {
                    Console.Write(" ");
                }
            }
        }
        public static void Move_Up()
        {
            if (p.player_Y - 2 > 7)
            {
                Erase_Player();
                p.player_Y = p.player_Y - 2;
                Print_player();
            }
        }
        public static void Move_Down()
        {
            if(p.player_Y+4<34)
            {
            Erase_Player();
            p.player_Y = p.player_Y + 1;
            Print_player();
            }
        }
        public static void Move_Right()
        {
            if(p.player_X+3<115)
            {
            Erase_Player();
            p.player_X = p.player_X + 3;
            Print_player();
            }
        }
        public static void Move_Left()
        {
            if(p.player_X-2>26)
            {

            Erase_Player();
            p.player_X = p.player_X - 2;
            Print_player();
            }
        }
        public static void Generate_bullet()
        {
            p_BuletAxis pb = new p_BuletAxis();
            pb.bullet_X = p.player_X + 5;
            pb.bullet_Y = p.player_Y + 1;
            Console.SetCursorPosition(pb.bullet_X, pb.bullet_Y);
            Bullets.P_bulletList.Add(pb);
            Console.Write("-");
        }

    }
}

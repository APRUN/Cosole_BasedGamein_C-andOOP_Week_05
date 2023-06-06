using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_Game.GL;

namespace Week5_Game.UI
{
    class Enemy_function
    {
        public static int Enemy_health = 100;
        public static Enemy_Axis ee = new Enemy_Axis();
        public static void print_enemy()
        {
            char[,] enemy = { {'-','O','-'},
                               {'_','|','_'},
            };
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(ee.enemy_X, ee.enemy_Y+i);
                for (int u = 0; u < 3; u++)
                {
                    Console.Write(enemy[i, u]);
                }
                
            }
        }
        public static void Erase_enemy()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(ee.enemy_X, ee.enemy_Y+i);
                for (int u = 0; u < 3; u++)
                {
                    Console.Write(" ");
                }
            }
        }
        
    }
}

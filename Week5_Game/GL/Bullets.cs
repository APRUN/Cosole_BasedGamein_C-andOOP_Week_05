using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_Game.UI;

namespace Week5_Game.GL
{
    class Bullets
    {
        public static List<p_BuletAxis> P_bulletList = new List<p_BuletAxis>();

        public static void Move_bullet()
        {
            foreach (var lala in P_bulletList)
            {
                Console.SetCursorPosition(lala.bullet_X, lala.bullet_Y);
                Console.Write(" -");
                lala.bullet_X++;
            }
        }
        public static void Bullet_Collision()
        {
            foreach(var lolo in P_bulletList)
            {

            if (Print_Maze.maze_array[lolo.bullet_Y, lolo.bullet_X -23] != ' ')
            {
                Console.SetCursorPosition(lolo.bullet_X, lolo.bullet_Y);
                Console.Write("  ");
                P_bulletList.Remove(lolo);
                break;
            }
            }
        }
        public static void player_bulletdetection(Player_Axis player)
        {
            foreach(var lala in P_bulletList)
            {
                if((lala.bullet_X==Enemy_function.ee.enemy_X-2&& lala.bullet_Y == Enemy_function.ee.enemy_Y + 1))
                {
                    Enemy_function.Enemy_health = Enemy_function.Enemy_health - 1;
                    Console.SetCursorPosition(lala.bullet_X, lala.bullet_Y);
                    Console.Write("  ");
                    Console.SetCursorPosition(27,1);
                    Console.WriteLine("Enemy Health: " + Enemy_function.Enemy_health);
                    P_bulletList.Remove(lala);
                    break;
                }
            }
        }
        public static void Check_enemyHealth()
        {
            if(Enemy_function.Enemy_health<1)
            {
                Enemy_function.Erase_enemy();
            }
        }

    }
}

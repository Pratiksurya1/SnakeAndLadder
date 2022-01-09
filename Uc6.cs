using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderGame
{
    public class Uc6
    {
        int flag = 0;
        int position = 0;
        public void Game()
        {
            Random random = new Random();

            while (true)
            {
                int dice = random.Next(6)+1;
                flag++;
                int firstPostion = position;
                position = position + dice;
                if (position > 100)
                    position = firstPostion;

                else if (position == 100)
                {
                    Console.WriteLine("Player position is " + position);
                    break;
                }
                Console.WriteLine("Player position is " + position);

            }
        }
    }
}
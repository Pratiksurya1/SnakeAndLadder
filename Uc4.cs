using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderGame
{
    public class Uc4
    {
        int position = 0;
        public void Game()
        {
            Random random = new Random();

            while (true)
            {
                int dice = random.Next(6) + 1;
                int firstPostion = position;
                position = position + dice;
                if (position > 100)
                    position = firstPostion;

                if (position == 100)
                {
                    Console.WriteLine("you win game position is " + position);
                    break;
                }
                else if (position <= 100)
                    Console.WriteLine(dice);
            }
        }
    }
}
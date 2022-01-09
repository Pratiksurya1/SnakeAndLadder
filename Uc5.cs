using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderGame
{
    public class Uc5
    {
        int position = 0;
        public void Game()
        {
            int firstPostion = 0;
            Random random = new Random();

            while (true)
            {
                int dice = random.Next(6)+1;
                firstPostion = position;
                position = position + dice;
                if (position > 100)
                {
                    Console.WriteLine("your position is " + firstPostion);
                    Console.WriteLine("for win player want " + (100 - firstPostion) + " but the have " + dice);
                    position = firstPostion;
                }
                else if (position == 100)
                {
                    Console.WriteLine("your position is " + position);
                    Console.WriteLine("for win player want " + (100 - firstPostion) + " and value of dice " + dice);
                    Console.WriteLine("You win the game");
                    break;
                }
            }
        }
    }
}
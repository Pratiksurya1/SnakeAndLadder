using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderGame
{
    internal class Uc3
    {
        int flag = 0;
        int position = 0;
        public void Game()
        {
            Random random = new Random();

            while (true)
            {
                int check=random.Next(3);
                int dice = random.Next(6)+1;
                if (check==0)
                {
                    Console.WriteLine("No play player condition\n");
                    position = position;
                }
                else if(check==1)
                {
                    Console.WriteLine("player got lader");
                    position=position+dice;
                    Console.WriteLine("dice vlaue "+dice);
                    Console.WriteLine("player position :- " + position+"\n");
                }else if(check==2)
                {
                    Console.WriteLine("player got snake");
                    if(position !=0)
                    position=position-dice;
                    Console.WriteLine("player position :- " + position+"\n");
                }
                if (position>=100)
                {
                    Console.WriteLine("player go 100 position");
                    break;
                }

            }
     
        }
    }
}

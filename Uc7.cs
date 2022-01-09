using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderGame
{
    public class Uc7
    {
        int playerOnePosition1 = 0;
        int playerOnePosition2 = 0;
        int playerTwoPosition1 = 0;
        int playerTwoPosition2 = 0;
        // int flag=0;
        Random random;

        public Uc7()
        {
            random = new Random();
        }
        int PlayerOne()
        {
            Console.WriteLine("Player one play..");
            int dice = random.Next(6) + 1;
            Console.WriteLine("Dice vlaue "+dice);
            //flag++;
            playerOnePosition1 = playerOnePosition2;
            playerOnePosition2 = playerOnePosition2 + dice;
            if (playerOnePosition2 > 100)
                playerOnePosition2 = playerOnePosition1;

            Console.WriteLine(playerOnePosition2);
            return playerOnePosition2;
        }

        int PlayerTwo()
        {
            Console.WriteLine("Player Two play..");
            int dice = random.Next(6) + 1;
            Console.WriteLine("Dice vlaue " + dice);
            // flag++;
            playerTwoPosition1 = playerTwoPosition2;
            playerTwoPosition2 = playerTwoPosition2 + dice;
            if (playerTwoPosition2 > 100)
                playerTwoPosition2 = playerTwoPosition1;

            Console.WriteLine(playerTwoPosition2);
            return playerTwoPosition2;
        }
        public void Game()
        {
            while (true)
            {

                PlayerOne();
                PlayerTwo();

                if (playerOnePosition2 == 100)
                {
                    Console.WriteLine("Player one wine and position " + playerOnePosition2);
                    break;
                }
                else if (playerTwoPosition2 == 100)
                {
                    Console.WriteLine("Player two wine and position " + playerTwoPosition2);
                    break;
                }
            }

        }
    }
}
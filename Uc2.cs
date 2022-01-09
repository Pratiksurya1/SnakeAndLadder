using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderGame
{
    public class Uc2
    {
        public void Game()
        {
            Random random = new Random();
            int dic = random.Next(6) + 1;
            Console.WriteLine("Player roll the dice value " + dic);
        }
    }
}
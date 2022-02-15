using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Snake_Ladder
    {
        public static void Die_Roll()
        {
            int position = 0;
            const int NOPLAY = 0, LADDER = 1, SNAKE = 2;
            Random random = new Random();
            int noOnDie=random.Next(1,7);
            int option=random.Next(3);
            Console.WriteLine($"Initial Position Of Player is {position}");
            Console.WriteLine($"Number On Die Is {noOnDie}");
            switch (option)
            {
                case NOPLAY :
                    Console.WriteLine("POSITION " + position);
                    break;
                case LADDER:
                    position = position + noOnDie;
                    break;
                case SNAKE:
                    position = position - noOnDie;
                    break;
            }
            Console.WriteLine($"Position Of Player After Die Roll is {position}");
        }
    }
}

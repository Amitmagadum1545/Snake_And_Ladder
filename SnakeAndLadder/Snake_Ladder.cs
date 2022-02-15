using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Snake_Ladder
    {
        public static void Winning_position_is100()
        {
            int position = 0, dieCount = 0;
            const int NOPLAY = 0, LADDER = 1, SNAKE = 2;
            Random random = new Random();
            
            Console.WriteLine($"Initial Position Of Player is {position}");
            
            while (position < 100)
            {
                int noOnDie = random.Next(1, 7);
                dieCount++;
                int option = random.Next(3);
                Console.WriteLine($"Number On Die Is {noOnDie}");
                switch (option)
                {
                    case NOPLAY:
                        Console.WriteLine("No Play And POSITION is " + position);
                        break;
                    case LADDER:
                        Console.WriteLine($"It is Ladder And Position is {position = position + noOnDie} ");
                        break;
                    case SNAKE:
                        Console.WriteLine($"It is Snake And Position is { position = position - noOnDie} ");
                        break;
                }
                if (position<0)
                {
                    position = 0;
                }
                else if (position > 100)
                {
                    position -= noOnDie;
                    Console.WriteLine("position" + position);
                }
                Console.WriteLine($"Position Of Player After Die Roll is {position}");
                
            }
            Console.WriteLine($"Total Number Of Times Die Rolled To Win The Game Is {dieCount}");
        }
    }
}

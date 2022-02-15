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
            Random random = new Random();
            int check=random.Next(1,7);
            Console.WriteLine($"Initial Position Of Player is {position}");
            Console.WriteLine($"Random Number Is {check}");
        }
    }
}

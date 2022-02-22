using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To Snake And Ladder Simulator");

            Console.WriteLine($"Initial Position Of Player1 And Player2 is : 0 0");
            
            Snake_Ladder.SwitchPlayer();
            
            Console.ReadLine();
        }
    }
}
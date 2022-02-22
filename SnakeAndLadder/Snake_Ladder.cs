using System;

namespace SnakeAndLadder
{
    internal class Snake_Ladder
    {
        public const int NOPLAY = 0, LADDER = 1, SNAKE = 2, WINNINGPOSITION = 100;

        public static int noOnDie, player=1;

        public static int[] position = new int[3] { 0, 0, 0 };
        public static int[] playerdieCount = new int[3] { 0, 0, 0 };


        public static Random random = new Random();

        public static void PlaySnakeAndLadder(int playerNum)
        {
            noOnDie = random.Next(1, 7);
            int option = random.Next(3);
            Console.WriteLine("\nPlayer {0} get ts Dice value: {1}", playerNum, noOnDie);
            playerdieCount[playerNum]++;
            switch (option)
            {
                case NOPLAY:
                    Console.WriteLine("No Play And POSITION is " + position[playerNum]);
                    break;
                case LADDER:
                    position[playerNum] += noOnDie;
                    if (position[playerNum] > 100)
                    {
                        position[playerNum] -= noOnDie;
                    }
                    Console.WriteLine($"It is Ladder And Position is {position[playerNum]} ");
                    if (position[playerNum] == WINNINGPOSITION)
                    {
                        Console.WriteLine("Player {0} won the game with dice count of :{1}", playerNum, playerdieCount[playerNum]);
                        break;
                    }
                    PlaySnakeAndLadder(playerNum);
                    break;
                case SNAKE:
                    position[playerNum] -= noOnDie;
                    if (position[playerNum] < 0)
                    {
                        position[playerNum] = 0;
                    }
                    Console.WriteLine($"It is Snake And Position is { position[playerNum]} ");
                    break;
            }
        }
        public static void SwitchPlayer()
        {
            while (position[1] < WINNINGPOSITION && position[2] < WINNINGPOSITION)
            {
                if (player == 1)
                {
                    PlaySnakeAndLadder(1);
                    player = 2;
                    continue;
                }
                if(player==2)
                {
                    PlaySnakeAndLadder(2);
                    player = 1;
                    continue;                
                }
            }
        }
    }
}

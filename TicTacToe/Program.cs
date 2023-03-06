using System;

namespace TicTacToe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Start.Logo();
            string player = Player.ChoosePlayer();
            string myPlayer = player;

            Console.Clear();
            bool gameOn = true;

            string[] p = Start.NewPositions();
            string[] positions = Start.NewGridPositions();
            int count = p.Length - 1;
            Grid.Gridstart(positions);

            while (gameOn)
            {
                string choice;
                if (myPlayer == player) choice = Player.ChoosePosition(p);
                else choice = Player.ComputerPlayer(p);

                count--;

                Grid.GridGame(positions, choice, player);

                if (Check.GameOver(positions, player) || count < 0)
                {
                    if (count < 0) Console.WriteLine("\n*******    -.-    ********\n");
                    else Check.Win(myPlayer, player);
                    if (Player.ContinueGame())
                    {
                        Console.Clear();
                        p = Start.NewPositions();
                        positions = Start.NewGridPositions();
                        count = p.Length - 1;
                        player = Player.ChoosePlayer();
                        Grid.Gridstart(positions);
                    }
                    else
                    {
                        Console.Clear();
                        Check.Exit();
                        gameOn = false;
                    }
                }
                player = Player.TurnPlayer(player);
            }
            
        }
    }
}

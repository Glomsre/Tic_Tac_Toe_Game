using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Player
    {
        public static string ChoosePlayer()
        {
             
            string player = "";
            do
            {
                Console.WriteLine("Choose player\n\nPlayer 1 -> 1\nPlayer 2 -> 2");
                player = Console.ReadLine();
            } while (player != "1" && player != "2");

            if (player == "1") player = "X";
            else player = "O";
            return player;
        }
        public static string TurnPlayer(string player)
        {
            if (player == "X") return "O";
            else return "X";
        }
        public static string ChoosePosition(string[] p)
        {
            
            string choice;
            bool res;
            do
            {
                Console.Write($"\n\n  {p[0]} {p[1]} {p[2]}\n\n  {p[3]} {p[4]} {p[5]}\n\n  {p[6]} {p[7]} {p[8]}\n\nChoose a position: ");
                choice = Console.ReadLine();

                res = Check.CheckChoice(choice);
                p[int.Parse(choice)] = " ";
                
            } while (!res);
            return choice;
        }
        public static string ComputerPlayer(string[] p)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, p.Length);
            if (p[num] == " ")
            {
                return ComputerPlayer(p);
            }
            else
            {
                p[num] = " ";
                return Convert.ToString(num);
            }
        }
        public static bool ContinueGame()
        {
            Console.Write("Do you want to play again?: \"y\" or \"n\":  ");
            switch (Console.ReadLine())
            {
                case "n":
                    return false;
                case "y":
                    return true;
                default:
                    Console.WriteLine("Invalid choice.");
                    return ContinueGame();
            }
        }
    }
}

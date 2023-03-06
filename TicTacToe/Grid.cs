using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Grid
    {
        public static void Gridstart(string[] positions)
        {
            Console.Clear();
            string[] grid =
                 {
                     "___________________",
                     "|     |     |     |",
                     $"|  {positions[0]}  |  {positions[1]}  |  {positions[2]}  |",
                     "|_____|_____|_____|",
                     "|     |     |     |",
                     $"|  {positions[3]}  |  {positions[4]}  |  {positions[5]}  |",
                     "|_____|_____|_____|",
                     "|     |     |     |",
                     $"|  {positions[6]}  |  {positions[7]}  |  {positions[8]}  |",
                     "|_____|_____|_____|"
                     };

            foreach (string ele in grid) Console.WriteLine(ele);
            foreach (string ele in positions) Console.WriteLine(ele);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void GridGame(string[] positions, string choice, string player)
        {
            Console.Clear();
            if (positions[int.Parse(choice)] == " ") positions[int.Parse(choice)] = player;
            else Console.WriteLine("Ups.. Something was wrong. -.- ");

            string[] grid =
                 {
                     "___________________",
                     "|     |     |     |",
                     $"|  {positions[0]}  |  {positions[1]}  |  {positions[2]}  |",
                     "|_____|_____|_____|",
                     "|     |     |     |",
                     $"|  {positions[3]}  |  {positions[4]}  |  {positions[5]}  |",
                     "|_____|_____|_____|",
                     "|     |     |     |",
                     $"|  {positions[6]}  |  {positions[7]}  |  {positions[8]}  |",
                     "|_____|_____|_____|"
                     };

            foreach (string ele in grid) Console.WriteLine(ele);
            foreach (string ele in positions) Console.WriteLine(ele);

            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Check
    {
       
        public static bool CheckChoice(string choice)
        {
            
            switch (choice)
            {
                case "0":
                    return true;
                case "1":
                    return true;
                case "2":
                    return true;
                case "3":
                    return true;
                case "4":
                    return true;
                case "5":
                    return true;
                case "6":
                    return true;
                case "7":
                    return true;
                case "8":
                    return true;
                default:
                    Console.WriteLine("Invalid choice.\n\n");
                    return false;
            }
        }
        public static bool GameOver(string[] positions, string player)
        {
            if ((positions[0] == player && positions[1] == player && positions[2] == player) ||
                (positions[3] == player && positions[4] == player && positions[5] == player) ||
                (positions[6] == player && positions[7] == player && positions[8] == player) ||
                (positions[0] == player && positions[4] == player && positions[8] == player) ||
                (positions[6] == player && positions[4] == player && positions[2] == player) ||
                (positions[0] == player && positions[3] == player && positions[6] == player) ||
                (positions[1] == player && positions[4] == player && positions[7] == player) ||
                (positions[2] == player && positions[5] == player && positions[8] == player))
            {
                return true;
            }
            return false;
        }
        public static void Win(string myPlayer, string player)
        {
            if(myPlayer == player) Console.WriteLine(@"                                                                            
                                                                            
____     ___                      ____              ___                     
`MM(     )M'                      `Mb(      db      )d' 68b                 
 `MM.    d'                        YM.     ,PM.     ,P  Y89                 
  `MM.  d' _____  ___   ___        `Mb     d'Mb     d'  ___ ___  __         
   `MM d' 6MMMMMb `MM    MM         YM.   ,P YM.   ,P   `MM `MM 6MMb        
    `MM' 6M'   `Mb MM    MM         `Mb   d' `Mb   d'    MM  MMM9 `Mb       
     MM  MM     MM MM    MM          YM. ,P   YM. ,P     MM  MM'   MM       
     MM  MM     MM MM    MM          `Mb d'   `Mb d'     MM  MM    MM       
     MM  MM     MM MM    MM           YM,P     YM,P      MM  MM    MM       
     MM  YM.   ,M9 YM.   MM           `MM'     `MM'      MM  MM    MM       
    _MM_  YMMMMM9   YMMM9MM_           YP       YP      _MM__MM_  _MM_      
                                                                            
                                                                            
                                                                            ");
            else Console.WriteLine(@"                                                                       
                                                                       
____     ___                      ____                                 
`MM(     )M'                      `MM'                                 
 `MM.    d'                        MM                                  
  `MM.  d' _____  ___   ___        MM        _____     ____     ____   
   `MM d' 6MMMMMb `MM    MM        MM       6MMMMMb   6MMMMb\  6MMMMb  
    `MM' 6M'   `Mb MM    MM        MM      6M'   `Mb MM'    ` 6M'  `Mb 
     MM  MM     MM MM    MM        MM      MM     MM YM.      MM    MM 
     MM  MM     MM MM    MM        MM      MM     MM  YMMMMb  MMMMMMMM 
     MM  MM     MM MM    MM        MM      MM     MM      `Mb MM       
     MM  YM.   ,M9 YM.   MM        MM    / YM.   ,M9 L    ,MM YM    d9 
    _MM_  YMMMMM9   YMMM9MM_      _MMMMMMM  YMMMMM9  MYMMMM9   YMMMM9  
                                                                       
                                                                       
                                                                       ");


        }
        public static void Exit()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                                                                         
   _|_|_|    _|_|      _|_|    _|_|_|    _|_|_|    _|      _|  _|_|_|_|  
 _|        _|    _|  _|    _|  _|    _|  _|    _|    _|  _|    _|        
 _|  _|_|  _|    _|  _|    _|  _|    _|  _|_|_|        _|      _|_|_|    
 _|    _|  _|    _|  _|    _|  _|    _|  _|    _|      _|      _|        
   _|_|_|    _|_|      _|_|    _|_|_|    _|_|_|        _|      _|_|_|_|  
                                                                         
                                                                         ");
        }
        
    }
}

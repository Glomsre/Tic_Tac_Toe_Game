using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Start
    {
        public static string[] NewPositions()
        {
            string[] p = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
            return p;
        }
        public static string[] NewGridPositions()
        {
            string[] positions = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            return positions;
        }
        public static void Logo()
        {
            Console.WriteLine(@"                                                                                                       
 _|_|_|_|_|  _|_|_|    _|_|_|      _|_|_|_|_|    _|_|      _|_|_|      _|_|_|_|_|    _|_|    _|_|_|_|  
     _|        _|    _|                _|      _|    _|  _|                _|      _|    _|  _|        
     _|        _|    _|                _|      _|_|_|_|  _|                _|      _|    _|  _|_|_|    
     _|        _|    _|                _|      _|    _|  _|                _|      _|    _|  _|        
     _|      _|_|_|    _|_|_|          _|      _|    _|    _|_|_|          _|        _|_|    _|_|_|_|  
                                                                                                       
                                                                                                       ");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}

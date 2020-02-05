using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_TicTacToe
{
    class WinnerCombinations
    {
        int [,] winnerCombinations = new int[,] {{1,2,3},{4,5,6},{7,8,9},{1,4,7},{2,5,8},{3,6,9},{1,5,9},{3,5,7}};

        public static void WinnerCombinations()
        {
            foreach (var combination in winnerCombinations)
            {
                if (thisComb == winnerCombinations[1, combination - 1])
                {

                }
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Tre_på_Rad
{
    class BoardView
    {
        private static void show(BoardModel boardModel)
        {
            var boardModelContent = boardModel.content;
            
            Console.WriteLine(┌─────┐);
            Console.WriteLine(│o    │);
            Console.WriteLine(│    o│);
            Console.WriteLine(│× ×  │);
            Console.WriteLine(└─────┘);
                
    }
}

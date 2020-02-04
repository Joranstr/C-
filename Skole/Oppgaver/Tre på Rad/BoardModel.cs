using System;
using System.Collections.Generic;
using System.Text;

namespace Tre_på_Rad
{
    class BoardModel
    {
        public bool IsGameStopped { get; private set; }
        public CellContent[] content { get; private set; }

        public BoardModel()
        {
            content = new CellContent[9];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public struct ChessCell
    {
        public const char BLACK_CELL_SYMBOL = '*';
        public const char WHITE_CELL_SYMBOL = ' ';

        private readonly  bool _isAsterisk;
        private readonly uint _coordinateX;
        private readonly uint _coordinateY;
        
        public ChessCell(bool isBlack, uint xCord, uint yCord)
        {
             _isAsterisk = isBlack;
            _coordinateX = xCord;
            _coordinateY = yCord;
        }

        public bool IsAsterisk
        {
            get
            {
                return _isAsterisk;
            }
        }

        public uint XCord
        {
            get
            {
                return _coordinateX;
            }
        }

        public uint YCord
        {
            get
            {
                return _coordinateY;
            }
        }
        
        public override string ToString()
        {
            char simb = WHITE_CELL_SYMBOL;

            if (this.IsAsterisk)
            {
                simb = BLACK_CELL_SYMBOL;
            }

            return String.Format(simb.ToString());
        }
    }
}

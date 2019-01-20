using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ChessBoard : IChessBoard
    {
        private ChessCell[] _board;

        ChessCell IChessBoard.this[int index]
        {
            get
            {
                return _board[index];
            }
        }             

        int IChessBoard.GetLength
        {
            get
            {
                return _board.Length;
            }
        }

        void IChessBoard.CreateField(uint boardLength, uint boardHeigh)
        {
            bool isAsterist = true;

            _board = new ChessCell[boardLength * boardHeigh];

            uint k = 0;

            for (uint i = 0; i < boardLength; i++)
            {
                for (uint j = 0; j < boardHeigh; j++)
                {
                    _board[k] = new ChessCell(isAsterist, i, j);
                    k++;
                    isAsterist = !isAsterist;
                }
            }

        }
                
    }
}


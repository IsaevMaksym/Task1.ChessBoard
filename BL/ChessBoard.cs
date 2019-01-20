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

        void IChessBoard.CreateField(uint boardLength, uint boardWidth)
        {
            bool isAsterist = true;

            _board = new ChessCell[boardLength * boardWidth];

            uint k = 0;

            for (uint i = 0; i < boardLength; i++)
            {
                for (uint j = 0; j < boardWidth; j++)
                {
                    _board[k] = new ChessCell(isAsterist, i, j);
                    k++;
                    isAsterist = !isAsterist;
                }
            }

        }

        bool[] IChessBoard.GetChessBoolField()
        {
            bool[] gameField = new bool[_board.Length];

            for (int i = 0; i < gameField.Length; i++)
            {
                gameField[i] = _board[i].IsAsterisk;
            }

            return gameField;
        }

    }
}


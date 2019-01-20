using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using ChessView;
using ChessController.Utilities;

namespace ChessController
{
    public class Controller : IController
    {
        const string ERROR_MESSEGE = "Can't validate data. Please try again";

        private readonly IVIewer _viewer;
        private IChessBoard _chessBoard;
        private uint _boardLength;
        private uint _boardWidth;

        public Controller()
            : this(new ConsoleIO(), new ChessBoard())
        {          
        }

        public Controller(IVIewer viewer, IChessBoard chessBoard)
        {
            _viewer = viewer;
            _chessBoard = chessBoard;
        }

        void IController.Run(string[] args)
        {
            if (args.Length < 2)
            {
                _viewer.ShowRules();
            }
            else if (ArgsValidator.ValidateArgs(args, out _boardLength, out _boardWidth))
            {
                _chessBoard.CreateField(_boardLength, _boardWidth);
                _viewer.ShowGameField(_chessBoard.GetChessBoolField(), _boardWidth);
            }
            else
            {
                _viewer.ShowMessege(ERROR_MESSEGE);
                _viewer.ShowRules();
            }
        }

    }
}

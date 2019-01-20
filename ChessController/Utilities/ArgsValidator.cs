using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessController.Utilities
{
    public static class ArgsValidator
    {
        const int MIN_ARGS_LENGTH = 2;

        public static bool ValidateArgs(string[] args, out uint boardLength, out uint boardWidth)
        {
            bool IsValidated = false;

            if (args.Length < MIN_ARGS_LENGTH)
            {
                boardWidth = 0;
                boardLength = 0;
                return IsValidated;
            }
            else if (ParseInsertedArgs(args, out boardLength, out boardWidth))
            {
                IsValidated = true;
            }

            return IsValidated;
        }

        private static bool ParseInsertedArgs(string[] args, out uint boardLength, out uint boardWidth)
        {
            boardLength = 0;
            boardWidth = 0;
            bool isParsed = false;

            if ((uint.TryParse(args[0], out boardLength) && (uint.TryParse(args[1], out boardWidth)))
                && (boardLength > 0 && boardWidth > 0))
            {
                isParsed = true;
            }

            return isParsed;
        }
    }
}

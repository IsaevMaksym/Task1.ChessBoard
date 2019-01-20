using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;


namespace ChessView
{
    public interface IVIewer
    {
        void ShowRules();             

        void ShowGameField(IChessBoard board);

        void ShowMessege(string s);
    }
}

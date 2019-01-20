using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessView
{
    public interface IVIewer
    {
        void ShowRules();

        void ShowGameField(bool[] chessBoard, uint Width);

        void ShowMessege(string s);
    }
}

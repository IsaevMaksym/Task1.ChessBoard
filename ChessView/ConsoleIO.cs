using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessView
{
    public class ConsoleIO : IVIewer
    {
        const string RULES = "Insert two numbers to create chess board with requered parametrs(Length X Width).";
        const string PRESS_ANY_KEY = "Press any key...";
        const char WHITE_CELL = ' ';
        const char BLACK_CELL = '*';

        public void ShowGameField(bool[] chessBoard, uint Width)
        {
            int Heigh = chessBoard.Length / (int)Width;

            Console.SetCursorPosition(0, Heigh);

            for (int i = 0; i < Heigh; i++)
            {
                for (int j = 0; j < Width; j++)
                {                    
                    if (chessBoard[i + j])
                    {
                        Console.Write(BLACK_CELL);
                    }
                    else
                    {
                        Console.Write(WHITE_CELL);
                    }
                  
                }
                Console.CursorTop--;
                Console.CursorLeft=0;
            }

        }

        public void ShowMessege(string s)
        {
            Console.WriteLine(s);
        }

        public void ShowRules()
        {
            Console.WriteLine(RULES);
            Console.WriteLine(PRESS_ANY_KEY);
            Console.ReadKey();
        }
    }
}

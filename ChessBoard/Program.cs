using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessController;


namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {

            IController controller = new Controller();
            controller.Run(args);
            Console.ReadKey();
        }
    }
}

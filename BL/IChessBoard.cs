﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IChessBoard
    {
        void CreateField(uint boardLength, uint boardWidth);

        bool[] GetChessBoolField();

       
    }
}

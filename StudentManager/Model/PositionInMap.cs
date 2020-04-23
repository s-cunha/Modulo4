using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    public struct PositionInMap
    {
        public int PosX { get; }
        public int PosY { get; }
        public object Value { get; }

        public override string ToString()
        {
            return $"[{PosX}{PosY} - {Value}]";
        }

        public PositionInMap(int posX,int posY,object value)
        {
            PosX = posX;
            PosY = posY;
            Value = value;
        }

    }
}

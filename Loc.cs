using System.Diagnostics;

namespace Battleship
{
    internal class Loc
    {
        public readonly uint row, column;

        public Loc(uint row, uint column)
        {
            this.row = row;
            this.column = column;
        }
    }
}

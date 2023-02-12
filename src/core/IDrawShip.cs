using Battleship.Utils;

namespace Battleship.Core
{
    public interface IDrawShip
    {
        uint Size { get; }
        string Name { get; }
        ShipType Type { get; }
        Location InitCell { get; }
        bool IsVertical { get; }

        bool IsOccupiedCell(Location cell);
        bool IsSunk();
    }
}

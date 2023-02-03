using System.Collections.Generic;
using System.Diagnostics;

namespace Battleship
{
    internal class Ship
    {
        public uint Size { get; }
        public string Name { get; }
        public ShipType Type { get; }
        public Loc InitCell { get; private set; }
        public bool IsVertical { get; private set; }

        private bool isPositionLocked;
        private HashSet<Loc> occupiedCells;
        private HashSet<Loc> damagedParts;

        public Ship (ShipType type, uint size, string name)
        {
            Type = type;
            Size = size;
            Name = name;

            isPositionLocked = false;
            occupiedCells = new HashSet<Loc>();
            damagedParts = new HashSet<Loc>();

            InitCell = new Loc(0, 0);
            IsVertical = true;
        }

        public void DamagePart(Loc cell)
        {
            Debug.Assert(IsOccupiedCell(cell));
            Debug.Assert(!damagedParts.Contains(cell));
            damagedParts.Add(cell);
        }

        public bool IsOccupiedCell(Loc cell)
        {
            return occupiedCells.Contains(cell);
        }

        public bool IsSunk()
        {
            return Size == damagedParts.Count;
        }

        public void LockPosition()
        {
            isPositionLocked = true;
        }

        public void RenewPosition(Loc newInitCell)
        {
            if (isPositionLocked) 
                return;

            if (isValidPlacement(newInitCell, IsVertical))
                throw new InvalidShipPlacementException();

            InitCell = newInitCell;
            setOccupiedCells();
        }

        public void SwitchOrientation()
        {
            if (isPositionLocked)
                return;

            if (isValidPlacement(InitCell, !IsVertical))
                throw new InvalidShipPlacementException();

            IsVertical = !IsVertical;
            setOccupiedCells();
        }

        private void setOccupiedCells()
        {
            occupiedCells.Clear();

            if (IsVertical)
                for (uint row = InitCell.row; row < InitCell.row + Size; row++)
                    occupiedCells.Add(new Loc(row, InitCell.column));
            else
                for (uint column = InitCell.column; column < InitCell.column + Size; column++)
                    occupiedCells.Add(new Loc(InitCell.row, column));
        }

        private bool isValidPlacement(Loc initCell, bool isVertical)
        {
            return (isVertical && initCell.row + Size <= GameState.gridDimension) && 
                (!isVertical && initCell.column + Size <= GameState.gridDimension);
        }
    }

    public enum ShipType
    {
        Carrier,
        Battleship,
        Cruiser,
        Submarine
    }
}

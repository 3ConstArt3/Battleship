using System.Collections.Generic;
using System.Diagnostics;

namespace Battleship
{
    /// <summary>
    /// Represents a generic ship and holds all necessary information 
    /// about its type, state and position on the battlefield.
    /// </summary>
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

        private static readonly Dictionary<ShipType, uint> shipSizes = new Dictionary<ShipType, uint>() 
        {
            { ShipType.Carrier, 5 },
            { ShipType.Battleship, 4 },
            { ShipType.Cruiser, 3 },
            { ShipType.Submarine, 2 }
        };

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="type">Ship type</param>
        /// <param name="name">Name to identify the ship</param>
        public Ship (ShipType type, string name)
        {
            Type = type;
            Name = name;
            Size = shipSizes[Type];
            
            isPositionLocked = false;
            occupiedCells = new HashSet<Loc>();
            damagedParts = new HashSet<Loc>();

            IsVertical = true;
        }

        /// <summary>
        /// Mark ship part as damaged after opponent has successfully hitted the ship
        /// </summary>
        /// <param name="cell">Battlefield cell opponent has shot</param>
        public void DamagePart(Loc cell)
        {
            Debug.Assert(IsOccupiedCell(cell));
            Debug.Assert(!damagedParts.Contains(cell));
            damagedParts.Add(cell);
        }

        /// <summary>
        /// Determines whether provided battlefield cell is occupied by the ship
        /// </summary>
        /// <param name="cell">Battlefield cell</param>
        /// <returns>True if battlefield cell is occupied by the ship</returns>
        public bool IsOccupiedCell(Loc cell)
        {
            return occupiedCells.Contains(cell);
        }

        /// <summary>
        /// Determines whether provided ship part cell is damaged
        /// </summary>
        /// <param name="cell">Ship part cell</param>
        /// <returns>True if ship part cell is damaged</returns>
        public bool IsDamagedPart(Loc cell)
        {
            Debug.Assert(IsOccupiedCell(cell));
            return damagedParts.Contains(cell);
        }

        /// <summary>
        /// Determines whether the ship has any undamaged parts left 
        /// </summary>
        /// <returns>True if no undamaged ship parts are left</returns>
        public bool IsSunk()
        {
            return Size == damagedParts.Count;
        }

        /// <summary>
        /// Lock ship's position after exiting setup mode
        /// </summary>
        public void LockPosition()
        {
            isPositionLocked = true;
        }

        /// <summary>
        /// Change ship's initial cell location during setup mode
        /// </summary>
        /// <param name="newInitCell">New initial cell</param>
        /// <exception cref="InvalidShipPlacementException">Ship is out of battlefield bounds</exception>
        public void RenewPosition(Loc newInitCell)
        {
            if (isPositionLocked) 
                // not in setup mode
                return;

            if (!isValidPlacement(newInitCell, IsVertical))
                throw new InvalidShipPlacementException();

            InitCell = newInitCell;
            setOccupiedCells();
        }

        /// <summary>
        /// Switch between vertical and horizontal ship orientation during setup mode
        /// </summary>
        /// <exception cref="InvalidShipPlacementException">Ship is out of battlefield bounds</exception>
        public void SwitchOrientation()
        {
            if (isPositionLocked)
                // not in setup mode
                return;

            if (!isValidPlacement(InitCell, !IsVertical))
                throw new InvalidShipPlacementException();

            IsVertical = !IsVertical;
            setOccupiedCells();
        }

        /// <summary>
        /// Determine ship's position on the battlefield
        /// </summary>
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

        /// <summary>
        /// Check if ship is out of battlefield bounds with provided initial cell and orientation
        /// </summary>
        /// <param name="initCell">Ship's initial cell</param>
        /// <param name="isVertical">Ship's orientation</param>
        /// <returns>True if ship is validly placed on the battlefield</returns>
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
        Submarine,
        Destroyer
    }
}

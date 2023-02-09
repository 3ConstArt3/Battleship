﻿#region Imports
using System.Collections.Generic;
using System.Diagnostics;
#endregion

namespace Battleship
{

    /// <summary>
    /// Represents a generic ship and holds all necessary information 
    /// about its type, state and position on the battlefield.
    /// </summary>
    public class Ship
    {

		#region Variable Declaration
		public uint Size { get; }
        public string Name { get; }
        public ShipType Type { get; }
        public Location InitCell { get; private set; }
        public bool IsVertical { get; private set; }

        private bool isPositionLocked;
        private HashSet<Location> occupiedCells;
        private HashSet<Location> damagedParts;

        private static readonly Dictionary<ShipType, uint> shipSizes = new Dictionary<ShipType, uint>()
        {
            { ShipType.Carrier, 5 },
            { ShipType.Battleship, 4 },
            { ShipType.Cruiser, 3 },
            { ShipType.Submarine, 3 },
            { ShipType.Destroyer, 2 }
        };

        private static readonly Dictionary<ShipType, string> shipNames = new Dictionary<ShipType, string>()
        {
            { ShipType.Carrier, "Carrier" },
            { ShipType.Battleship, "Battleship" },
            { ShipType.Cruiser, "Cruiser" },
            { ShipType.Submarine, "Submarine" },
            { ShipType.Destroyer, "Destroyer" }
        };
        #endregion

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="type">Ship type</param>
        /// <param name="name">Name to identify the ship</param>
        public Ship( ShipType type )
        {
            Type = type;
            Name = shipNames[ Type ];
            Size = shipSizes[ Type ];

            isPositionLocked = false;
            occupiedCells = new HashSet<Location>();
            damagedParts = new HashSet<Location>();

            IsVertical = true;
        }

		#region Method Definitions
		/// <summary>
		/// Mark ship part as damaged after opponent has successfully hitted the ship
		/// </summary>
		/// <param name="cell">Battlefield cell opponent has shot</param>
		public void DamagePart( Location cell )
        {
            Debug.Assert( IsOccupiedCell( cell ) );
            Debug.Assert( !damagedParts.Contains( cell ) );
            damagedParts.Add( cell );
        }

        /// <summary>
        /// Determines whether provided battlefield cell is occupied by the ship
        /// </summary>
        /// <param name="cell">Battlefield cell</param>
        /// <returns>True if battlefield cell is occupied by the ship</returns>
        public bool IsOccupiedCell( Location cell ) => (occupiedCells.Contains( cell ));

		/// <summary>
		/// Determines whether provided ship part cell is damaged.
		/// </summary>
		/// <param name="cell">Ship part cell</param>
		/// <returns>True if ship part cell is damaged</returns>
		public bool IsDamagedPart( Location cell )
        {
            Debug.Assert( IsOccupiedCell( cell ) );
            return damagedParts.Contains( cell );
        }

        /// <summary>
        /// Determines whether the ship has any undamaged parts left.
        /// </summary>
        /// <returns>True if no undamaged ship parts are left</returns>
        public bool IsSunk() => (Size == damagedParts.Count);

        /// <summary>
        /// Location ship's position after exiting setup mode.
        /// </summary>
        public void LocationkPosition() { isPositionLocked = true; }

        /// <summary>
        /// Change ship's initial cell Location during setup mode.
        /// </summary>
        /// <param name="newInitCell">New initial cell</param>
        /// <exception cref="InvalidShipPlacementException">Ship is out of battlefield bounds</exception>
        public void RenewPosition( Location newInitCell )
        {
            if( isPositionLocked ) { return; }
            if( !isValidPlacement( newInitCell, IsVertical ) ) { throw new InvalidShipPlacementException(); }

            InitCell = newInitCell;
            setOccupiedCells();
        }

		/// <summary>
		/// Check if provided ship has the same orientation as this ship.
		/// </summary>
		/// <param name="ship">Provided ship</param>
		/// <returns>True if both ships have the same orientation</returns>
		public bool HasEqualOrientation( Ship ship ) => (IsVertical == ship.IsVertical);

		/// <summary>
		/// Switch between vertical and horizontal ship orientation during setup mode.
		/// </summary>
		/// <exception cref="InvalidShipPlacementException">Ship is out of battlefield bounds.</exception>
		public void SwitchOrientation()
        {
            if( isPositionLocked ) { return; }
            if( !isValidPlacement( InitCell, !IsVertical ) ) { throw new InvalidShipPlacementException(); }

            IsVertical = !IsVertical;
            setOccupiedCells();
        }

        /// <summary>
        /// Determine ship's position on the battlefield.
        /// </summary>
        private void setOccupiedCells()
        {
            occupiedCells.Clear();

            if( IsVertical )
            {
				for( var row = InitCell.row; row < InitCell.row + Size; row++ )
				{
					occupiedCells.Add( new Location( row, InitCell.column ) );
				}
				return;
			}

			for( var column = InitCell.column; column < InitCell.column + Size; column++ )
			{
				occupiedCells.Add( new Location( InitCell.row, column ) );
			}
		}

        /// <summary>
        /// Check if ship is out of battlefield bounds with provided initial cell and orientation
        /// </summary>
        /// <param name="initCell">Ship's initial cell</param>
        /// <param name="isVertical">Ship's orientation</param>
        /// <returns>True if ship is validly placed on the battlefield</returns>
        private bool isValidPlacement( Location initCell, bool isVertical )
        {
            return (isVertical && initCell.row + Size <= GameState.GridDimension) &&
                   (!isVertical && initCell.column + Size <= GameState.GridDimension);
        }
        #endregion

    }

    /// <summary>
    /// Enumerable class containing
    /// different military ship types.
    /// </summary>
    public enum ShipType
    {
        Carrier,
        Battleship,
        Cruiser,
        Submarine,
        Destroyer
    }

}
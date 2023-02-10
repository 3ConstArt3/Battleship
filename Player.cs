#region Imports
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace Battleship
{

	class Player
	{

		#region Variable Declaration
		public List<Ship> Fleet { get; } = new List<Ship>();
		private List<Location> HitBoxes { get; } = new List<Location>();
		public string Name { get; } = "";
		public uint Attempts { get; private set; } = 0;

        private bool isPositionLocked = false;
		private static readonly Random random = new Random();
		#endregion

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		/// <param name="name"></param>
		public Player( string name )
		{
			Name = name;
			constructFleet();
		}

		#region Method Definitions
		/// <summary>
		/// Check if provided cell contains a ship and
		/// damages that ship.
		/// </summary>
		/// <param name="where"></param>
		private void takeHit( Location where )
		{
			Ship ship = getShipFromCell( where );
			ship?.DamagePart( where );
		}

		/// <summary>
		/// Fires a shot towards the enemy battlefield.
		/// </summary>
		/// <param name="where"></param>
		/// <param name="enemy"></param>
		/// <exception cref="InvalidShotException"></exception>
		public void Fire( Location where, Player enemy )
		{
			checkCellsValidity( where );

			if( HitBoxes.Contains( where ) ) { throw new InvalidShotException(); }
				
			++Attempts;
			HitBoxes.Add( where );
			enemy.takeHit( where );
		}

		/// <summary>
		/// Checks if provided cell, contains a ship part.
		/// </summary>
		/// <param name="where"></param>
		/// <returns>True if ship exits in that Location, else false.</returns>
		public bool IsCellPartOfShip( Location where )
		{
			foreach( var ship in Fleet )
			{
				if( ship.IsOccupiedCell( where ) ) { return true; }	
			}
			return false;
		}

        /// <summary>
        /// Location ship's position after exiting setup mode.
        /// </summary>
        public void LocationkPosition() { isPositionLocked = true; }

        /// <summary>
        /// Places ship at given position, if it doesn't
        /// collide with another ship.
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="shipType"></param>
        public void PlaceShip( Location pos, ShipType shipType )
		{
            if ( isPositionLocked ) { return; }
            Ship selectedShip = getShipFromType( shipType );
			checkOverlap( selectedShip.Size, pos, selectedShip.IsVertical, selectedShip.Type );
			selectedShip.RenewPosition( pos );
		}

		/// <summary>
		/// Switch orientation of ship, if it doesn't
		/// collide with another ship, after the rotation.
		/// </summary>
		/// <param name="shipType"></param>
		public void RotateShip( ShipType shipType )
		{
            if ( isPositionLocked ) { return; }
            Ship selectedShip = getShipFromType( shipType );
            if ( selectedShip.InitCell == null ) { throw new InvalidShipPlacementException(); }
            checkOverlap( selectedShip.Size, selectedShip.InitCell, !selectedShip.IsVertical, selectedShip.Type );
			selectedShip.SwitchOrientation();
		}

		/// <summary>
		/// Places each ship of the Fleet, at a
		/// random Location inside the grid.
		/// </summary>
		public void RandomFleetPlacement()
		{
			foreach( var ship in Fleet )
			{
				while( true )
				{
					Location randPos = generateRandomLocation();
					try
					{
						PlaceShip( randPos, ship.Type );
						break;
					}
					catch( InvalidShipPlacementException ) {}
				}
			}
		}

		/// <summary>
		/// Creates the Fleet.
		/// </summary>
		private void constructFleet()
		{
            //foreach( var ship in Enum.GetValues( typeof( ShipType ) ) )
            //{
            //	Fleet.Add( new Ship( ship ) );
            //}
            Fleet.Add( new Ship( ShipType.Carrier ) );
            Fleet.Add( new Ship( ShipType.Battleship ) );
			Fleet.Add( new Ship( ShipType.Cruiser ) );
			Fleet.Add( new Ship( ShipType.Submarine ) );
			Fleet.Add( new Ship( ShipType.Destroyer ) );
		}

		/// <summary>
		/// Checks if the corresponding Location, is
		/// inside the grid's bounds.
		/// </summary>
		/// <param name="Location"></param>
		/// <exception cref="InvalidCellException"></exception>
		private void checkCellsValidity( Location Location )
		{
			if( Location.row > GameState.GridDimension || Location.column > GameState.GridDimension )
			{
				throw new InvalidCellException();
			}
		}

		/// <summary>
		/// Searches for a ship in the Fleet, based
		/// on its grid position.
		/// </summary>
		/// <param name="where"></param>
		/// <returns></returns>
		private Ship getShipFromCell( Location where )
		{
			checkCellsValidity( where );

			foreach( var ship in Fleet )
			{
				if( ship.IsOccupiedCell( where ) ) { return ship; }
			}
			return null;
		}

		/// <summary>
		/// Checks if 2 ships are overlaping each other.
		/// </summary>
		/// <param name="selectedShip"></param>
		private void checkOverlap( uint selectedShipSize, Location selectedShipLocation, bool selectedShipIsVertical, ShipType shipType )
		{
			foreach( var ship in Fleet )
			{
				if( shipType == ship.Type ) { continue; }
                if ( ship.InitCell == null ) { continue; }

                uint deltaColumn = ( uint )Math.Abs( selectedShipLocation.column - ship.InitCell.column );
				uint deltaRow = ( uint )Math.Abs( selectedShipLocation.row - ship.InitCell.row );

				if( selectedShipIsVertical == ship.IsVertical )
				{
					uint maxSize = Math.Max( selectedShipSize, ship.Size );

					(deltaColumn, deltaRow) = selectedShipIsVertical ? (deltaColumn, deltaRow) : (deltaRow, deltaColumn);
					checkOverlapSameOrientation( maxSize, deltaColumn, deltaRow );
				}
				else
				{
					if( selectedShipIsVertical )
					{
						if ( selectedShipLocation.row < ship.InitCell.row )
							checkOverlapDifferentOrientation( ship.Size, selectedShipSize, deltaRow, deltaColumn );
						return;
					}
					if (selectedShipLocation.column < ship.InitCell.column)
						checkOverlapDifferentOrientation( selectedShipSize, ship.Size, deltaRow, deltaColumn );
				}
			}
		}

		/// <summary>
		/// Validates if 2 ships with same orientations
		/// collide with each other.
		/// </summary>
		/// <param name="maxSize"></param>
		/// <param name="deltaDimension"></param>
		/// <exception cref="InvalidShipPlacementException"></exception>
		private void checkOverlapSameOrientation( uint maxSize, params uint[] deltaDimension )
		{
			if( deltaDimension[ 0 ] == 0 )
				if (deltaDimension[ 1 ] < maxSize)
					throw new InvalidShipPlacementException();
		}

		/// <summary>
		/// Validates if 2 ships with different orientations
		/// collide with each other.
		/// </summary>
		/// <param name="horizontalShipSize"></param>
		/// <param name="verticalShipSize"></param>
		/// <param name="deltaDimension"></param>
		/// <exception cref="InvalidShipPlacementException"></exception>
		private void checkOverlapDifferentOrientation( uint horizontalShipSize, uint verticalShipSize, params uint[] deltaDimension )
		{
			if( deltaDimension[ 0 ] < horizontalShipSize || deltaDimension[ 1 ] < verticalShipSize )
			{
				throw new InvalidShipPlacementException();
			}
		}

		/// <summary>
		/// Ship ship = from theShip in Fleet where ship.Type == shipType select theShip;
		/// Finds the corresponding ship in the Fleet.
		/// </summary>
		/// <param name="shipType"></param>
		/// <returns>Ship from Fleet with provided type</returns>
		private Ship getShipFromType( ShipType shipType ) => Fleet.Single( sampleShip => sampleShip.Type == shipType );

		/// <summary>
		/// Random Location generator.
		/// </summary>
		/// <returns>A random Location inside the grid's bounds.</returns>
		private Location generateRandomLocation() => new Location( (uint)random.Next( 0, GameState.GridDimension ),
																   (uint)random.Next( 0, GameState.GridDimension ) );
		#endregion

	}

}
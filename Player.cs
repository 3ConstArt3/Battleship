using System;
using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
	class Player
	{
		public List<Ship> Fleet { get; } = new List<Ship>();
		private List<Loc> HitBoxes { get; } = new List<Loc>();
		public string Name { get; } = "";
		public uint Attempts { get; private set; } = 0;
		private static Random random = new Random();

		public Player(string name)
		{
			Name = name;
			constructFleet();
		}

		public void TakeHit(Loc where)
		{
			Ship ship = getShipFromCell(where);
			ship?.DamagePart(where);
		}

		public void Fire(Loc where, Player enemy)
		{
			checkCellsValidity(where);

			if (HitBoxes.Contains(where))
				throw new InvalidShotException();
			++Attempts;
			HitBoxes.Add(where);
			enemy.TakeHit(where);
		}

		public bool IsShipPartCell(Loc where)
		{
			foreach (Ship ship in Fleet)
			{
				if (ship.IsOccupiedCell(where))
					return true;
			}
			return false;
		}

		public void PlaceShip(Loc pos, ShipType shipType)
		{
			// select ship to be placed, based on ShipType
			Ship selectedShip = getShipFromType(shipType);
			checkOverlap(selectedShip);
			selectedShip.RenewPosition(pos);
		}

		public void RotateShip(ShipType shipType)
		{
            Ship selectedShip = getShipFromType(shipType);
			checkOverlap(selectedShip);
            selectedShip.SwitchOrientation();
		}

		public void RandomFleetPlacement()
		{
			foreach (Ship ship in Fleet)
			{
				while (true)
				{
					Loc randPos = generateRandomLoc();
					try
					{
						PlaceShip(randPos, ship.Type);
						break;
					}
					catch (InvalidShipPlacementException) {}
				}
			}
		}

		private void constructFleet()
		{
			Fleet.Add(new Ship(ShipType.Carrier));
			Fleet.Add(new Ship(ShipType.Battleship));
			Fleet.Add(new Ship(ShipType.Cruiser));
			Fleet.Add(new Ship(ShipType.Submarine));
			Fleet.Add(new Ship(ShipType.Destroyer));
		}

		private void checkCellsValidity(Loc loc)
		{
			if (loc.row > GameState.GridDimension ||
				loc.column > GameState.GridDimension)
				throw new InvalidCellException();
		}

		// search for a Ship based on its position
		private Ship getShipFromCell(Loc where)
		{
			checkCellsValidity(where);

			foreach (Ship ship in Fleet)
			{
				if (ship.IsOccupiedCell(where))
					return ship;
			}
			return null;
		}

		private void checkOverlap(Ship selectedShip)
		{
			foreach (Ship ship in Fleet)
			{
				// iterate through fleet
				if (selectedShip.Equals(ship))
					// selected ship is the current ship
					continue;

				uint deltaColumn = (uint)Math.Abs(selectedShip.InitCell.column - ship.InitCell.column);
				uint deltaRow = (uint)Math.Abs(selectedShip.InitCell.row - ship.InitCell.row);

				if (selectedShip.HasEqualOrientation(ship))
				{
					// selected ship and current ship have the same orientation
					uint maxSize = Math.Max(selectedShip.Size, ship.Size);

					if (selectedShip.IsVertical)
						checkOverlapSameOrientation(maxSize, deltaColumn, deltaRow);
					else
						checkOverlapSameOrientation(maxSize, deltaRow, deltaColumn);
				}
				else
				{
					// selected ship and current ship have different orientations
					if (selectedShip.IsVertical)
						checkOverlapDifferentOrientation(ship.Size, selectedShip.Size, deltaRow, deltaColumn);
					else
						checkOverlapDifferentOrientation(selectedShip.Size, ship.Size, deltaRow, deltaColumn);
				}
			}
		}

		private void checkOverlapSameOrientation(uint maxSize, params uint[] deltaDimension)
		{
			if (deltaDimension[0] == 0 && deltaDimension[1] < maxSize)
				throw new InvalidShipPlacementException();
		}

		private void checkOverlapDifferentOrientation(uint horizontalShipSize, uint verticalShipSize, params uint[] deltaDimension)
		{
			if (deltaDimension[0] <= horizontalShipSize || deltaDimension[1] <= verticalShipSize)
				throw new InvalidShipPlacementException();
		}

		private Ship getShipFromType(ShipType shipType)
		{
			/*Ship ship = from theShip in Fleet
			where ship.Type == shipType
			select theShip;*/
			return Fleet.Single(sampleShip => sampleShip.Type == shipType);
		}

		private Loc generateRandomLoc()
		{
			return new Loc(random.Next(0, GameState.GridDimension),
				random.Next(0, GameState.GridDimension));
		}
	}
}

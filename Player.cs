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

		public void TakeHit(Loc where)
		{
			Ship ship = getShipFromCell(where);
			if (ship != null)
				ship.DamagePart(where);
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

		private Ship getShipFromType(ShipType shipType)
		{
			return Fleet.Single(sampleShip => sampleShip.Type == shipType);
		}

		public void PlaceShip(Loc pos, ShipType shipType)
		{
			/*Ship ship = from theShip in Fleet
						where ship.Type == shipType
						select theShip;*/
			Ship selectedShip = getShipFromType(shipType);
			foreach (Ship ship in Fleet)
			{
				if (selectedShip.Equals(ship))
					continue;

				if (selectedShip.HasEqualOrientation(ship))
				{
					if (!selectedShip.IsVertical)
					{
						if (selectedShip.InitCell.row == ship.InitCell.row)
						{
							if (Math.Abs(selectedShip.InitCell.column - ship.InitCell.column) <
								Math.Max(selectedShip.Size, ship.Size))
								throw new InvalidShipPlacementException();
						}
					}
					else
					{
						if (selectedShip.InitCell.column == ship.InitCell.column)
						{
							if (Math.Abs(selectedShip.InitCell.row - ship.InitCell.row) <
								Math.Max(selectedShip.Size, ship.Size))
								throw new InvalidShipPlacementException();
						}
					}
				}
				else
				{
					uint deltaColumn = Math.Abs(selectedShip.InitCell.column - ship.InitCell.column); // U
					uint deltaRow = Math.Abs(selectedShip.InitCell.row - ship.InitCell.row); // AΔ
					/*float cos1 = (float)(deltaRow / Math.Sqrt(Math.Pow(deltaColumn,2) + Math.Pow(deltaRow,2)));
					uint deltaRow2 = Math.Abs(selectedShip.Size - ship.InitCell.row);
					float cos2 = (float)(deltaRow2 / Math.Sqrt(Math.Pow(deltaColumn, 2) + Math.Pow(deltaRow2, 2)));

					if ((cos1 >= 0 && cos2 >= 0) && selectedShip.IsVertical ? )
						throw new InvalidShipPlacementException();*/
					if (selectedShip.IsVertical)
					{
						if (deltaColumn <= selectedShip.Size || deltaRow <= ship.Size)
							throw new InvalidShipPlacementException();
					}
					else
					{
						if (deltaColumn <= ship.Size || deltaRow <= selectedShip.Size)
							throw new InvalidShipPlacementException();
					}
				}
			}

			selectedShip.RenewPosition(pos);
		}

		public void RotateShip(ShipType shipType)
		{
			Ship ship = getShipFromType(shipType);

			// gigantic if checks here

			ship.SwitchOrientation();
		}

		private Loc generateRandomLoc()
		{
			return new Loc(random.Next(0, GameState.GridDimension),
				random.Next(0, GameState.GridDimension));
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
						ship.PlaceShip(randPos, ship.Type);
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

		public Player(string name)
		{
			Name = name;
			constructFleet();
		}
	}
}

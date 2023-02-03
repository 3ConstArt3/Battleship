using System;
using System.Collections.Generic;

namespace Battleship
{
	class Player
	{
		//private readonly List<Ship> m_fleet = new List<Ship>();
		public List<Ship> Fleet { get; } = new List<Ship>();
		public List<Loc> HitBoxes { get; } = new List<Loc>();
		public string Name { get; } = "";
		public uint Attempts { get; private set; } = 0;

		// search for a Ship based on its position
		public Ship SearchShip(Loc where)
		{
			foreach (Ship ship in Fleet)
			{
				if (ship.IsOccupiedCell(where))
					return ship;
			}
			return null;
		}

		// damage a ship at a given position, if it exists
		public void DamageShipIf(Loc where)
		{
			Ship ship = SearchShip(where);
			if (ship != null)
				ship.DamagePart(where);
		}

		public void Fire(Loc where, Player enemy)
		{
			if (!HitBoxes.Contains(where))
			{
				++Attempts;
				HitBoxes.Add(where);
				enemy.DamageShipIf(where);
			}
		}

		public Player(string name)
		{
			Name = name;
		}
	}
}

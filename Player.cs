using System;
using System.Collections.Generic;

namespace Battleship
{
	class Player
	{
		private readonly List<Ship> m_fleet = new List<Ship>();
		private readonly List<Loc> m_hitBoxes = new List<Loc>();
		private readonly string m_name = "";
		private uint m_attempts = 0;

		public List<Ship> GetFleet() { return m_fleet; }
		public List<Loc> GetHitBoxes() { return m_hitBoxes; }
		public uint GetAttempts() { return m_attempts; }


		// search for a Ship based on its position
		public Ship SearchShip(Loc where)
		{
			foreach (Ship ship in m_fleet)
			{
				/*foreach (Loc shipLoc in ship.Positions)
				{
					if (where == shipLoc)
						return ship;
				}*/
				if (ship.IsOccupiedCell(where))
					return ship;
			}
			return null;
		}

		/*// returns true if there's a ship of ours inside Loc p
		public bool isShipIn(Loc p)
		{
			return searchShip(p) ? true : false;
		}

		public bool isEnemyShipIn(Loc p, Player enemy)
		{
			return enemy.isShipIn(p);
		}*/

		// damage a ship at a given position, if it exists
		public void DamageShipIf(Loc where)
		{
			Ship ship = SearchShip(where);
			if (ship)
				ship.damagePart(where);
		}

		public void Fire(Loc where, Player enemy)
		{
			bool isANewPosition = true;
			foreach (Loc p in m_hitBoxes)
			{
				if (p == where)
					isANewPosition = false;
			}

			if (isANewPosition)
			{
				++m_attempts;
				m_hitBoxes.Add(where);
				enemy.DamageShipIf(where);
			}
		}

		public Player(string name)
		{
			m_name = name;
		}
	}
}

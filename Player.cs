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

		public List<Ship> getFleet() { return m_fleet; }
		public List<Loc> getHitBoxes() { return m_hitBoxes; }
		public uint getAttempts() { return m_attempts; }


		// search for a Ship based on its position
		public Ship searchShip(Loc where)
		{
			foreach (Ship ship in m_fleet)
			{
				/*foreach (Loc shipLoc in ship.Positions)
				{
					if (where == shipLoc)
						return ship;
				}*/
				if (ship.search(where))
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
		public void damageShipIf(Loc where)
		{
			Ship ship = searchShip(where);
			if (ship)
				ship.damagePart(where);
		}

		public void fire(Loc where, Player enemy)
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
				enemy.damageShipIf(where);
			}
		}

		public Player(string name)
		{
			m_name = name;
		}
	}
}

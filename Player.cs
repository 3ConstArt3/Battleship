using System;
using System.Collections.Generic;

namespace Battleship
{
	class Player
	{
		private readonly List<Ship> m_fleet = new List<Ship>();
		private readonly List<Point> m_hitBoxes = new List<Point>();
		private readonly string m_name = "";
		private uint m_attempts = 0;

		public List<Ship> getFleet() { return m_fleet; }
		public List<Point> getHitBoxes() { return m_hitBoxes; }
		public uint getAttempts() { return m_attempts; }


		// search for a Ship based on its position
		public Ship searchShip(Point where)
		{
			foreach (Ship ship in m_fleet)
			{
				/*foreach (Point shipPoint in ship.Positions)
				{
					if (where == shipPoint)
						return ship;
				}*/
				if (ship.search(where))
					return ship;
			}
			return null;
		}

		/*// returns true if there's a ship of ours inside point p
		public bool isShipIn(Point p)
		{
			return searchShip(p) ? true : false;
		}

		public bool isEnemyShipIn(Point p, Player enemy)
		{
			return enemy.isShipIn(p);
		}*/

		// damage a ship at a given position, if it exists
		public void damageShipIf(Point where)
		{
			Ship ship = searchShip(where);
			if (ship)
				ship.damagePart(where);
		}

		public void fire(Point where, Player enemy)
		{
			bool isANewPosition = true;
			foreach (Point p in m_hitBoxes)
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

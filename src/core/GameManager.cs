#region Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Battleship.Core
{

	public class GameManager
	{

		#region Variable Declaration
		public GameState GameState{ get; private set; }

		#endregion

		#region Method Declaration

		public void StartNewGame(string playerName)
		{
			GameState = new GameState(playerName, "Computer");
		}

		#endregion

	}

}
#region Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Battleship
{

	internal class GameManager
	{

		#region Variable Declaration
		public GameState GameState{ get; private set; }
		//public DatabaseMgr DatabaseMgr{ get; private set; }

		#endregion

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public GameManager()
		{
			
		}

		#region Method Declaration

		public void StartNewGame(string playerName)
		{
			GameState = new GameState(playerName, "Computer");
		}

		#endregion

	}

}
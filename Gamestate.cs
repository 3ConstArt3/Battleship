#region Imports
using System.Collections.Generic;
#endregion

namespace Battleship
{

	internal class Gamestate
	{

		#region Variable Declaration
		private Player player1;
		private Player player2;
		private bool isPlayer1Turn;
		#endregion

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public Gamestate( string player1Name, string player2Name )
		{
			player1 = new Player( player1Name );
			player2 = new Player( player2Name );
		}

		#region Method Declaration
		public void PlayerFires( Location where )
		{
			Player currentPlayer = getTargetPlayer( isPlayer1Turn );
			currentPlayer.Fire( where, getTargetPlayer( !isPlayer1Turn ) );
		}

		public bool PlayerCellContainsShip( Location where, bool isPlayer1 )
		{
			return getTargetPlayer( isPlayer1 ).IsCellPartOfShip( where );
		}

		public void PlayerPlaceShip( Location where, bool isPlayer1, ShipType shipType )
		{
			getTargetPlayer( isPlayer1 ).PlaceShip( where, shipType );
		}

		public void PlayerRotateShip( ShipType shipType, bool isPlayer1 )
		{
			getTargetPlayer( isPlayer1 ).RotateShip( shipType );
		}

		public void PlayerRandomFleetPlacement( bool isPlayer1 )
		{
			getTargetPlayer( isPlayer1 ).RandomFleetPlacement();
		}

		public List<Ship> GetPlayerFleet( bool isPlayer1 ) => getTargetPlayer( isPlayer1 ).Fleet;

		private Player getTargetPlayer( bool isPlayer1Turn ) => (isPlayer1Turn ? player1 : player2);
		#endregion

	}

}
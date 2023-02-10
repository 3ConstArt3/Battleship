#region Imports
using System;
using System.Collections.Generic;
#endregion

namespace Battleship
{

	public class GameState
	{

		#region Variable Declaration
		private Player player1;
		private Player player2;
		public const int GridDimension = 9;
		private bool isPlayer1Turn = true;
		private DateTime gameStartTimePoint;
		#endregion

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public GameState( string player1Name, string player2Name )
		{
			player1 = new Player( player1Name );
			player2 = new Player( player2Name );
			gameStartTimePoint = DateTime.Now;
		}

		#region Method Definition
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

        public void PlayerResetShip(ShipType shipType, bool isPlayer1)
        {
            getTargetPlayer( isPlayer1 ).ResetShip( shipType );
        }

        public void PlayerLockSetup(bool isPlayer1)
        {
			getTargetPlayer(isPlayer1).LockSetup();
        }

        public void PlayerRandomFleetPlacement( bool isPlayer1 )
		{
			getTargetPlayer( isPlayer1 ).RandomFleetPlacement();
		}

		public List<Ship> GetPlayerFleet( bool isPlayer1 ) => getTargetPlayer( isPlayer1 ).Fleet;

		public void ChangePlayerTurn()
		{
			isPlayer1Turn = !isPlayer1Turn;
		}

		public bool IsGameOver() => isPlayerFleetDestroyed(false) || isPlayerFleetDestroyed(true);

		public bool IsPlayer1Winner()
		{
			if (!IsGameOver())
				throw new GameNotOverException();
			return isPlayerFleetDestroyed(false);
		}

		public TimeSpan GetGameDuration() => DateTime.Now - gameStartTimePoint;

		private bool isPlayerFleetDestroyed(bool isPlayer1)
		{
			Player player = getTargetPlayer(isPlayer1);
			foreach (Ship ship in player.Fleet)
			{
				if (!ship.IsSunk())
					return false;
			}
			return true;
		}

		private Player getTargetPlayer( bool isPlayer1Turn ) => (isPlayer1Turn ? player1 : player2);
		#endregion

	}

}
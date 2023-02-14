#region Imports
using System;
using System.Collections.Generic;
using System.Linq;
using Battleship.Utils;

#endregion

namespace Battleship.Core
{

	public class GameState
	{

		#region Variable Declaration
		private readonly Player player1;
		private readonly Player player2;
		public const int GridDimension = 9;
		private readonly DateTime gameStartTimePoint;

        public bool IsPlayer1Turn { get; private set; }
        #endregion

        /// <summary>
        /// Constructor Definition.
        /// </summary>
        public GameState( string player1Name, string player2Name )
		{
			player1 = new Player( player1Name );
			player2 = new Player( player2Name );
			IsPlayer1Turn = true;
			gameStartTimePoint = DateTime.Now;
		}

		#region Method Definition
		public void PlayerFires(Location where, bool isPlayer1Turn)
		{
			Player currentPlayer = getTargetPlayer( isPlayer1Turn );
			currentPlayer.Fire( where, getTargetPlayer( !isPlayer1Turn ) );
		}

		public bool PlayerCellContainsShip( Location where, bool isPlayer1Turn)
		{
			return getTargetPlayer( isPlayer1Turn ).IsCellPartOfShip( where );
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

		public List<IDrawShip> GetPlayerFleet( bool isPlayer1 ) => getTargetPlayer( isPlayer1 ).Fleet.Cast<IDrawShip>().ToList();

		public void ChangePlayerTurn()
		{
			IsPlayer1Turn = !IsPlayer1Turn;
		}

		public bool IsGameOver() => isPlayerFleetDestroyed(false) || isPlayerFleetDestroyed(true);

		public bool IsPlayer1Winner()
		{
			if (!IsGameOver())
				throw new GameNotOverException();
			return isPlayerFleetDestroyed(false);
		}

		public void UpdateScore()
		{
			player1.UpdateScore(IsPlayer1Winner());
		}

		public string GetPlayerName(bool isPlayer1) => getTargetPlayer(isPlayer1).Name;

		public uint GetPlayerAttempts(bool isPlayer1) => getTargetPlayer(isPlayer1).Attempts;

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